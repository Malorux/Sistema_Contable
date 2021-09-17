using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class CatalogosEstado
    {
        public int IdCuenta { get; set; }
        public int IdEstadoFinanciero { get; set; }

        public virtual CatalogoCuentum IdCuentaNavigation { get; set; }
        public virtual EstadosFinanciero IdEstadoFinancieroNavigation { get; set; }
    }
}
