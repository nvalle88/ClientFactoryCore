﻿using System;
using System.Collections.Generic;

namespace ClientFactoryCore.Modelos
{
    public partial class OrdenAtencion
    {
        public OrdenAtencion()
        {
            ImagenOrdenAtencion = new HashSet<ImagenOrdenAtencion>();
        }

        public int CodigoOrdenAtencion { get; set; }
        public int? NumeroPersonaBeneficiario { get; set; }
        public string NombreBeneficiario { get; set; }
        public int? CodigoContrato { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string TipoOrdenAtencion { get; set; }
        public string Region { get; set; }
        public string Ciudad { get; set; }
        public string MedicoTratante { get; set; }
        public string Diagnostico { get; set; }
        public string DiagnosticoCie10 { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Observacion { get; set; }
        public string NumeroIdentificacionTitular { get; set; }
        public string NombresTitular { get; set; }
        public string NumeroIdentificacionBeneficiario { get; set; }
        public int? NumeroContrato { get; set; }
        public string MedicoTratanteRuc { get; set; }
        public string PrestadorNombre { get; set; }
        public string PrestadorRuc { get; set; }
        public string CorreoPrestador { get; set; }
        public string PorcentajeCobertura { get; set; }
        public string CorreoCliente { get; set; }
        public int? CodigoAplicacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        public DateTime? FechaDecision { get; set; }
        public int? CodigoEstado { get; set; }
        public int? CodigoMotivoRechazo { get; set; }
        public string UsuarioAprobador { get; set; }
        public int? IdPrestador { get; set; }

        public virtual ICollection<ImagenOrdenAtencion> ImagenOrdenAtencion { get; set; }
    }
}
