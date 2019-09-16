using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class AtencionHospitalizacion
    {
        public long Id { get; set; }
        public long CasoId { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAccion { get; set; }
        public int? TipoAutorizacionId { get; set; }
        public int? TipoTratamientoId { get; set; }
        public int? AreaAtencionId { get; set; }
        public int SeveridadId { get; set; }
        public bool NoHacerSeguimiento { get; set; }
        public string ObservacionNoHacerSeguimiento { get; set; }
        public bool SospechaAbusoFraude { get; set; }
        public string ObservacionSospechaAbusoFraude { get; set; }
        public int? EvolucionPacienteId { get; set; }
        public int? EstadoVisitaId { get; set; }
        public int? ProblemasQuejasId { get; set; }
        public string ComentariosVisitaPaciente { get; set; }
        public string NombreContactoVisita { get; set; }
        public string TelefonoContactoVisita { get; set; }
        public decimal? MontoCostoEvitado { get; set; }
        public int? ConceptoCostoEvitadoId { get; set; }
        public string ObservacionCostoEvitado { get; set; }
        public bool QuitarCobertura { get; set; }
        public decimal? MontoFinalHospitalizacion { get; set; }
        public string RequerimientosAlta { get; set; }
        public DateTime? FechaPresentacionFacturas { get; set; }

        public virtual ItemCatalogo AreaAtencion { get; set; }
        public virtual Caso Caso { get; set; }
        public virtual ItemCatalogo ConceptoCostoEvitado { get; set; }
        public virtual ItemCatalogo EstadoVisita { get; set; }
        public virtual ItemCatalogo EvolucionPaciente { get; set; }
        public virtual ItemCatalogo ProblemasQuejas { get; set; }
        public virtual ItemCatalogo Severidad { get; set; }
        public virtual ItemCatalogo TipoAutorizacion { get; set; }
        public virtual ItemCatalogo TipoTratamiento { get; set; }
    }
}
