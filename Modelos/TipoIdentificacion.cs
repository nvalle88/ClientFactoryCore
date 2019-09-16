using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class TipoIdentificacion
    {
        public TipoIdentificacion()
        {
            Organizacion = new HashSet<Organizacion>();
        }

        public byte Id { get; set; }
        public string CodigoAlfa { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual ICollection<Organizacion> Organizacion { get; set; }
    }
}
