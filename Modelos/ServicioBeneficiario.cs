using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class ServicioBeneficiario
    {
        public int Id { get; set; }
        public int BeneficiarioServicioId { get; set; }
        public int ServicioAdicionalId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public virtual Beneficiario BeneficiarioServicio { get; set; }
        public virtual Servicio ServicioAdicional { get; set; }
    }
}
