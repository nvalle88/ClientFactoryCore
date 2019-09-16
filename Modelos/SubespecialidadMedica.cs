using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class SubespecialidadMedica
    {
        public short Id { get; set; }
        public short EspecialidadMedicaId { get; set; }
        public string CodigoAlfa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual EspecialidadMedica EspecialidadMedica { get; set; }
    }
}
