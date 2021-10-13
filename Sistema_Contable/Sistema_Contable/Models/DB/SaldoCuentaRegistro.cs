using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class SaldoCuentaRegistro
    {
        public int IdCuenta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal? SaldoCuentaBase { get; set; }
    }
}
