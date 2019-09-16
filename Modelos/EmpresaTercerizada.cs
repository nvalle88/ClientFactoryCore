using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class EmpresaTercerizada
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }
    }
}
