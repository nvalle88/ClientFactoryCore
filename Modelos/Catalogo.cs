using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class Catalogo
    {
        public Catalogo()
        {
            InverseCatalogoPadre = new HashSet<Catalogo>();
            ItemCatalogo = new HashSet<ItemCatalogo>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }
        public int? CatalogoPadreId { get; set; }

        public virtual Catalogo CatalogoPadre { get; set; }
        public virtual ICollection<Catalogo> InverseCatalogoPadre { get; set; }
        public virtual ICollection<ItemCatalogo> ItemCatalogo { get; set; }
    }
}
