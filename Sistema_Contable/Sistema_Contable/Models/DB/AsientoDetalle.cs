using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class AsientoDetalle
    {
        public int IdAsientoDetalle { get; set; }
        public int IdAsiento { get; set; }
        public int IdCuenta { get; set; }
        public decimal? Debe { get; set; }
        public decimal? Haber { get; set; }

        public virtual AsientoContable IdAsientoNavigation { get; set; }
        public virtual CatalogoCuentum IdCuentaNavigation { get; set; }
    }
}
