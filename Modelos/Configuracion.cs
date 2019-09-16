using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Configuracion
    {
        public int Id { get; set; }
        public string CodigoAgrupador { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }
    }
}
