using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Parametro1
    {
        public Parametro1()
        {
            TotalCitaDisponible = new HashSet<TotalCitaDisponible>();
        }

        public int Id { get; set; }
        public int CodigoCiudadHomologado { get; set; }
        public long NumeroConvenio { get; set; }
        public string SucursalCodigoExterno { get; set; }
        public string CodigoAlfaEspecialidad { get; set; }
        public byte Edad { get; set; }
        public string Genero { get; set; }
        public bool EstadoActivo { get; set; }

        public virtual ICollection<TotalCitaDisponible> TotalCitaDisponible { get; set; }
    }
}
