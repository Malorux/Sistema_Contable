using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class AsientoContable
    {
        public AsientoContable()
        {
            AsientoDetalles = new HashSet<AsientoDetalle>();
        }

        public int IdAsiento { get; set; }
        public int IdUsuario { get; set; }
        public string Descripcion { get; set; }
        public decimal TotalDebe { get; set; }
        public decimal TotalHaber { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AsientoDetalle> AsientoDetalles { get; set; }
    }
}
