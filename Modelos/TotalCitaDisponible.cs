using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class TotalCitaDisponible
    {
        public int Id { get; set; }
        public int ParametroId { get; set; }
        public int TotalDisponible { get; set; }
        public DateTime FechaDisponibilidad { get; set; }
        public DateTime FechaProceso { get; set; }

        public virtual Parametro1 Parametro { get; set; }
    }
}
