using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Organizacion
    {
        public long Id { get; set; }
        public long EntidadId { get; set; }
        public short NacionalidadId { get; set; }
        public byte TipoIdentificacionId { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }

        public virtual Entidad Entidad { get; set; }
        public virtual Pais Nacionalidad { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
    }
}
