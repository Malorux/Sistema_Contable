﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class VcuentasContable
    {
        public int? IdCuenta { get; set; }
        public int? IdPadre { get; set; }
        public string NombreCuentaC { get; set; }
        public int? NivelC { get; set; }
        public string Auxiliar { get; set; }
    }
}
