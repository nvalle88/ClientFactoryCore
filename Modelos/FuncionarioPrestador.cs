﻿using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class FuncionarioPrestador
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public int NumeroConvenio { get; set; }
        public bool EstadoActivo { get; set; }
    }
}
