using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sistema_Contable.Models
{
    public class AgregarCuenta
    {
        private int _Id_Cuenta;
        private string _Nombre_CuentaC;
        private decimal _Debe;
        private decimal _Haber;

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            var Handler = PropertyChanged;
            Handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public int Id_Cuenta
        {
            get => _Id_Cuenta;
            set { _Id_Cuenta = value; RaisePropertyChanged("Id_Cuenta"); }
        }

        public string Nombre_CuentaC
        {
            get => _Nombre_CuentaC;
            set { _Nombre_CuentaC = value; RaisePropertyChanged("Nombre_CuentaC"); }
        }

        public decimal Debe
        {
            get => _Debe;
            set { _Debe = value; RaisePropertyChanged("Debe"); }
        }

        public decimal Haber
        {
            get => _Haber;
            set { _Haber = value; RaisePropertyChanged("Haber"); }
        }
    }
}
