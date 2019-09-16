using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Entidad
    {
        public Entidad()
        {
            Equivalencia = new HashSet<Equivalencia>();
            EquivalenciaEntidadPersona = new HashSet<EquivalenciaEntidadPersona>();
            Prestador = new HashSet<Prestador>();
            Usuario = new HashSet<Usuario>();
        }

        public long Id { get; set; }
        public byte TipoEntidadId { get; set; }

        public virtual TipoEntidad TipoEntidad { get; set; }
        public virtual Organizacion Organizacion { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Equivalencia> Equivalencia { get; set; }
        public virtual ICollection<EquivalenciaEntidadPersona> EquivalenciaEntidadPersona { get; set; }
        public virtual ICollection<Prestador> Prestador { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
