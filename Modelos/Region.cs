using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Region
    {
        public Region()
        {
            Ciudad = new HashSet<Ciudad>();
        }

        public short Id { get; set; }
        public string Nombre { get; set; }
        public short PaisId { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual ICollection<Ciudad> Ciudad { get; set; }
    }
}
