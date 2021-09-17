using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class Clasificacion
    {
        public Clasificacion()
        {
            CatalogoCuenta = new HashSet<CatalogoCuentum>();
        }

        public int IdClasificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<CatalogoCuentum> CatalogoCuenta { get; set; }
    }
}
