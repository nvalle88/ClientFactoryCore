using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class ExcepcionCita
    {
        public long Id { get; set; }
        public long IdCitaOrigen { get; set; }
        public long IdNuevaCita { get; set; }
        public int CodigoExcepcion { get; set; }
        public int MotivoExcepcion { get; set; }
    }
}
