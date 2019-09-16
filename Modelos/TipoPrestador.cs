using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class TipoPrestador
    {
        public TipoPrestador()
        {
            Prestador = new HashSet<Prestador>();
        }

        public short Id { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual ICollection<Prestador> Prestador { get; set; }
    }
}
