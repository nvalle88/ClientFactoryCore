using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class LotePago
    {
        public LotePago()
        {
            LotePagoDetalle = new HashSet<LotePagoDetalle>();
        }

        public int Id { get; set; }
        public DateTime FechaEmision { get; set; }
        public int NumeroConvenioPrestador { get; set; }
        public Guid UsuarioGeneradorId { get; set; }

        public virtual Usuario UsuarioGenerador { get; set; }
        public virtual ICollection<LotePagoDetalle> LotePagoDetalle { get; set; }
    }
}
