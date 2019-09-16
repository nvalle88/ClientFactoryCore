using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class EspecialidadCiudad
    {
        public int Id { get; set; }
        public short EspecialidadId { get; set; }
        public short CiudadId { get; set; }
        public int PrestadorId { get; set; }
        public bool? EstadoActivo { get; set; }

        public virtual Ciudad Ciudad { get; set; }
        public virtual EspecialidadMedica Especialidad { get; set; }
        public virtual Prestador Prestador { get; set; }
    }
}
