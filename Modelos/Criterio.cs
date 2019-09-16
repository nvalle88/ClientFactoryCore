using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Criterio
    {
        public Criterio()
        {
            CriterioValor = new HashSet<CriterioValor>();
        }

        public int Id { get; set; }
        public int? EdadMin { get; set; }
        public int? EdadMax { get; set; }
        public double? CoberturaMin { get; set; }
        public double? CoberturaMax { get; set; }
        public int? CatalogoRegionId { get; set; }
        public int? CatalogoProductoId { get; set; }
        public int? CatalogoRelacionId { get; set; }
        public int? CatalogoGeneroId { get; set; }
        public int? CatalogoEsTitularId { get; set; }
        public bool TarifaPorContrato { get; set; }
        public int PolizaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public virtual CatalogoGeneral CatalogoEsTitular { get; set; }
        public virtual CatalogoGeneral CatalogoGenero { get; set; }
        public virtual CatalogoGeneral CatalogoProducto { get; set; }
        public virtual CatalogoGeneral CatalogoRegion { get; set; }
        public virtual CatalogoGeneral CatalogoRelacion { get; set; }
        public virtual Poliza Poliza { get; set; }
        public virtual ICollection<CriterioValor> CriterioValor { get; set; }
    }
}
