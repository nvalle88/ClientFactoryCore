using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class PrestadorGesPacientes
    {
        public PrestadorGesPacientes()
        {
            AutorizacionGesPacientesPrestadorCentroMedico = new HashSet<AutorizacionGesPacientes>();
            AutorizacionGesPacientesPrestadorMedico = new HashSet<AutorizacionGesPacientes>();
        }

        public long Id { get; set; }
        public int NumeroConvenio { get; set; }

        public virtual ICollection<AutorizacionGesPacientes> AutorizacionGesPacientesPrestadorCentroMedico { get; set; }
        public virtual ICollection<AutorizacionGesPacientes> AutorizacionGesPacientesPrestadorMedico { get; set; }
    }
}
