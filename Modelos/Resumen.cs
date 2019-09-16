using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Resumen
    {
        public Resumen()
        {
            Error = new HashSet<Error>();
            GapNavigation = new HashSet<Gap>();
            Movimiento = new HashSet<Movimiento>();
            ResumenDetalle = new HashSet<ResumenDetalle>();
        }

        public int Id { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public int CatalogoEstadoId { get; set; }
        public int? Cantidad { get; set; }
        public float? Tarifado { get; set; }
        public int? Movimientos { get; set; }
        public int? Gap { get; set; }
        public int? Errores { get; set; }
        public int PeriodoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public virtual CatalogoGeneral CatalogoEstado { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual ICollection<Error> Error { get; set; }
        public virtual ICollection<Gap> GapNavigation { get; set; }
        public virtual ICollection<Movimiento> Movimiento { get; set; }
        public virtual ICollection<ResumenDetalle> ResumenDetalle { get; set; }
    }
}
