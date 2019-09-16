using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Funcionalidad
    {
        public Funcionalidad()
        {
            RolFuncionalidad = new HashSet<RolFuncionalidad>();
        }

        public Guid Id { get; set; }
        public int ProductoId { get; set; }
        public Guid ModuloId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string RutaBase { get; set; }
        public string RutaSecundaria { get; set; }
        public string RutaAdicional { get; set; }
        public bool EstadoActivo { get; set; }
        public string Codigo { get; set; }

        public virtual Modulo Modulo { get; set; }
        public virtual ICollection<RolFuncionalidad> RolFuncionalidad { get; set; }
    }
}
