using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class ImagenOrdenAtencion
    {
        public int CodigoImagen { get; set; }
        public int CodigoOrdenAtencion { get; set; }
        public string Url { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual OrdenAtencion CodigoOrdenAtencionNavigation { get; set; }
    }
}
