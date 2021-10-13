using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Contable.Models
{
    public class AgregarCuenta
    {
        public int Id_Cuenta { get; set; }
        public string Nombre_CuentaC { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
    }
}
