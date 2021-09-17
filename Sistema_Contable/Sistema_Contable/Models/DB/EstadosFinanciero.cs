using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class EstadosFinanciero
    {
        public EstadosFinanciero()
        {
            CatalogosEstados = new HashSet<CatalogosEstado>();
        }

        public int IdEstadoFinanciero { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<CatalogosEstado> CatalogosEstados { get; set; }
    }
}
