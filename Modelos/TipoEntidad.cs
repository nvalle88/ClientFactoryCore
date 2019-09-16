using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class TipoEntidad
    {
        public TipoEntidad()
        {
            Entidad = new HashSet<Entidad>();
        }

        public byte Id { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
