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

        public ICommand CommandEdit => new DelegateCommand<object>(CommandEditMethod);
        public ICommand MyCommand2 => new DelegateCommand<object>(MyCommandMethod2);
        public ICommand CommanCargarCuenta => new DelegateCommand<object>(OnSeeTheDotNetsButtonClick);

        public Visibility Boton
        {
            get; set;
        }
        public Visibility Progreso
        {
            get; set;
        }
        public Visibility Tabla
        {
            get; set;
        }

        public ContabilidadViewModels()
        {
            Boton = Visibility.Visible;
            Progreso = Visibility.Collapsed;
            Tabla = Visibility.Hidden;
            //_listaCuenta = InitializeCollection();
            // Visible = 0;
            // Hidden = 1
            // Collapse = 2
        }

        public void CommandEditMethod(object parameter)
        {
            var modelo = parameter as VcuentaReporte;
            //MessageBox.Show(myModel.NombreCuentaC);
            //_listaCuenta.Remove(myModel);
        }
        public void MyCommandMethod2(object parameter)
        {
            var myModel = parameter as VcuentaReporte;
            MessageBox.Show(myModel.Auxiliar);
        }
        public async void OnSeeTheDotNetsButtonClick(object parameter)
        {

            Boton = Visibility.Collapsed;
            Progreso = Visibility.Visible;
            await Task.Run
                (
                    () =>
                    {
                        using (var db = new SistemaContableContext())
                        {
                            _listaCuenta = new ObservableCollection<VcuentaReporte>
                            (
                                db.VcuentaReportes.OrderBy(w => w.IdCuenta).ToList()
                            );

                        }
                    }
                );
            Progreso = Visibility.Collapsed;
            Tabla = Visibility.Visible;
        }

        //----------------------------------------------------------------------


        public VcuentaReporte _registroSelected;
        public ObservableCollection<VcuentaReporte> _listaCuenta
        {
            get;set;
        }
        //-----------------------------------------------------------------------

        private ObservableCollection<VcuentaReporte> InitializeCollection()
        {
            var mierda = db.VcuentaReportes.OrderBy(w => w.IdCuenta).ToList();
            ObservableCollection<VcuentaReporte> ac = new ObservableCollection<VcuentaReporte>();

            foreach (var item in mierda)
            {
                ac.Add(item);
            }
            return ac;
        }

        

    }
}
