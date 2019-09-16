using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class ContactoGesPacientes
    {
        public long Id { get; set; }
        public string PersonaQueLlamo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public long CasoId { get; set; }

        public virtual Caso Caso { get; set; }
    }
}
