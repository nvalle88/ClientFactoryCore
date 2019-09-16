using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class ContratoGesPacientes
    {
        public ContratoGesPacientes()
        {
            Caso = new HashSet<Caso>();
        }

        public long Id { get; set; }
        public long CodigoContrato { get; set; }
        public string CodigoProducto { get; set; }
        public string Region { get; set; }
        public int? NumeroContrato { get; set; }

        public virtual ICollection<Caso> Caso { get; set; }
    }
}
