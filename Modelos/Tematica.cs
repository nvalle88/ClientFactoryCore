using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Tematica
    {
        public Tematica()
        {
            Equivalencia = new HashSet<Equivalencia>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual ICollection<Equivalencia> Equivalencia { get; set; }
    }
}
