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
        public int IdRol { get; set; }
        public string Usuario1 { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Role IdRolNavigation { get; set; }
        public virtual ICollection<AsientoContable> AsientoContables { get; set; }
    }
}
