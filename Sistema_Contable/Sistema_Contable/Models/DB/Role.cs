using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class Role
    {
        public Role()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
