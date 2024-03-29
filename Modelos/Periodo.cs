﻿using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Periodo
    {
        public Periodo()
        {
            Resumen = new HashSet<Resumen>();
        }

        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string PeriodoEstado { get; set; }
        public int PolizaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public virtual Poliza Poliza { get; set; }
        public virtual ICollection<Resumen> Resumen { get; set; }
    }
}
