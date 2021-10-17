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

using Microsoft.EntityFrameworkCore;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace Sistema_Contable.View
{
    public partial class PContabilidad : Page
    {
        
        //CollectionViewSource CuentasNivel;
        //CollectionViewSource LibroDiario;

        //ObservableCollection<VcuentaReporte> listaCuenta = new ObservableCollection<VcuentaReporte>();
        //SistemaContableContext contex = new SistemaContableContext();


        public PContabilidad()
        {
            InitializeComponent();
            //CuentasNivel = ((CollectionViewSource)(FindResource("categoryViewSource")));
            //LibroDiario = ((CollectionViewSource)(FindResource("libroDiarioViewSource")));
            
            //dataGrid.ItemsSourceChanged += dataGrid_ItemsSourceChanged;
            //dataGrid.QueryCoveredRange += dataGrid_QueryCoveredRange;
        }

        /*
        private async void OnSeeTheDotNetsButtonClick(object sender, RoutedEventArgs e)
        {
            // ItemsSource="{Binding Source={StaticResource categoryViewSource}}"
            await Task.Run
                (
                    () =>
                    {
                        using (var db = new SistemaContableContext())
                        {
                            listaCuenta = new ObservableCollection<VcuentaReporte>
                            (
                                db.VcuentaReportes.OrderBy(w => w.IdCuenta).ToList()
                            );
                            
                        }
                    }
                );
            //CuentasNivel.Source = listaCuenta;
            //CuentasNivelDataGrid.ItemsSource = listaCuenta;
            //Progreso.IsEnabled = false;
            //dProgreso.Visibility = Visibility.Collapsed;
            //CuentasNivelDataGrid.Visibility = Visibility.Visible;   
            
        }
        */
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //using (var contex = new SistemaContableContext())
            //{
            //    LibroDiario.Source = contex.VlibroDiarios.ToList();
            //}
        }

        private void AddCuentaCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            //VcuentaReporte ob = e.Parameter as VcuentaReporte;
            //listaCuenta.Add
            //(
            //    new VcuentaReporte()
            //    {
            //        IdCuenta = 119,
            //        IdPadre = ob.IdCuenta,
            //        NombreCuentaC = "Michaell Reyes",
            //        Auxiliar = "12212",
            //        NivelC = 5,
            //        Filtro = true
            //    }
            //);
            //CuentasNivelDataGrid.ItemsSource = listaCuenta.OrderBy(w => w.IdCuenta);
        }
 
        private void EditarCuentaCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            VcuentaReporte ob = e.Parameter as VcuentaReporte;
            //int contador = (from c in contex.CatalogoCuenta where 
            //                c.IdPadre == ob.IdCuenta select c).Count();

            //CatalogoCuentum d = contex.CatalogoCuenta.Where(w => w.IdCuenta == ob.IdCuenta).FirstOrDefault();

            //contex.CatalogoCuenta.Remove(d);
            //contex.SaveChanges();
            //listaCuenta.Remove(ob);
        }
  
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        ///


        IPropertyAccessProvider reflector = null;

        /// <summary>
        /// ItemsSourceChanged event handler.
        /// </summary>

        //void dataGrid_ItemsSourceChanged(object sender, GridItemsSourceChangedEventArgs e)
        //{

        //    if (dataGrid.View != null)
        //        reflector = dataGrid.View.GetPropertyAccessProvider();

        //    else
        //        reflector = null;
        //}

        //void dataGrid_QueryCoveredRange(object sender, GridQueryCoveredRangeEventArgs e)
        //{
        //    if (e.RowColumnIndex.ColumnIndex == 0 )
        //    {
        //        var range = GetRange(e.GridColumn, e.RowColumnIndex.RowIndex, e.RowColumnIndex.ColumnIndex, e.Record);


        //        if (range == null)
        //            return;

        //        // Puede saber que el rango ya existe en Covered Cells por el método IsInRange.

        //        if (!dataGrid.CoveredCells.IsInRange(range))
        //        {
        //            e.Range = range;
        //            e.Handled = true;
        //        }

        //        // Si el rango calculado ya existe en CoveredCells, puede obtener el rango usando el
        //        // método de extensión SfDataGrid.GetConflictRange(CoveredCellInfoveredCellInfo).
        //    }
        //}


        //private CoveredCellInfo GetRange(GridColumn column, int rowIndex, int columnIndex, object rowData)
        //{
        //    var range = new CoveredCellInfo(columnIndex, columnIndex, rowIndex, rowIndex);
        //    object data = reflector.GetFormattedValue(rowData, column.MappingName);

        //    GridColumn leftColumn = null;
        //    GridColumn rightColumn = null;

        //    // total rows count.
        //    int recordsCount = this.dataGrid.GroupColumnDescriptions.Count != 0 ?
        //    (this.dataGrid.View.TopLevelGroup.DisplayElements.Count + this.dataGrid.TableSummaryRows.Count + this.dataGrid.UnBoundRows.Count + (this.dataGrid.AddNewRowPosition == AddNewRowPosition.Top ? +1 : 0)) :
        //    (this.dataGrid.View.Records.Count + this.dataGrid.TableSummaryRows.Count + this.dataGrid.UnBoundRows.Count + (this.dataGrid.AddNewRowPosition == AddNewRowPosition.Top ? +1 : 0));


        //    for (int i = dataGrid.Columns.IndexOf(column); i < this.dataGrid.Columns.Count - 1; i++)
        //    {
        //        var compareData = reflector.GetFormattedValue(rowData, dataGrid.Columns[i + 1].MappingName);

        //        if (compareData == null)
        //            break;

        //        if (!compareData.Equals(data))
        //            break;
        //        rightColumn = dataGrid.Columns[i + 1];
        //    }

        //    // compare left column.

        //    for (int i = dataGrid.Columns.IndexOf(column); i > 0; i--)
        //    {
        //        var compareData = reflector.GetFormattedValue(rowData, dataGrid.Columns[i - 1].MappingName);

        //        if (compareData == null)
        //            break;

        //        if (!compareData.Equals(data))
        //            break;
        //        leftColumn = dataGrid.Columns[i - 1];
        //    }

        //    if (leftColumn != null || rightColumn != null)
        //    {

        //        // set left index

        //        if (leftColumn != null)
        //        {
        //            var leftColumnIndex = this.dataGrid.ResolveToScrollColumnIndex(this.dataGrid.Columns.IndexOf(leftColumn));
        //            range = new CoveredCellInfo(leftColumnIndex, range.Right, range.Top, range.Bottom);
        //        }

        //        // set right index

        //        if (rightColumn != null)
        //        {
        //            var rightColumnIndex = this.dataGrid.ResolveToScrollColumnIndex(this.dataGrid.Columns.IndexOf(rightColumn));
        //            range = new CoveredCellInfo(range.Left, rightColumnIndex, range.Top, range.Bottom);
        //        }
        //        return range;
        //    }

        //    // Merge Vertically from the row index.

        //    int previousRowIndex = -1;
        //    int nextRowIndex = -1;

        //    // Get previous row data.                
        //    var startIndex = dataGrid.ResolveStartIndexBasedOnPosition();

        //    for (int i = rowIndex - 1; i >= startIndex; i--)
        //    {
        //        var previousData = this.dataGrid.GetRecordEntryAtRowIndex(i);

        //        if (previousData == null || !previousData.IsRecords)
        //            break;
        //        var compareData = reflector.GetFormattedValue((previousData as RecordEntry).Data, column.MappingName);

        //        if (compareData == null)
        //            break;

        //        if (!compareData.Equals(data))
        //            break;
        //        previousRowIndex = i;
        //    }

        //    // get next row data.

        //    for (int i = rowIndex + 1; i < recordsCount + 1; i++)
        //    {
        //        var nextData = this.dataGrid.GetRecordEntryAtRowIndex(i);

        //        if (nextData == null || !nextData.IsRecords)
        //            break;
        //        var compareData = reflector.GetFormattedValue((nextData as RecordEntry).Data, column.MappingName);

        //        if (compareData == null)
        //            break;

        //        if (!compareData.Equals(data))
        //            break;
        //        nextRowIndex = i;
        //    }

        //    if (previousRowIndex != -1 || nextRowIndex != -1)
        //    {

        //        if (previousRowIndex != -1)
        //            range = new CoveredCellInfo(range.Left, range.Right, previousRowIndex, range.Bottom);

        //        if (nextRowIndex != -1)
        //            range = new CoveredCellInfo(range.Left, range.Right, range.Top, nextRowIndex);
        //        return range;
        //    }
        //    return null;
        //}

        //private void CuentasNivelDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        //{
        //    DataGridColumn c = e.Column;

        //    if(c.Header.ToString() == "Acciones")
        //    {
        //        string d = (e.EditingElement as TextBox).Text;
        //        MessageBox.Show(d);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Soy una mierda");
        //    }
        //}

        //private void CuentasNivelDataGrid_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        //{
        //    VcuentaReporte culo = e.OriginalSource as VcuentaReporte;
        //    MessageBox.Show(culo.NombreCuentaC);
        //}

        //-----------------------------------------------------------------------------------------------------------

        //CollectionViewSource CuentasNivel;
        //CollectionViewSource AsientoContableVista;
        //CollectionViewSource Cuentasdetalle;
        //CollectionViewSource Agregarcuentavista;
        //ObservableCollection<AgregarCuenta> agregars = new ObservableCollection<AgregarCuenta>();
        //SistemaContableContext context = new SistemaContableContext();

        //public PContabilidad()
        //{
        //    InitializeComponent();
        //    CuentasNivel = ((CollectionViewSource)(FindResource("categoryViewSource")));
        //    AsientoContableVista = ((CollectionViewSource)(FindResource("asientoViewSource")));
        //    Cuentasdetalle = ((CollectionViewSource)(FindResource("filtrocuenta")));
        //    Agregarcuentavista = ((CollectionViewSource)(FindResource("AgregarcuentaViewSource")));
        //}

        //private async void OnSeeTheDotNetsButtonClick(object sender, RoutedEventArgs e)
        //{
        //    IEnumerable<AsientoContable> asientocontable = new ObservableCollection<AsientoContable>();
        //    IEnumerable<CuentaContable> cuentasdetalladas = new ObservableCollection<CuentaContable>();
        //    IEnumerable<VcuentaReporte> listaCuenta = new ObservableCollection<VcuentaReporte>();

        //    await Task.Run
        //        (
        //            () =>
        //            {
        //                using (var db = new SistemaContableContext())
        //                {
        //                    listaCuenta = db.VcuentaReportes.OrderBy(w => w.IdCuenta).ToList();

        //                    asientocontable =
        //                        (from a in db.AsientoContables
        //                         orderby a.IdAsiento
        //                         select
        //                             new AsientoContable
        //                             {
        //                                 IdAsiento = a.IdAsiento,
        //                                 IdUsuario = a.IdUsuario,
        //                                 FechaRegistro = a.FechaRegistro,
        //                                 Descripcion = a.Descripcion
        //                             }
        //                        ).ToList();

        //                    cuentasdetalladas =
        //                        (from b in db.VcuentaReportes
        //                         where b.Filtro == true
        //                         orderby b.IdCuenta
        //                         select
        //                            new CuentaContable
        //                            {
        //                                Id_Cuenta = (int)b.IdCuenta,
        //                                Nombre_CuentaC = b.NombreCuentaC

        //                            }).ToList();
        //                }
        //            }
        //        );

        //    Cuentasdetalle.Source = cuentasdetalladas;
        //    AsientoContableVista.Source = asientocontable;
        //    CuentasNivel.Source = listaCuenta;
        //    Progreso.IsEnabled = false;
        //    Progreso.Visibility = Visibility.Collapsed;
        //    CuentasNivelDataGrid.Visibility = Visibility.Visible;
        //}

        //private void AgregarMovimientoComandhandler(object sender, ExecutedRoutedEventArgs e)
        //{
        //    CuentaContable cuenta = e.Parameter as CuentaContable;
        //    agregars.Add
        //        (
        //            new AgregarCuenta
        //            {
        //                Id_Cuenta = cuenta.Id_Cuenta,
        //                Nombre_CuentaC = cuenta.Nombre_CuentaC,
        //                Debe = 0,
        //                Haber = 0
        //            }
        //        );
        //    Agregarcuentavista.Source = agregars;
        //    totales();
        //}

        //private void EliminarMovimientoCommandhandler(object sender, ExecutedRoutedEventArgs e)
        //{
        //    agregars.RemoveAt(secondDataGrid.SelectedIndex);

        //}

        private void secondDataGrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
           //totales(); 
        }

        //private void totales()
        //{
        //    Total_Debe.Text = agregars.Sum(x => x.Debe).ToString();
        //    Total_Haber.Text = agregars.Sum(x => x.Haber).ToString();
        //}

        private void Comprobantes_Click(object sender, RoutedEventArgs e)
        {
            //Button boton = (Button)sender;
            //switch (boton.Name)
            //{
            //    case "CambioA":
            //        {
            //            Gridprincipal.Visibility = Visibility.Collapsed;
            //            Gridsecundario.Visibility = Visibility.Visible;
            //            break;
            //        }
            //    case "Borrar_todo":
            //        {
            //            borrar_Asunto();
            //            break;
            //        }
            //    case "Registro":
            //        {
            //            if (Total_Debe.Text.Equals(Total_Haber.Text))
            //            {
            //                using (var db = context.Database.BeginTransaction())
            //                {
            //                    try
            //                    {

            //                        AsientoContable asientoC = new AsientoContable()
            //                        {
            //                            IdUsuario = 1,
            //                            Descripcion = Descripcion_Comprobante.Text,
            //                            FechaRegistro = Fecha_registro.DisplayDate
            //                        };

            //                        context.AsientoContables.Add(asientoC);
            //                        context.SaveChanges();

            //                        try
            //                        {
            //                            int max = context.AsientoContables.Max(x => x.IdAsiento);
            //                            AsientoDetalle asientoD = new AsientoDetalle();
            //                            List<AsientoDetalle> introducir = new List<AsientoDetalle>();

            //                            foreach (var item in agregars.ToList())
            //                            {
            //                                introducir.Add(new AsientoDetalle { IdAsiento = max, IdCuenta = item.Id_Cuenta, Debe = item.Debe, Haber = item.Haber });
            //                            }
            //                            context.AddRange(introducir);
            //                            context.SaveChanges();

            //                        }
            //                        catch (Exception j)
            //                        {
            //                            MessageBox.Show("Error :" + j.Message);
            //                            db.Rollback();
            //                        }

            //                        db.Commit();
            //                        borrar_Asunto();
            //                        MessageBox.Show("Registro Guardado Correctamente");
            //                    }
            //                    catch (Exception m)
            //                    {
            //                        MessageBox.Show("Error :" + m.Message);
            //                        db.Rollback();
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("El Total de debe y el haber deben de ser iguales");
            //            }

            //            break;
            //        }
            //    case "Cancelar":
            //        {
            //            borrar_Asunto();
            //            Gridprincipal.Visibility = Visibility.Visible;
            //            Gridsecundario.Visibility = Visibility.Collapsed;
            //            break;
            //        }
            //}
        }

        private void borrar_Asunto()
        {
            //Fecha_registro.Text = null;
            //Descripcion_Comprobante.Text = null;
            //agregars.Clear();
            //Total_Debe.Text = null;
            //Total_Haber.Text = null;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Regex regex = new Regex();
            //e.Handled = regex.IsMatch(e.Text);
        }
    }

}

