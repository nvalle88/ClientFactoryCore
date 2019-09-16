using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class UsuarioRol
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid RolId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
