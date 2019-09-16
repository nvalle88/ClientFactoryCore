using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class EspecialidadMedica
    {
        public EspecialidadMedica()
        {
            EspecialidadCiudad = new HashSet<EspecialidadCiudad>();
            SubespecialidadMedica = new HashSet<SubespecialidadMedica>();
        }

        public short Id { get; set; }
        public string CodigoAlfa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual RestriccionEspecialidad RestriccionEspecialidad { get; set; }
        public virtual ICollection<EspecialidadCiudad> EspecialidadCiudad { get; set; }
        public virtual ICollection<SubespecialidadMedica> SubespecialidadMedica { get; set; }
    }
}
