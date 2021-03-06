#pragma checksum "..\..\..\..\View\PContabilidad.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1F75F27F6D2525663DDD71AA648916B6EBF3BB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Sistema_Contable.Models;
using Sistema_Contable.Models.DB;
using Sistema_Contable.View;
using Sistema_Contable.ViewModels;
using Syncfusion;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.UI.Xaml.TreeView;
using Syncfusion.UI.Xaml.TreeView.Engine;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Sistema_Contable.View {
    
    
    /// <summary>
    /// PContabilidad
    /// </summary>
    public partial class PContabilidad : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 168 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridEdit;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressTextBox;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox desTextBox;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridAdd;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MuestraCuenta;
        
        #line default
        #line hidden
        
        
        #line 261 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ProgressRing Progreso;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MyGrid;
        
        #line default
        #line hidden
        
        
        #line 265 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn ID_CuentaColumn;
        
        #line default
        #line hidden
        
        
        #line 266 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn ID_PadreColumn;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn NombreCuentaColumn;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn NivelColumn;
        
        #line default
        #line hidden
        
        
        #line 269 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn AuxiliarColumn;
        
        #line default
        #line hidden
        
        
        #line 270 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridCheckBoxColumn EstadoColumn;
        
        #line default
        #line hidden
        
        
        #line 294 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ViewComprobante;
        
        #line default
        #line hidden
        
        
        #line 296 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Gridprincipal;
        
        #line default
        #line hidden
        
        
        #line 304 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ComprobanteA;
        
        #line default
        #line hidden
        
        
        #line 310 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CambioA;
        
        #line default
        #line hidden
        
        
        #line 314 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Grid.SfDataGrid AsientoContableDataGrid;
        
        #line default
        #line hidden
        
        
        #line 325 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Gridsecundario;
        
        #line default
        #line hidden
        
        
        #line 351 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Fecha_registro;
        
        #line default
        #line hidden
        
        
        #line 353 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Descripcion_Comprobante;
        
        #line default
        #line hidden
        
        
        #line 364 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Prubadata;
        
        #line default
        #line hidden
        
        
        #line 408 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Registro;
        
        #line default
        #line hidden
        
        
        #line 409 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Borrar_todo;
        
        #line default
        #line hidden
        
        
        #line 410 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancelar;
        
        #line default
        #line hidden
        
        
        #line 432 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Total_Debe;
        
        #line default
        #line hidden
        
        
        #line 434 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Total_Haber;
        
        #line default
        #line hidden
        
        
        #line 448 "..\..\..\..\View\PContabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid firstDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Sistema_Contable;component/view/pcontabilidad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\PContabilidad.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 24 "..\..\..\..\View\PContabilidad.xaml"
            ((Sistema_Contable.View.PContabilidad)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridEdit = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.addressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.desTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.GridAdd = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.MuestraCuenta = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Progreso = ((MahApps.Metro.Controls.ProgressRing)(target));
            return;
            case 8:
            this.MyGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.ID_CuentaColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 10:
            this.ID_PadreColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            this.NombreCuentaColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 12:
            this.NivelColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 13:
            this.AuxiliarColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 14:
            this.EstadoColumn = ((System.Windows.Controls.DataGridCheckBoxColumn)(target));
            return;
            case 15:
            this.ViewComprobante = ((System.Windows.Controls.Grid)(target));
            return;
            case 16:
            this.Gridprincipal = ((System.Windows.Controls.Grid)(target));
            return;
            case 17:
            this.ComprobanteA = ((System.Windows.Controls.Grid)(target));
            return;
            case 18:
            this.CambioA = ((System.Windows.Controls.Button)(target));
            return;
            case 19:
            this.AsientoContableDataGrid = ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target));
            return;
            case 20:
            this.Gridsecundario = ((System.Windows.Controls.Grid)(target));
            return;
            case 21:
            this.Fecha_registro = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 22:
            this.Descripcion_Comprobante = ((System.Windows.Controls.TextBox)(target));
            return;
            case 23:
            this.Prubadata = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 24:
            this.Registro = ((System.Windows.Controls.Button)(target));
            return;
            case 25:
            this.Borrar_todo = ((System.Windows.Controls.Button)(target));
            return;
            case 26:
            this.Cancelar = ((System.Windows.Controls.Button)(target));
            return;
            case 27:
            this.Total_Debe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 28:
            this.Total_Haber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 29:
            this.firstDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

