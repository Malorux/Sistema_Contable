using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public string PrimerNombre { get; set; }
        public byte[] SegundoNombre { get; set; }
        public byte[] PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
