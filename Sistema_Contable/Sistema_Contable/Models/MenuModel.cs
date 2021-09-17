using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Sistema_Contable.Models
{
    public class MenuModel
    {
        public ICommand M_Command { get; }

        public MenuModel()
        {
            M_Command = new CommandViewModel(Execute);
        }

        public string MenuName { get; set; }
        public PathGeometry IconData { get; set; }
        public Page Pagina { get; set; }


        private void Execute()
        {
            foreach (Window window in Application.Current.Windows)
            {

                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainWindowFrame.Navigate(Pagina);

                }

            }

        }

    }
}

