using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class OrdenCentroMedico
    {
        public int Id { get; set; }
        public short IdCiudad { get; set; }
        public int IdPrestador { get; set; }
        public short Orden { get; set; }

        public virtual Ciudad IdCiudadNavigation { get; set; }
        public virtual Prestador IdPrestadorNavigation { get; set; }
    }
}
