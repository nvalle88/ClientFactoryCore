using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Rol
    {
        public Rol()
        {
            EquivalenciaRolLdap = new HashSet<EquivalenciaRolLdap>();
            RolFuncionalidad = new HashSet<RolFuncionalidad>();
            UsuarioRol = new HashSet<UsuarioRol>();
        }

        public Guid Id { get; set; }
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<EquivalenciaRolLdap> EquivalenciaRolLdap { get; set; }
        public virtual ICollection<RolFuncionalidad> RolFuncionalidad { get; set; }
        public virtual ICollection<UsuarioRol> UsuarioRol { get; set; }
    }
}
