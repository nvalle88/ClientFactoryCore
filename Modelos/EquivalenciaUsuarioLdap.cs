using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class EquivalenciaUsuarioLdap
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string NombreUsuarioLdap { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
