using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class VlibroDiario
    {
        public int IdAsiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public decimal? Debe { get; set; }
        public decimal? Haber { get; set; }
    }
}
