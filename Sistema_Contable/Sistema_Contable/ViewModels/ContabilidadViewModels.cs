using Sistema_Contable.Models.DB;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Sistema_Contable.ViewModels
{
    public class ContabilidadViewModels : INotifyPropertyChanged
    {
        private SistemaContableContext db = new SistemaContableContext();
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
        public ICommand CommandEdit => new DelegateCommand<object>(CommandEditMethod);
        public ICommand CommanAdd => new DelegateCommand<object>(CommandAddMethod);
        public ICommand CommanCargarCuenta => new DelegateCommand(OnSeeTheDotNetsButtonClick);

        public ICommand CommandCancel => new DelegateCommand(CancelaAcciones);
        public ICommand CommandOk => new DelegateCommand(OkAcciones);

        private Visibility _Boton;
        private Visibility _Progreso;
        private Visibility _Tabla;
        private Visibility _MuestraGridEdit;
        private Visibility _MuestraGridAdd;

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


        #endregion

        private void CancelaAcciones()
        {
            MuestraGridEdit = Visibility.Collapsed;
            MuestraGridAdd = Visibility.Collapsed;
            //DatePicker cu = new DatePicker();
            //cu.DisplayDate
        }
        private void OkAcciones()
        {
            if(MuestraGridEdit.Equals(Visibility.Visible))
            {
                if(Cambio.ValidaDatos())
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
            else if(MuestraGridAdd.Equals(Visibility.Visible))
            {
                if(NuevaCuenta.ValidaDatos())
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

                    MessageBox.Show("Registro Guardado con Exito "+ListaCuenta.Count);
                    
                    
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

        public ObservableCollection<VcuentaReporte> ListaCuenta
        {
            get => _listaCuenta;
            set
            {
                _listaCuenta = value;
                RaisePropertyChanged("ListaCuenta");
            }
        }

        
        private async void RellenarCuenta()
        {
            await Task.Run
                (
                    () =>
                    {
                        ListaCuenta = new ObservableCollection<VcuentaReporte>
                        (
                            db.VcuentaReportes.OrderBy(w => w.IdCuenta).ToList()
                        );

                    }
                );
        }
        public async void OnSeeTheDotNetsButtonClick()
        {
            Boton = Visibility.Collapsed;
            Progreso = Visibility.Visible;

            await Task.Run
                (
                    () =>
                    {
                        ListaCuenta = new ObservableCollection<VcuentaReporte>
                        (
                            db.VcuentaReportes.OrderBy(w => w.IdCuenta).ToList()
                        );

                    }
                );
            Task.WaitAll();
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
            if(Nombre.Equals("") || Descripcion.Equals(""))
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
                if(p)
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
            if(FechaModificacion.Equals("") || Nombre.Equals("") || Descripcion.Equals("") || Saldo.Equals("") || Indice == -1 || _SaldoInicial == 0 )
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
