using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class PrestadorUsuario
    {
        public Guid Id { get; set; }
        public int PrestadorId { get; set; }
        public Guid UsuarioId { get; set; }

        public virtual Prestador Prestador { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
