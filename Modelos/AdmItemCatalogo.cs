using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class AdmItemCatalogo
    {
        public int ItcId { get; set; }
        public string ItcNombre { get; set; }
        public string ItcCodigo { get; set; }
        public string ItcDescripcion { get; set; }
        public string ItcEstado { get; set; }
        public int? ItcPadre { get; set; }
        public int CatId { get; set; }

        public virtual AdmCatalogo Cat { get; set; }
    }
}
