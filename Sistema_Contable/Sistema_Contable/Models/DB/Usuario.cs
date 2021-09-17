using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class Usuario
    {
        public Usuario()
        {
            AsientoContables = new HashSet<AsientoContable>();
        }

        public int IdUsuario { get; set; }
        public int IdTipoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual Persona IdUsuarioNavigation { get; set; }
        public virtual ICollection<AsientoContable> AsientoContables { get; set; }
    }
}
