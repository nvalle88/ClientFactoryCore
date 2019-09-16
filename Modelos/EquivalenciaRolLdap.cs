using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class EquivalenciaRolLdap
    {
        public Guid Id { get; set; }
        public Guid RolId { get; set; }
        public string NombreGrupoLdap { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
