using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class AtencionOperador
    {
        public long Id { get; set; }
        public long CasoId { get; set; }
        public DateTime FechaAccion { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public bool NoHacerSeguimiento { get; set; }
        public bool CancelarServicio { get; set; }
        public bool CerrarCaso { get; set; }

        public virtual Caso Caso { get; set; }
    }
}
