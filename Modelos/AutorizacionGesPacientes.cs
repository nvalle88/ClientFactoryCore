using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class AutorizacionGesPacientes
    {
        public long Id { get; set; }
        public long CasoId { get; set; }
        public int NumeroAutorizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long PrestadorCentroMedicoId { get; set; }
        public long PrestadorMedicoId { get; set; }
        public string Usuario { get; set; }

        public virtual Caso Caso { get; set; }
        public virtual PrestadorGesPacientes PrestadorCentroMedico { get; set; }
        public virtual PrestadorGesPacientes PrestadorMedico { get; set; }
    }
}
