using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class PresupuestoVendedor
    {
        public int Codigo { get; set; }
        public int? Desde { get; set; }
        public int? Hasta { get; set; }
        public bool? Comodin { get; set; }
        public bool? Estado { get; set; }
        public int? CodigoRango { get; set; }
        public int? Porcentaje { get; set; }
        public int? TipoPresupuesto { get; set; }

        public virtual Rangos CodigoRangoNavigation { get; set; }
    }
}
