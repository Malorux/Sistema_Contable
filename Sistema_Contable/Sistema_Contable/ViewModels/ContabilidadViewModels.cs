using Sistema_Contable.Models;
using Sistema_Contable.Models.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Sistema_Contable.ViewModels
{
    public class ContabilidadViewModels : INotifyPropertyChanged
    {
        private SistemaContableContext db = new SistemaContableContext();
        private ComprobantesContables _ClaseD = new ComprobantesContables();
        //-----------------------------------------------------------------
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            var Handler = PropertyChanged;
            Handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Atributos
        private ObservableCollection<VcuentaReporte> _listaCuenta;
        private ObservableCollection<AsientoContable> _listaAsientoContable;
        private ObservableCollection<CuentaContable> _listaCuentaContable;

        public ICommand CommandEdit => new DelegateCommand<object>(CommandEditMethod);
        public ICommand CommanAdd => new DelegateCommand<object>(CommandAddMethod);
        public ICommand CommanCargarCuenta => new DelegateCommand(OnSeeTheDotNetsButtonClick);

        public ICommand CommandCancel => new DelegateCommand(CancelaAcciones);
        public ICommand CommandOk => new DelegateCommand(OkAcciones);

        public ICommand ComprobanteVisible => new DelegateCommand(Gridvisibilidad);
        public ICommand Cancelado => new DelegateCommand(cancelarvisible);
        public ICommand SumarDebe => new DelegateCommand(AgregarSumar);
        public ICommand EliminarMov => new DelegateCommand<object>(eliminarcuenta);
        public ICommand BorrarTodo => new DelegateCommand(DeleteALL);
        public ICommand MoverCuenta => new DelegateCommand<object>(AgregarMovimientos);
        public ICommand RegistrarMov => new DelegateCommand(registro);

        private Visibility _Boton;
        private Visibility _Progreso;
        private Visibility _Tabla;
        private Visibility _MuestraGridEdit;
        private Visibility _MuestraGridAdd;
        private Visibility _gridComprobanteContable1;
        private Visibility _gridComprobanteContable2;

        //----------------Para la parte de Update -----------------------------
        private PruebaCambio _Cambio;
        private VcuentaReporte modelo;
        private CatalogoCuentum catalogo;
        //----------------Para la parte del Add--------------------------------
        private AddCuenta _NuevaCuenta;


        //---------------------------------------------------------------------

        public AddCuenta NuevaCuenta
        {
            get => _NuevaCuenta;
            set
            {
                _NuevaCuenta = value;
                RaisePropertyChanged("NuevaCuenta");
            }
        }

        public ComprobantesContables ClaseD
        {
            get => _ClaseD;
            set
            {
                _ClaseD = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public void AgregarSumar()
        {
            totales();
        }

        public void totales()
        {
            ClaseD.Sumadebe = (double)ClaseD.Rezo.Sum(x => x.Debe);
            ClaseD.Sumahaber = (double)ClaseD.Rezo.Sum(i => i.Haber);
        }

        public void AgregarMovimientos(object parameter)
        {
            var puta = parameter as CuentaContable;
            ClaseD.Rezo.Add
               (
                 new AgregarCuenta
                 {
                     Id_Cuenta = puta.Id_Cuenta,
                     Nombre_CuentaC = puta.Nombre_CuentaC,
                     Debe = 0,
                     Haber = 0
                 }

                );
        }

        public void eliminarcuenta(object Parameter)
        {
            var u = Parameter as AgregarCuenta;
            ClaseD.deleted(u);
            totales();
        }

        public void DeleteALL()
        {
            borrar();
        }

        public void borrar()
        {
            ClaseD.Text = "";
            ClaseD.Rezo.Clear();
            totales();
            ClaseD.Date = "";
        }

        public void ValidarAsientoContable()
        {
            if (ClaseD.validaciones())
            {
                AsientoContable asientoC = new AsientoContable()
                {
                    IdUsuario = 1,
                    Descripcion = ClaseD.Text,
                    FechaRegistro = DateTime.Parse(ClaseD.Date)
                };
                db.AsientoContables.Add(asientoC);
                db.SaveChanges();
            }
            else
            {
                      
            }
        }

        //ClaseD.Text.Equals("") || ClaseD.Date.Equals("") || ClaseD.Sumadebe != ClaseD.Sumahaber || ClaseD.Sumadebe <= 0 || ClaseD.Sumahaber <= 0 || ClaseD.Rezo.Count <= 0

        public void registro()
        {
            ClaseD.Bandera = false;
            using (var contex = db.Database.BeginTransaction())
            {
                try
                {
                    ValidarAsientoContable();

                    if (ClaseD.validaciones())
                    {
                        int max = db.AsientoContables.Max(x => x.IdAsiento);
                        AsientoDetalle asientoD = new AsientoDetalle();
                        List<AsientoDetalle> introducir = new List<AsientoDetalle>();
                        foreach (var item in ClaseD.Rezo.ToList())
                        {
                            introducir.Add(new AsientoDetalle { IdAsiento = max, IdCuenta = item.Id_Cuenta, Debe = item.Debe, Haber = item.Haber });
                        }
                        db.AddRange(introducir);
                        db.SaveChanges();
                        contex.Commit();
                        borrar();
                        ClaseD.Bandera = true;
                        MessageBox.Show("Registro Guardado Correctamente");
                       
                    }
                    else
                    {
                        MessageBox.Show("No ha ingresado ningun movimiento o Falta la igualdad entre el debe y el haber");
                    }
                }
                catch (Exception m)
                {
                    MessageBox.Show("Error :" + m.Message);
                    contex.Rollback();
                    ClaseD.Bandera = false;

                }
            }
        }

        private void CancelaAcciones()
        {
            MuestraGridEdit = Visibility.Collapsed;
            MuestraGridAdd = Visibility.Collapsed;
            borrar();
        }

        private void OkAcciones()
        {
            if (MuestraGridEdit.Equals(Visibility.Visible))
            {
                if (Cambio.ValidaDatos())
                {
                    ListaCuenta.Remove(modelo);

                    //--------------------------------------------
                    catalogo.NombreCuenta = Cambio.Nombre;
                    catalogo.Descripcion = Cambio.Descripcion;
                    catalogo.Estado = Cambio.Indice == 0 ? false : true;
                    catalogo.FechaModificacion = DateTime.UtcNow;
                    //--------------------------------------------

                    modelo.NombreCuentaC = Cambio.Nombre;
                    modelo.Estado = Cambio.Indice == 0 ? false : true;
                    ListaCuenta.Add(modelo);

                    //-----------------------------------------------------
                    ListaCuenta = new ObservableCollection<VcuentaReporte>(ListaCuenta.OrderBy(w => w.Auxiliar));
                    db.CatalogoCuenta.Update(catalogo);
                    db.SaveChanges();
                    //----------------------------------------------------

                }
                else
                {
                    MessageBox.Show("Error Ingresa todos los campos");
                }
            }
            else if (MuestraGridAdd.Equals(Visibility.Visible))
            {
                if (NuevaCuenta.ValidaDatos())
                {
                    CatalogoCuentum ingreso = new CatalogoCuentum();

                    ingreso.IdPadre = catalogo.IdCuenta;
                    ingreso.IdClasificacion = catalogo.IdClasificacion;
                    ingreso.NombreCuenta = NuevaCuenta.Nombre;
                    ingreso.Descripcion = NuevaCuenta.Descripcion;
                    ingreso.Naturaleza = catalogo.Naturaleza;
                    ingreso.SaldoInicial = decimal.Parse(NuevaCuenta.Saldo);
                    ingreso.FechaCreacion = DateTime.Parse(NuevaCuenta.FechaModificacion);
                    ingreso.FechaModificacion = DateTime.Now;
                    ingreso.Estado = NuevaCuenta.Indice == 0 ? false : true;
                    ingreso.Filtro = true;

                    db.CatalogoCuenta.Add(ingreso);
                    db.SaveChanges();

                    ListaCuenta.Clear();

                    RellenarCuenta();

                    NuevaCuenta.Descripcion = "";
                    NuevaCuenta.Nombre = "";
                    NuevaCuenta.FechaModificacion = "";
                    NuevaCuenta.Saldo = "0";
                    NuevaCuenta.Indice = -1;

                    MessageBox.Show("Registro Guardado con Exito " + ListaCuenta.Count);


                }
                else
                {
                    MessageBox.Show("Error : Ingresa todos los campos");
                }
            }
        }

        public Visibility MuestraGridAdd
        {
            get => _MuestraGridAdd;
            set
            {
                _MuestraGridAdd = value;
                RaisePropertyChanged("MuestraGridAdd");
            }
        }

        public Visibility MuestraGridEdit
        {
            get => _MuestraGridEdit;
            set
            {
                _MuestraGridEdit = value;
                RaisePropertyChanged("MuestraGridEdit");
            }
        }
        public ContabilidadViewModels()
        {
            Boton = Visibility.Visible;
            Progreso = Visibility.Collapsed;
            Tabla = Visibility.Collapsed;

            MuestraGridEdit = Visibility.Collapsed;
            MuestraGridAdd = Visibility.Collapsed;

            GridComprobanteContable1 = Visibility.Visible;
            GridComprobanteContable2 = Visibility.Collapsed;

            ClaseD.Text = "";
            ClaseD.Date = "";
            ClaseD.Sumahaber = 0;
            ClaseD.Sumadebe = 0;

        }
        public void CommandEditMethod(object parameter)
        {
            MuestraGridAdd = Visibility.Collapsed;
            modelo = parameter as VcuentaReporte;
            catalogo = db.CatalogoCuenta.FirstOrDefault(w => w.IdCuenta == modelo.IdCuenta);
            Cambio = new PruebaCambio(catalogo);
            MuestraGridEdit = Visibility.Visible;
        }

        public void CommandAddMethod(object parameter)
        {
            modelo = parameter as VcuentaReporte;
            NuevaCuenta = new AddCuenta(modelo);
            catalogo = db.CatalogoCuenta.FirstOrDefault(w => w.IdCuenta == modelo.IdCuenta);

            MuestraGridEdit = Visibility.Collapsed;
            MuestraGridAdd = Visibility.Visible;
        }

        public PruebaCambio Cambio
        {
            get => _Cambio;
            set
            {
                _Cambio = value;
                RaisePropertyChanged();
            }
        }


        public Visibility Boton
        {
            get => _Boton;
            set
            {
                _Boton = value;
                RaisePropertyChanged();
            }
        }
        public Visibility Progreso
        {
            get => _Progreso;
            set
            {
                _Progreso = value;
                RaisePropertyChanged();
            }
        }
        public Visibility Tabla
        {
            get => _Tabla;
            set
            {
                _Tabla = value;
                RaisePropertyChanged();
            }
        }

        public Visibility GridComprobanteContable1
        {
            get => _gridComprobanteContable1;
            set
            {
                _gridComprobanteContable1 = value;
                RaisePropertyChanged();
            }
        }

        public Visibility GridComprobanteContable2
        {
            get => _gridComprobanteContable2;
            set
            {
                _gridComprobanteContable2 = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<VcuentaReporte> ListaCuenta
        {
            get => _listaCuenta;
            set
            {
                _listaCuenta = value;
                RaisePropertyChanged("ListaCuenta");
            }
        }

        public ObservableCollection<AsientoContable> ListaAsientoContable
        {
            get => _listaAsientoContable;
            set
            {
                _listaAsientoContable = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<CuentaContable> ListaCuentaContable
        {
            get => _listaCuentaContable;
            set
            {
                _listaCuentaContable = value;
                RaisePropertyChanged();
            }
        }

        private async void RellenarCuenta()
        {
            await Task.Run
                (
                    () =>
                    {
                        ListaCuenta = new ObservableCollection<VcuentaReporte>(db.VcuentaReportes.OrderBy(w => w.IdCuenta).ToList());
                    }
                );
        }

        private async void recargarmovimiento()
        {

            await Task.Run
              (
                 () =>
                 {

                     ListaAsientoContable = new ObservableCollection<AsientoContable>
                     (
                         db.AsientoContables.OrderBy(x => x.IdAsiento).ToList()
                     );
                 }
              );

        }

        public void Gridvisibilidad()
        {
            GridComprobanteContable1 = Visibility.Collapsed;
            GridComprobanteContable2 = Visibility.Visible;
        }

        public void cancelarvisible()
        {
            GridComprobanteContable2 = Visibility.Collapsed;
            GridComprobanteContable1 = Visibility.Visible;
            ClaseD.Rezo.Clear();
            ClaseD.Text = "";
            ClaseD.Date = "";

            if (ClaseD.Bandera)
            {
                ListaAsientoContable.Clear();
                recargarmovimiento();
            }
            else
            {
                MessageBox.Show("no se ingreso ningun movimiento");
            }
        }

        public async void OnSeeTheDotNetsButtonClick()
        {
            Boton = Visibility.Collapsed;
            Progreso = Visibility.Visible;
            await Task.Run
                (
                    () =>
                    {

                        using (var db = new SistemaContableContext())
                        {
                            ListaCuenta = new ObservableCollection<VcuentaReporte>(db.VcuentaReportes.OrderBy(w => w.IdCuenta).ToList());

                            recargarmovimiento();

                            ListaCuentaContable = new ObservableCollection<CuentaContable>
                                (
                                   db.VcuentaReportes.Where(x => x.Filtro.Value).OrderBy(x => x.IdCuenta).Select
                                   (j =>
                                      new CuentaContable
                                      {
                                          Id_Cuenta = (int)j.IdCuenta,
                                          Nombre_CuentaC = j.NombreCuentaC
                                      }
                                   )
                                );

                        }
                    }
                );
            Progreso = Visibility.Collapsed;
            Tabla = Visibility.Visible;
        }
    }


    public class PruebaCambio : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            var Handler = PropertyChanged;
            Handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public PruebaCambio(CatalogoCuentum cuenta)
        {
            Nombre = cuenta.NombreCuenta;
            Descripcion = cuenta.Descripcion;
            Indice = cuenta.Estado ? 1 : 0;
        }

        private string _Nombre;
        private string _Descricion;
        private int _Indice;
        public int Indice
        {
            get => _Indice;
            set
            {
                _Indice = value;
                RaisePropertyChanged();
            }
        }
        public string Nombre
        {
            set
            {
                _Nombre = value;
                RaisePropertyChanged();
            }
            get => _Nombre;
        }
        public string Descripcion
        {
            get => _Descricion;
            set
            {
                _Descricion = value;
                RaisePropertyChanged();
            }
        }

        public bool ValidaDatos()
        {
            if (Nombre.Equals("") || Descripcion.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public class AddCuenta : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            var Handler = PropertyChanged;
            Handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public AddCuenta(VcuentaReporte rep)
        {
            Saldo = "0";
            Descripcion = "";
            Nombre = "";
            FechaModificacion = "";
            ID = (int)rep.IdCuenta;
            _SaldoInicial = 0;

        }


        private string _FechaModificacion;
        private string _Nombre;
        private string _Descripcion;
        private decimal _SaldoInicial;
        private int _ID;
        private int _Indice;
        public int Indice
        {
            get => _Indice;
            set
            {
                _Indice = value;
                RaisePropertyChanged();
            }
        }

        public int ID
        {
            get => _ID;
            private set
            {
                _ID = value;
            }

        }

        private String _Saldo;

        public string Saldo
        {
            get => _Saldo;
            set
            {
                string s = value;
                bool p = decimal.TryParse(s, out _SaldoInicial);
                if (p)
                {
                    _Saldo = value;
                }
                else
                {
                    MessageBox.Show("Ingresa Una Cantidad Valida");
                    _Saldo = "0";
                    RaisePropertyChanged("Saldo");
                }
            }
        }
        public String Descripcion
        {
            get => _Descripcion;
            set
            {
                _Descripcion = value;
                RaisePropertyChanged("Descripcion");
            }
        }
        public string FechaModificacion
        {
            get => _FechaModificacion;
            set
            {
                _FechaModificacion = value;
                RaisePropertyChanged("FechaModificacion");
            }
        }
        public String Nombre
        {
            get => _Nombre;
            set
            {
                _Nombre = value;
                RaisePropertyChanged("Nombre");
            }
        }

        public bool ValidaDatos()
        {
            if (FechaModificacion.Equals("") || Nombre.Equals("") || Descripcion.Equals("") || Saldo.Equals("") || Indice == -1 || _SaldoInicial == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class ComprobantesContables : INotifyPropertyChanged
    {

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            var Handler = PropertyChanged;
            Handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private ObservableCollection<AgregarCuenta> _Rezo = new ObservableCollection<AgregarCuenta>();

        public ObservableCollection<AgregarCuenta> Rezo
        {
            get => _Rezo;
            set { _Rezo = value; RaisePropertyChanged(); }
        }

        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                RaisePropertyChanged();
            }
        }

        private string _date;
        public string Date
        {
            get => _date;
            set
            {
                _date = value;
                RaisePropertyChanged();
            }
        }

        private double _sumadebe;
        public double Sumadebe
        {
            get
            {
                return _sumadebe;
            }
            set
            {
                _sumadebe = value;
                RaisePropertyChanged();
            }
        }

        private double _sumahaber;
        public double Sumahaber
        {
            get
            {
                return _sumahaber;
            }
            set
            {
                _sumahaber = value;
                RaisePropertyChanged();
            }
        }

        private bool _bandera;
        public bool Bandera
        {
            get => _bandera;
            set
            {
                _bandera = value;
                RaisePropertyChanged();
            }
        }

        public void add(AgregarCuenta agregar)
        {
            RaisePropertyChanged("Rezo");
            Rezo.Add(agregar);
        }

        public void deleted(AgregarCuenta borrar)
        {
            Rezo.Remove(borrar);
            RaisePropertyChanged("Rezo");
        }

        public bool validaciones() 
        {
            if (Text.Equals("") || Date.Equals("") || Sumadebe != Sumahaber || Sumadebe <= 0 || Sumahaber <= 0 || Rezo.Count <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }     
        }

    }
}
