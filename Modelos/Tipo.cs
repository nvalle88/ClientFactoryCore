using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Tipo
    {
        public Tipo()
        {
            ObservacionTipo = new HashSet<ObservacionTipo>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool EstadoTipo { get; set; }
        public int? CodigoNivel { get; set; }

        public virtual Niveles CodigoNivelNavigation { get; set; }
        public virtual ICollection<ObservacionTipo> ObservacionTipo { get; set; }
    }
}
