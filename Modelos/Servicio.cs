using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Servicio
    {
        public Servicio()
        {
            Poliza = new HashSet<Poliza>();
            ServicioBeneficiario = new HashSet<ServicioBeneficiario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int CodigoSigmep { get; set; }

        public virtual ICollection<Poliza> Poliza { get; set; }
        public virtual ICollection<ServicioBeneficiario> ServicioBeneficiario { get; set; }
    }
}
