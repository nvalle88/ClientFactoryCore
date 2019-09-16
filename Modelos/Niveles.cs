using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Niveles
    {
        public Niveles()
        {
            InverseCodigoNivelesNavigation = new HashSet<Niveles>();
            ObservacionNiveles = new HashSet<ObservacionNiveles>();
            Tipo = new HashSet<Tipo>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public int? CodigoNiveles { get; set; }

        public virtual Niveles CodigoNivelesNavigation { get; set; }
        public virtual ICollection<Niveles> InverseCodigoNivelesNavigation { get; set; }
        public virtual ICollection<ObservacionNiveles> ObservacionNiveles { get; set; }
        public virtual ICollection<Tipo> Tipo { get; set; }
    }
}
