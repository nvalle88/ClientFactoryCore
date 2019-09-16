using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Prestador
    {
        public Prestador()
        {
            EspecialidadCiudad = new HashSet<EspecialidadCiudad>();
            OrdenCentroMedico = new HashSet<OrdenCentroMedico>();
            PrestadorUsuario = new HashSet<PrestadorUsuario>();
        }

        public int Id { get; set; }
        public short TipoPrestadorId { get; set; }
        public long EntidadId { get; set; }
        public int NumeroConvenio { get; set; }
        public bool? EstadoActivo { get; set; }

        public virtual Entidad Entidad { get; set; }
        public virtual TipoPrestador TipoPrestador { get; set; }
        public virtual ConfiguracionPrestadorSrvCita ConfiguracionPrestadorSrvCita { get; set; }
        public virtual ICollection<EspecialidadCiudad> EspecialidadCiudad { get; set; }
        public virtual ICollection<OrdenCentroMedico> OrdenCentroMedico { get; set; }
        public virtual ICollection<PrestadorUsuario> PrestadorUsuario { get; set; }
    }
}
