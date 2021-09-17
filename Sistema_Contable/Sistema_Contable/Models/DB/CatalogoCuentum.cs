using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class CatalogoCuentum
    {
        public CatalogoCuentum()
        {
            AsientoDetalles = new HashSet<AsientoDetalle>();
            InverseIdPadreNavigation = new HashSet<CatalogoCuentum>();
        }

        public int IdCuenta { get; set; }
        public int? IdPadre { get; set; }
        public int? IdClasificacion { get; set; }
        public string NombreCuenta { get; set; }
        public string Descripcion { get; set; }
        public string Naturaleza { get; set; }
        public decimal SaldoInicial { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; }

        public virtual Clasificacion IdClasificacionNavigation { get; set; }
        public virtual CatalogoCuentum IdPadreNavigation { get; set; }
        public virtual CatalogosEstado CatalogosEstado { get; set; }
        public virtual ICollection<AsientoDetalle> AsientoDetalles { get; set; }
        public virtual ICollection<CatalogoCuentum> InverseIdPadreNavigation { get; set; }
    }
}
