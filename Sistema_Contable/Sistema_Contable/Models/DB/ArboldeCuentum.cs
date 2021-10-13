using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class ArboldeCuentum
    {
        public int IdCuenta { get; set; }
        public int? IdPadre { get; set; }
        public string NombreCuenta { get; set; }
        public string Naturaleza { get; set; }
        public int Nivel1 { get; set; }
        public int Nivel2 { get; set; }
        public int Nivel3 { get; set; }
        public int Nivel4 { get; set; }
        public int Nivel5 { get; set; }
    }
}
