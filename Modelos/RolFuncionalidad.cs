using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class RolFuncionalidad
    {
        public Guid Id { get; set; }
        public Guid RolId { get; set; }
        public Guid FuncionalidadId { get; set; }

        public virtual Funcionalidad Funcionalidad { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
