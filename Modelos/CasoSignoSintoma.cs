using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class CasoSignoSintoma
    {
        public long Id { get; set; }
        public long CasoId { get; set; }
        public int SignoSintomaId { get; set; }

        public virtual Caso Caso { get; set; }
        public virtual ItemCatalogo SignoSintoma { get; set; }
    }
}
