using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Canales
    {
        public Canales()
        {
            ObservacionCanales = new HashSet<ObservacionCanales>();
            Rangos = new HashSet<Rangos>();
            Salas = new HashSet<Salas>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<ObservacionCanales> ObservacionCanales { get; set; }
        public virtual ICollection<Rangos> Rangos { get; set; }
        public virtual ICollection<Salas> Salas { get; set; }
    }
}
