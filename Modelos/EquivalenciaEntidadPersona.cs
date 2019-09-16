using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class EquivalenciaEntidadPersona
    {
        public long Id { get; set; }
        public long EntidadId { get; set; }
        public string CodigoExterno { get; set; }
        public long PersonaId { get; set; }
        public bool Verificar { get; set; }

        public virtual Entidad Entidad { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
