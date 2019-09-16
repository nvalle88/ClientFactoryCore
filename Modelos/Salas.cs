using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Salas
    {
        public Salas()
        {
            ObservacionSalas = new HashSet<ObservacionSalas>();
            PresupuestoDirector = new HashSet<PresupuestoDirector>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int? CodigoSucursal { get; set; }
        public string Abreviacion { get; set; }
        public bool Estado { get; set; }
        public int? CodigoCanales { get; set; }
        public string CodigoProducto { get; set; }

        public virtual Canales CodigoCanalesNavigation { get; set; }
        public virtual ICollection<ObservacionSalas> ObservacionSalas { get; set; }
        public virtual ICollection<PresupuestoDirector> PresupuestoDirector { get; set; }
    }
}
