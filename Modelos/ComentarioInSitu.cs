using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class ComentarioInSitu
    {
        public long Id { get; set; }
        public string Usuario { get; set; }
        public long CasoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

        public virtual Caso Caso { get; set; }
    }
}
