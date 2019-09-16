using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class ItemCatalogo
    {
        public ItemCatalogo()
        {
            AtencionHospitalizacionAreaAtencion = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionConceptoCostoEvitado = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionEstadoVisita = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionEvolucionPaciente = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionProblemasQuejas = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionSeveridad = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionTipoAutorizacion = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionTipoTratamiento = new HashSet<AtencionHospitalizacion>();
            CasoAccionCliente = new HashSet<Caso>();
            CasoAccionFinal = new HashSet<Caso>();
            CasoAccionOperador = new HashSet<Caso>();
            CasoEscalaManchester = new HashSet<Caso>();
            CasoSignoSintoma = new HashSet<CasoSignoSintoma>();
        }

        public int Id { get; set; }
        public int CatalogoId { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public bool? EstadoActivo { get; set; }

        public virtual Catalogo Catalogo { get; set; }
        public virtual ICollection<AtencionHospitalizacion> AtencionHospitalizacionAreaAtencion { get; set; }
        public virtual ICollection<AtencionHospitalizacion> AtencionHospitalizacionConceptoCostoEvitado { get; set; }
        public virtual ICollection<AtencionHospitalizacion> AtencionHospitalizacionEstadoVisita { get; set; }
        public virtual ICollection<AtencionHospitalizacion> AtencionHospitalizacionEvolucionPaciente { get; set; }
        public virtual ICollection<AtencionHospitalizacion> AtencionHospitalizacionProblemasQuejas { get; set; }
        public virtual ICollection<AtencionHospitalizacion> AtencionHospitalizacionSeveridad { get; set; }
        public virtual ICollection<AtencionHospitalizacion> AtencionHospitalizacionTipoAutorizacion { get; set; }
        public virtual ICollection<AtencionHospitalizacion> AtencionHospitalizacionTipoTratamiento { get; set; }
        public virtual ICollection<Caso> CasoAccionCliente { get; set; }
        public virtual ICollection<Caso> CasoAccionFinal { get; set; }
        public virtual ICollection<Caso> CasoAccionOperador { get; set; }
        public virtual ICollection<Caso> CasoEscalaManchester { get; set; }
        public virtual ICollection<CasoSignoSintoma> CasoSignoSintoma { get; set; }
    }
}
