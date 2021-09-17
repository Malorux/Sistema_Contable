
using Sistema_Contable.Models;
using Sistema_Contable.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Sistema_Contable.ViewModels
{
    public class MenuViewModels
    {

        //i will drop the download link for assets in the description
        private ResourceDictionary dictionary = Application.LoadComponent(new Uri("/Sistema_Contable;component/Assets/icons.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;

        ObservableCollection<MenuModel> _menuItems { get; set; }

        public ObservableCollection<MenuModel> MenuItems
        {
            get { return _menuItems; }
            set { _menuItems = value; }
        }


        public MenuViewModels()
        {
            _menuItems = new ObservableCollection<MenuModel>()
            {
                new MenuModel(){ IconData=(PathGeometry)dictionary["dashboard"],MenuName="Contabilidad",Pagina = new PContabilidad()},
                new MenuModel(){ IconData=(PathGeometry)dictionary["allcourses"],MenuName="Finanzas"},
                new MenuModel(){ IconData=(PathGeometry)dictionary["folder"], MenuName="Compras" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["profile"], MenuName="Ventas" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["chats"], MenuName="Inventario" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["estrella"], MenuName="Reportes" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["settings"], MenuName="Configuracion" }
            };
        }
    }
}
