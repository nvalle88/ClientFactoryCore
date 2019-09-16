using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            EspecialidadCiudad = new HashSet<EspecialidadCiudad>();
            OrdenCentroMedico = new HashSet<OrdenCentroMedico>();
        }

        public short Id { get; set; }
        public string Nombre { get; set; }
        public short PaisId { get; set; }
        public short RegionId { get; set; }
        public short ProvinciaId { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<EspecialidadCiudad> EspecialidadCiudad { get; set; }
        public virtual ICollection<OrdenCentroMedico> OrdenCentroMedico { get; set; }
    }
}
