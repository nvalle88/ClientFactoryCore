using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class CatalogoGeneral
    {
        public CatalogoGeneral()
        {
            BeneficiarioCategoriaCatalogo = new HashSet<Beneficiario>();
            BeneficiarioRelacionCatalogo = new HashSet<Beneficiario>();
            CriterioCatalogoEsTitular = new HashSet<Criterio>();
            CriterioCatalogoGenero = new HashSet<Criterio>();
            CriterioCatalogoProducto = new HashSet<Criterio>();
            CriterioCatalogoRegion = new HashSet<Criterio>();
            CriterioCatalogoRelacion = new HashSet<Criterio>();
            InversePadre = new HashSet<CatalogoGeneral>();
            Resumen = new HashSet<Resumen>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string CodigoSigmep { get; set; }
        public int? PadreId { get; set; }

        public virtual CatalogoGeneral Padre { get; set; }
        public virtual ICollection<Beneficiario> BeneficiarioCategoriaCatalogo { get; set; }
        public virtual ICollection<Beneficiario> BeneficiarioRelacionCatalogo { get; set; }
        public virtual ICollection<Criterio> CriterioCatalogoEsTitular { get; set; }
        public virtual ICollection<Criterio> CriterioCatalogoGenero { get; set; }
        public virtual ICollection<Criterio> CriterioCatalogoProducto { get; set; }
        public virtual ICollection<Criterio> CriterioCatalogoRegion { get; set; }
        public virtual ICollection<Criterio> CriterioCatalogoRelacion { get; set; }
        public virtual ICollection<CatalogoGeneral> InversePadre { get; set; }
        public virtual ICollection<Resumen> Resumen { get; set; }
    }
}
