using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Linq;

using Sistema_Contable.Models.DB;
using System.Collections.ObjectModel;

namespace Sistema_Contable.View
{
    public partial class PContabilidad : Page
    {
        CollectionViewSource CuentasNivel;

        public PContabilidad()
        {
            InitializeComponent();
            CuentasNivel = ((CollectionViewSource)(FindResource("categoryViewSource")));
            

        }
        private async void OnSeeTheDotNetsButtonClick(object sender, RoutedEventArgs e)
        {
            IEnumerable<VcuentasContable> listaCuenta = new ObservableCollection<VcuentasContable>();
            
            await Task.Run
                (
                    () =>
                    {
                        using (var db = new SistemaContableContext())
                        {
                              listaCuenta =
                                (from c in db.VcuentasContables orderby c.IdCuenta
                                 select
                                    new VcuentasContable
                                    {
                                        IdCuenta = c.IdCuenta,
                                        IdPadre = c.IdPadre,
                                        NombreCuentaC = c.NombreCuentaC,
                                        NivelC = c.NivelC,
                                        Auxiliar = c.Auxiliar
                                    }
                                ).ToList();
                        }
                    }
                );

            CuentasNivel.Source = listaCuenta;
            Progreso.IsEnabled = false;
            Progreso.Visibility = Visibility.Collapsed;
            CuentasNivelDataGrid.Visibility = Visibility.Visible;
            
        }



        private void MuestraCuenta_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void DeleteCuentaCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            
            
        }

    }
}
