using ClientFactoryCore.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ClientFactoryCore.Data
{
    public partial class SaludsaContext : DbContext
    {
        public SaludsaContext()
        {
        }

        public SaludsaContext(DbContextOptions<SaludsaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdmCatalogo> AdmCatalogo { get; set; }
        public virtual DbSet<AdmItemCatalogo> AdmItemCatalogo { get; set; }
        public virtual DbSet<AtencionHospitalizacion> AtencionHospitalizacion { get; set; }
        public virtual DbSet<AtencionOperador> AtencionOperador { get; set; }
        public virtual DbSet<AtencionTercerizado> AtencionTercerizado { get; set; }
        public virtual DbSet<AutorizacionGesPacientes> AutorizacionGesPacientes { get; set; }
        public virtual DbSet<Beneficiario> Beneficiario { get; set; }
        public virtual DbSet<CalificacionAplicacion> CalificacionAplicacion { get; set; }
        public virtual DbSet<Canales> Canales { get; set; }
        public virtual DbSet<CanalesServicios> CanalesServicios { get; set; }
        public virtual DbSet<Caso> Caso { get; set; }
        public virtual DbSet<CasoSignoSintoma> CasoSignoSintoma { get; set; }
        public virtual DbSet<Catalogo> Catalogo { get; set; }
        public virtual DbSet<CatalogoGeneral> CatalogoGeneral { get; set; }
        public virtual DbSet<Certificado> Certificado { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Cobertura> Cobertura { get; set; }
        public virtual DbSet<ComentarioInSitu> ComentarioInSitu { get; set; }
        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<ConfiguracionCargaEstadoCuenta> ConfiguracionCargaEstadoCuenta { get; set; }
        public virtual DbSet<ConfiguracionPrestadorSrvCita> ConfiguracionPrestadorSrvCita { get; set; }
        public virtual DbSet<ContactoGesPacientes> ContactoGesPacientes { get; set; }
        public virtual DbSet<ContratoGesPacientes> ContratoGesPacientes { get; set; }
        public virtual DbSet<ControlCita> ControlCita { get; set; }
        public virtual DbSet<CorreosPrestador> CorreosPrestador { get; set; }
        public virtual DbSet<Criterio> Criterio { get; set; }
        public virtual DbSet<CriterioValor> CriterioValor { get; set; }
        public virtual DbSet<EmpresaTercerizada> EmpresaTercerizada { get; set; }
        public virtual DbSet<Encuesta> Encuesta { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<Equivalencia> Equivalencia { get; set; }
        public virtual DbSet<EquivalenciaEntidadPersona> EquivalenciaEntidadPersona { get; set; }
        public virtual DbSet<EquivalenciaRolLdap> EquivalenciaRolLdap { get; set; }
        public virtual DbSet<EquivalenciaUsuarioLdap> EquivalenciaUsuarioLdap { get; set; }
        public virtual DbSet<Error> Error { get; set; }
        public virtual DbSet<EspecialidadCiudad> EspecialidadCiudad { get; set; }
        public virtual DbSet<EspecialidadMedica> EspecialidadMedica { get; set; }
        public virtual DbSet<EstadoAtencion> EstadoAtencion { get; set; }
        public virtual DbSet<EstadoCuentaBancaria> EstadoCuentaBancaria { get; set; }
        public virtual DbSet<ExcepcionCita> ExcepcionCita { get; set; }
        public virtual DbSet<Funcionalidad> Funcionalidad { get; set; }
        public virtual DbSet<FuncionarioPrestador> FuncionarioPrestador { get; set; }
        public virtual DbSet<Gap> Gap { get; set; }
        public virtual DbSet<ImagenOrdenAtencion> ImagenOrdenAtencion { get; set; }
        public virtual DbSet<InclusionExclusionDiaria> InclusionExclusionDiaria { get; set; }
        public virtual DbSet<InstruccionEntrega> InstruccionEntrega { get; set; }
        public virtual DbSet<ItemCatalogo> ItemCatalogo { get; set; }
        public virtual DbSet<LotePago> LotePago { get; set; }
        public virtual DbSet<LotePagoDetalle> LotePagoDetalle { get; set; }
        public virtual DbSet<MasivoMovimiento> MasivoMovimiento { get; set; }
        public virtual DbSet<MasivoServicioAdicional> MasivoServicioAdicional { get; set; }
        public virtual DbSet<MensajeError> MensajeError { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Movimiento> Movimiento { get; set; }
        public virtual DbSet<Niveles> Niveles { get; set; }
        public virtual DbSet<NotificacionTerminosCondiciones> NotificacionTerminosCondiciones { get; set; }
        public virtual DbSet<ObservacionCanales> ObservacionCanales { get; set; }
        public virtual DbSet<ObservacionNiveles> ObservacionNiveles { get; set; }
        public virtual DbSet<ObservacionRangos> ObservacionRangos { get; set; }
        public virtual DbSet<ObservacionSalas> ObservacionSalas { get; set; }
        public virtual DbSet<ObservacionSubtipo> ObservacionSubtipo { get; set; }
        public virtual DbSet<ObservacionTipo> ObservacionTipo { get; set; }
        public virtual DbSet<OrdenAtencion> OrdenAtencion { get; set; }
        public virtual DbSet<OrdenCentroMedico> OrdenCentroMedico { get; set; }
        public virtual DbSet<Organizacion> Organizacion { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Parametro> Parametro { get; set; }
        public virtual DbSet<Parametro1> Parametro1 { get; set; }
        public virtual DbSet<ParametroServicioWeb> ParametroServicioWeb { get; set; }
        public virtual DbSet<ParametroServicioWebs> ParametroServicioWebs { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PersonaActualizada> PersonaActualizada { get; set; }
        public virtual DbSet<Poliza> Poliza { get; set; }
        public virtual DbSet<Prestador> Prestador { get; set; }
        public virtual DbSet<PrestadorGesPacientes> PrestadorGesPacientes { get; set; }
        public virtual DbSet<PrestadorUsuario> PrestadorUsuario { get; set; }
        public virtual DbSet<PresupuestoDirector> PresupuestoDirector { get; set; }
        public virtual DbSet<PresupuestoVendedor> PresupuestoVendedor { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Rangos> Rangos { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RestriccionEspecialidad> RestriccionEspecialidad { get; set; }
        public virtual DbSet<Resumen> Resumen { get; set; }
        public virtual DbSet<ResumenDetalle> ResumenDetalle { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<RolFuncionalidad> RolFuncionalidad { get; set; }
        public virtual DbSet<Salas> Salas { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<ServicioBeneficiario> ServicioBeneficiario { get; set; }
        public virtual DbSet<SolicitudCitaMedicoDestacado> SolicitudCitaMedicoDestacado { get; set; }
        public virtual DbSet<SubespecialidadMedica> SubespecialidadMedica { get; set; }
        public virtual DbSet<Subtipos> Subtipos { get; set; }
        public virtual DbSet<Tematica> Tematica { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<TipoEntidad> TipoEntidad { get; set; }
        public virtual DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }
        public virtual DbSet<TipoPrestador> TipoPrestador { get; set; }
        public virtual DbSet<TotalCitaDisponible> TotalCitaDisponible { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioRol> UsuarioRol { get; set; }

        // Unable to generate entity type for table 'dbo.Sector'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CertificadoEjemplo'. Please see the warning messages.
        // Unable to generate entity type for table 'Administracion.ParametroServicioWeb_Prod'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AdmCatalogo>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("Pk_ADM_CATALOGO_Cat_Id");

                entity.ToTable("ADM_CATALOGO");

                entity.HasIndex(e => e.CatCodigo)
                    .HasName("IX_ADM_CATALOGO")
                    .IsUnique();

                entity.Property(e => e.CatId).HasColumnName("Cat_Id");

                entity.Property(e => e.CatCodigo)
                    .IsRequired()
                    .HasColumnName("Cat_Codigo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CatDescripcion)
                    .HasColumnName("Cat_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatEstado)
                    .IsRequired()
                    .HasColumnName("Cat_Estado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CatNombre)
                    .IsRequired()
                    .HasColumnName("Cat_Nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdmItemCatalogo>(entity =>
            {
                entity.HasKey(e => e.ItcId)
                    .HasName("Pk_ADM_ITEM_CATALOGO_Itc_Id");

                entity.ToTable("ADM_ITEM_CATALOGO");

                entity.HasIndex(e => e.ItcCodigo)
                    .HasName("IX_ADM_ITEM_CATALOGO")
                    .IsUnique();

                entity.Property(e => e.ItcId).HasColumnName("Itc_Id");

                entity.Property(e => e.CatId).HasColumnName("Cat_Id");

                entity.Property(e => e.ItcCodigo)
                    .IsRequired()
                    .HasColumnName("Itc_Codigo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItcDescripcion)
                    .HasColumnName("Itc_Descripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItcEstado)
                    .IsRequired()
                    .HasColumnName("Itc_Estado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItcNombre)
                    .IsRequired()
                    .HasColumnName("Itc_Nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItcPadre).HasColumnName("Itc_Padre");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.AdmItemCatalogo)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ADM_CATALOGO_ADM_ITEM_CATALOGO_Cat_Id");
            });

            modelBuilder.Entity<AtencionHospitalizacion>(entity =>
            {
                entity.ToTable("AtencionHospitalizacion", "GestionPacientes");

                entity.Property(e => e.ComentariosVisitaPaciente).HasColumnType("text");

                entity.Property(e => e.FechaAccion).HasColumnType("datetime");

                entity.Property(e => e.FechaPresentacionFacturas).HasColumnType("datetime");

                entity.Property(e => e.MontoCostoEvitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MontoFinalHospitalizacion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombreContactoVisita)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionCostoEvitado).HasColumnType("text");

                entity.Property(e => e.ObservacionNoHacerSeguimiento).HasColumnType("text");

                entity.Property(e => e.ObservacionSospechaAbusoFraude).HasColumnType("text");

                entity.Property(e => e.RequerimientosAlta).HasColumnType("text");

                entity.Property(e => e.TelefonoContactoVisita)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AreaAtencion)
                    .WithMany(p => p.AtencionHospitalizacionAreaAtencion)
                    .HasForeignKey(d => d.AreaAtencionId)
                    .HasConstraintName("FK_AtencionHospitalizacion_AreaAtencion");

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.AtencionHospitalizacion)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionHospitalizacion_Caso");

                entity.HasOne(d => d.ConceptoCostoEvitado)
                    .WithMany(p => p.AtencionHospitalizacionConceptoCostoEvitado)
                    .HasForeignKey(d => d.ConceptoCostoEvitadoId)
                    .HasConstraintName("FK_AtencionHospitalizacion_ConceptoCostoEvitado");

                entity.HasOne(d => d.EstadoVisita)
                    .WithMany(p => p.AtencionHospitalizacionEstadoVisita)
                    .HasForeignKey(d => d.EstadoVisitaId)
                    .HasConstraintName("FK_AtencionHospitalizacion_EstadoVisita");

                entity.HasOne(d => d.EvolucionPaciente)
                    .WithMany(p => p.AtencionHospitalizacionEvolucionPaciente)
                    .HasForeignKey(d => d.EvolucionPacienteId)
                    .HasConstraintName("FK_AtencionHospitalizacion_EvolucionPaciente");

                entity.HasOne(d => d.ProblemasQuejas)
                    .WithMany(p => p.AtencionHospitalizacionProblemasQuejas)
                    .HasForeignKey(d => d.ProblemasQuejasId)
                    .HasConstraintName("FK_AtencionHospitalizacion_ProblemasQuejas");

                entity.HasOne(d => d.Severidad)
                    .WithMany(p => p.AtencionHospitalizacionSeveridad)
                    .HasForeignKey(d => d.SeveridadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionHospitalizacion_Severidad");

                entity.HasOne(d => d.TipoAutorizacion)
                    .WithMany(p => p.AtencionHospitalizacionTipoAutorizacion)
                    .HasForeignKey(d => d.TipoAutorizacionId)
                    .HasConstraintName("FK_AtencionHospitalizacion_TipoAutorizacion");

                entity.HasOne(d => d.TipoTratamiento)
                    .WithMany(p => p.AtencionHospitalizacionTipoTratamiento)
                    .HasForeignKey(d => d.TipoTratamientoId)
                    .HasConstraintName("FK_AtencionHospitalizacion_TipoTratamiento");
            });

            modelBuilder.Entity<AtencionOperador>(entity =>
            {
                entity.ToTable("AtencionOperador", "GestionPacientes");

                entity.Property(e => e.FechaAccion).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.AtencionOperador)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionOperador_Caso");
            });

            modelBuilder.Entity<AtencionTercerizado>(entity =>
            {
                entity.HasKey(e => e.CasoId)
                    .HasName("PK_AtencionTercerizado_Caso");

                entity.ToTable("AtencionTercerizado", "GestionPacientes");

                entity.Property(e => e.CasoId).ValueGeneratedNever();

                entity.Property(e => e.Especialidad).HasColumnType("text");

                entity.Property(e => e.HoraAtencion).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MedicinaSuministrada).HasColumnType("text");

                entity.Property(e => e.NombreTratante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorAmbulancia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithOne(p => p.AtencionTercerizado)
                    .HasForeignKey<AtencionTercerizado>(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionTercerizado_Caso");
            });

            modelBuilder.Entity<AutorizacionGesPacientes>(entity =>
            {
                entity.ToTable("AutorizacionGesPacientes", "GestionPacientes");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.AutorizacionGesPacientes)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Autorizacion_Caso");

                entity.HasOne(d => d.PrestadorCentroMedico)
                    .WithMany(p => p.AutorizacionGesPacientesPrestadorCentroMedico)
                    .HasForeignKey(d => d.PrestadorCentroMedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Autorizacion_PrestadorCentroMedico");

                entity.HasOne(d => d.PrestadorMedico)
                    .WithMany(p => p.AutorizacionGesPacientesPrestadorMedico)
                    .HasForeignKey(d => d.PrestadorMedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Autorizacion_PrestadorMedico");
            });

            modelBuilder.Entity<Beneficiario>(entity =>
            {
                entity.HasIndex(e => e.CategoriaCatalogoId)
                    .HasName("IX_CategoriaCatalogo_Id");

                entity.HasIndex(e => e.RelacionCatalogoId)
                    .HasName("IX_RelacionCatalogo_Id");

                entity.Property(e => e.BeneficiarioFechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.CategoriaCatalogoId).HasColumnName("CategoriaCatalogo_Id");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInclusion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.RelacionCatalogoId).HasColumnName("RelacionCatalogo_Id");

                entity.HasOne(d => d.CategoriaCatalogo)
                    .WithMany(p => p.BeneficiarioCategoriaCatalogo)
                    .HasForeignKey(d => d.CategoriaCatalogoId)
                    .HasConstraintName("FK_dbo.Beneficiario_dbo.CatalogoGeneral_CategoriaCatalogo_Id");

                entity.HasOne(d => d.RelacionCatalogo)
                    .WithMany(p => p.BeneficiarioRelacionCatalogo)
                    .HasForeignKey(d => d.RelacionCatalogoId)
                    .HasConstraintName("FK_dbo.Beneficiario_dbo.CatalogoGeneral_RelacionCatalogo_Id");
            });

            modelBuilder.Entity<CalificacionAplicacion>(entity =>
            {
                entity.ToTable("CalificacionAplicacion", "Calificacion");

                entity.HasIndex(e => new { e.CodigoAplicacion, e.CodigoPlataforma, e.FechaHoraRegistro, e.NumeroDocumento, e.Valor })
                    .HasName("IdxCalificacionAplicacion01")
                    .IsUnique();

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraRegistro).HasColumnType("datetime");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Canales>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(255);
            });

            modelBuilder.Entity<CanalesServicios>(entity =>
            {
                entity.HasKey(e => e.Codigo);
            });

            modelBuilder.Entity<Caso>(entity =>
            {
                entity.ToTable("Caso", "GestionPacientes");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaCierreCaso).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacionCaso).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.UsuarioCierreCaso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacionCaso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccionCliente)
                    .WithMany(p => p.CasoAccionCliente)
                    .HasForeignKey(d => d.AccionClienteId)
                    .HasConstraintName("FK_Caso_AccionCliente");

                entity.HasOne(d => d.AccionFinal)
                    .WithMany(p => p.CasoAccionFinal)
                    .HasForeignKey(d => d.AccionFinalId)
                    .HasConstraintName("FK_Caso_AccionFinal");

                entity.HasOne(d => d.AccionOperador)
                    .WithMany(p => p.CasoAccionOperador)
                    .HasForeignKey(d => d.AccionOperadorId)
                    .HasConstraintName("FK_Caso_AccionOperador");

                entity.HasOne(d => d.Contrato)
                    .WithMany(p => p.Caso)
                    .HasForeignKey(d => d.ContratoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Caso_Contrato");

                entity.HasOne(d => d.EscalaManchester)
                    .WithMany(p => p.CasoEscalaManchester)
                    .HasForeignKey(d => d.EscalaManchesterId)
                    .HasConstraintName("FK_Caso_EscalaManchester");
            });

            modelBuilder.Entity<CasoSignoSintoma>(entity =>
            {
                entity.ToTable("CasoSignoSintoma", "GestionPacientes");

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.CasoSignoSintoma)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CasoSignoSintoma_Caso");

                entity.HasOne(d => d.SignoSintoma)
                    .WithMany(p => p.CasoSignoSintoma)
                    .HasForeignKey(d => d.SignoSintomaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CasoSignoSintoma_SignoSintoma");
            });

            modelBuilder.Entity<Catalogo>(entity =>
            {
                entity.ToTable("Catalogo", "Configuracion");

                entity.HasIndex(e => e.Codigo)
                    .HasName("AK_Codigo_Catalogo")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CatalogoPadre)
                    .WithMany(p => p.InverseCatalogoPadre)
                    .HasForeignKey(d => d.CatalogoPadreId)
                    .HasConstraintName("FK_Catalogo_Catalogo");
            });

            modelBuilder.Entity<CatalogoGeneral>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_Codigo")
                    .IsUnique();

                entity.HasIndex(e => e.PadreId)
                    .HasName("IX_PadreId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Padre)
                    .WithMany(p => p.InversePadre)
                    .HasForeignKey(d => d.PadreId)
                    .HasConstraintName("FK_dbo.CatalogoGeneral_dbo.CatalogoGeneral_PadreId");
            });

            modelBuilder.Entity<Certificado>(entity =>
            {
                entity.ToTable("Certificado", "Certificado");

                entity.Property(e => e.ApellidosTitular)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CoberturaMaxima).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContenidoCertificado)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActivo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.NombresTitular)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoTitular)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumentoTitular)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.ToTable("Ciudad", "Catalogo");

                entity.HasIndex(e => new { e.PaisId, e.RegionId, e.ProvinciaId })
                    .HasName("IdxCiudad01");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ciudad_Pais");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ciudad_Provincia");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ciudad_Region");
            });

            modelBuilder.Entity<Cobertura>(entity =>
            {
                entity.HasIndex(e => e.PolizaId)
                    .HasName("IX_PolizaId");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Poliza)
                    .WithMany(p => p.Cobertura)
                    .HasForeignKey(d => d.PolizaId)
                    .HasConstraintName("FK_dbo.Cobertura_dbo.Poliza_PolizaId");
            });

            modelBuilder.Entity<ComentarioInSitu>(entity =>
            {
                entity.ToTable("ComentarioInSitu", "GestionPacientes");

                entity.Property(e => e.Comentario).HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.ComentarioInSitu)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComentarioInSitu_CasoId");
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_Codigo")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAgrupador)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Valor)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracionCargaEstadoCuenta>(entity =>
            {
                entity.HasKey(e => e.CodigoBanco);

                entity.Property(e => e.CodigoBanco).ValueGeneratedNever();

                entity.Property(e => e.CaracteresAeliminar)
                    .HasColumnName("CaracteresAEliminar")
                    .HasMaxLength(150);

                entity.Property(e => e.FormatoArchivo).HasMaxLength(10);

                entity.Property(e => e.IdentificadorCredito).HasMaxLength(15);

                entity.Property(e => e.SeparadorColumnas).HasMaxLength(5);

                entity.Property(e => e.SeparadorDecimales).HasMaxLength(1);

                entity.Property(e => e.SeparadorMiles).HasMaxLength(1);
            });

            modelBuilder.Entity<ConfiguracionPrestadorSrvCita>(entity =>
            {
                entity.ToTable("ConfiguracionPrestadorSrvCita", "ServiciosMedicos");

                entity.HasIndex(e => e.PrestadorId)
                    .HasName("ConfiguracionPrestadorSrvCita01")
                    .IsUnique();

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EstadoActivo)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urlaut)
                    .IsRequired()
                    .HasColumnName("URLAut")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Urlbase)
                    .IsRequired()
                    .HasColumnName("URLBase")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.Prestador)
                    .WithOne(p => p.ConfiguracionPrestadorSrvCita)
                    .HasForeignKey<ConfiguracionPrestadorSrvCita>(d => d.PrestadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConfiguracionPrestadorSrvCita_Prestador");
            });

            modelBuilder.Entity<ContactoGesPacientes>(entity =>
            {
                entity.HasKey(e => e.CasoId)
                    .HasName("PK_Contacto_Caso");

                entity.ToTable("ContactoGesPacientes", "GestionPacientes");

                entity.Property(e => e.CasoId).ValueGeneratedNever();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PersonaQueLlamo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithOne(p => p.ContactoGesPacientes)
                    .HasForeignKey<ContactoGesPacientes>(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contacto_Caso");
            });

            modelBuilder.Entity<ContratoGesPacientes>(entity =>
            {
                entity.ToTable("ContratoGesPacientes", "GestionPacientes");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlCita>(entity =>
            {
                entity.ToTable("ControlCita", "ServiciosMedicos");

                entity.HasIndex(e => new { e.Id, e.CentroMedicoId, e.CodigoSucursalCentroMedico, e.CodigoMedicoCentroMedico, e.TitularContratoId, e.PacienteId, e.EstadoAtencionId })
                    .HasName("IdxPrestador01");

                entity.Property(e => e.CodigoCitaCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEspecialidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoMedicoCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSucursalCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdHorarioDisponible)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Latitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.NombreMedicoPrestador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePaciente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreSucursalCentroMedico)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegistradoPor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorreosPrestador>(entity =>
            {
                entity.ToTable("CorreosPrestador", "Liquidaciones");

                entity.Property(e => e.CorreoPrestador)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Criterio>(entity =>
            {
                entity.HasIndex(e => e.CatalogoEsTitularId)
                    .HasName("IX_CatalogoEsTitularId");

                entity.HasIndex(e => e.CatalogoGeneroId)
                    .HasName("IX_CatalogoGeneroId");

                entity.HasIndex(e => e.CatalogoProductoId)
                    .HasName("IX_CatalogoProductoId");

                entity.HasIndex(e => e.CatalogoRegionId)
                    .HasName("IX_CatalogoRegionId");

                entity.HasIndex(e => e.CatalogoRelacionId)
                    .HasName("IX_CatalogoRelacionId");

                entity.HasIndex(e => e.PolizaId)
                    .HasName("IX_PolizaId");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.CatalogoEsTitular)
                    .WithMany(p => p.CriterioCatalogoEsTitular)
                    .HasForeignKey(d => d.CatalogoEsTitularId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoEsTitularId");

                entity.HasOne(d => d.CatalogoGenero)
                    .WithMany(p => p.CriterioCatalogoGenero)
                    .HasForeignKey(d => d.CatalogoGeneroId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoGeneroId");

                entity.HasOne(d => d.CatalogoProducto)
                    .WithMany(p => p.CriterioCatalogoProducto)
                    .HasForeignKey(d => d.CatalogoProductoId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoProductoId");

                entity.HasOne(d => d.CatalogoRegion)
                    .WithMany(p => p.CriterioCatalogoRegion)
                    .HasForeignKey(d => d.CatalogoRegionId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoRegionId");

                entity.HasOne(d => d.CatalogoRelacion)
                    .WithMany(p => p.CriterioCatalogoRelacion)
                    .HasForeignKey(d => d.CatalogoRelacionId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoRelacionId");

                entity.HasOne(d => d.Poliza)
                    .WithMany(p => p.Criterio)
                    .HasForeignKey(d => d.PolizaId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.Poliza_PolizaId");
            });

            modelBuilder.Entity<CriterioValor>(entity =>
            {
                entity.HasIndex(e => e.CriterioId)
                    .HasName("IX_CriterioId");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Criterio)
                    .WithMany(p => p.CriterioValor)
                    .HasForeignKey(d => d.CriterioId)
                    .HasConstraintName("FK_dbo.CriterioValor_dbo.Criterio_CriterioId");
            });

            modelBuilder.Entity<EmpresaTercerizada>(entity =>
            {
                entity.ToTable("EmpresaTercerizada", "Seguridad");

                entity.HasIndex(e => e.Codigo)
                    .HasName("AK_EmpresaTercerizada_Codigo")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Encuesta>(entity =>
            {
                entity.HasKey(e => e.CasoId)
                    .HasName("PK_Encuesta_Caso");

                entity.ToTable("Encuesta", "GestionPacientes");

                entity.Property(e => e.CasoId).ValueGeneratedNever();

                entity.Property(e => e.FechaEncuesta).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MotivoCalifEstancia).HasColumnType("text");

                entity.Property(e => e.MotivoCalifHospitalization).HasColumnType("text");

                entity.Property(e => e.MotivoCalificacion).HasColumnType("text");

                entity.HasOne(d => d.Caso)
                    .WithOne(p => p.Encuesta)
                    .HasForeignKey<Encuesta>(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encuesta_Caso");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.ToTable("Entidad", "Entidad");

                entity.HasIndex(e => e.TipoEntidadId)
                    .HasName("IdxEntidad01");

                entity.HasOne(d => d.TipoEntidad)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.TipoEntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Entidad_TipoEntidad");
            });

            modelBuilder.Entity<Equivalencia>(entity =>
            {
                entity.ToTable("Equivalencia", "Homologacion");

                entity.HasIndex(e => new { e.EntidadId, e.TematicaId, e.CodigoExterno })
                    .HasName("IdxEquivalencia01")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntidadId, e.TematicaId, e.CodigoHomologado })
                    .HasName("IdxEquivalencia02");

                entity.Property(e => e.CodigoAlfaHomologado)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoExterno)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoHomologado).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DescripcionExterna)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescripcionHomologada)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.Equivalencia)
                    .HasForeignKey(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equivalencia_Entidad");

                entity.HasOne(d => d.Tematica)
                    .WithMany(p => p.Equivalencia)
                    .HasForeignKey(d => d.TematicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equivalencia_Tematica");
            });

            modelBuilder.Entity<EquivalenciaEntidadPersona>(entity =>
            {
                entity.ToTable("EquivalenciaEntidadPersona", "Homologacion");

                entity.HasIndex(e => new { e.EntidadId, e.CodigoExterno })
                    .HasName("IdxEquivalenciaEntidadPersona01")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntidadId, e.PersonaId })
                    .HasName("IdxEquivalenciaEntidadPersona02")
                    .IsUnique();

                entity.Property(e => e.CodigoExterno)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.EquivalenciaEntidadPersona)
                    .HasForeignKey(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquivalenciaEntidadPersona_Entidad");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.EquivalenciaEntidadPersona)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquivalenciaEntidadPersona_Persona");
            });

            modelBuilder.Entity<EquivalenciaRolLdap>(entity =>
            {
                entity.ToTable("EquivalenciaRolLDAP", "Seguridad");

                entity.HasIndex(e => new { e.RolId, e.NombreGrupoLdap })
                    .HasName("IdxEquivalenciaRolLDAP01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NombreGrupoLdap)
                    .IsRequired()
                    .HasColumnName("NombreGrupoLDAP")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.EquivalenciaRolLdap)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquivalenciaRolLDAP_Rol");
            });

            modelBuilder.Entity<EquivalenciaUsuarioLdap>(entity =>
            {
                entity.ToTable("EquivalenciaUsuarioLDAP", "Seguridad");

                entity.HasIndex(e => new { e.UsuarioId, e.NombreUsuarioLdap })
                    .HasName("IdxEquivalenciaUsuarioLDAP01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NombreUsuarioLdap)
                    .IsRequired()
                    .HasColumnName("NombreUsuarioLDAP")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.EquivalenciaUsuarioLdap)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquivalenciaUsuarioLDAP_Usuario");
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.HasIndex(e => e.ErrorTipo)
                    .HasName("IX_ErrorTipo");

                entity.HasIndex(e => e.ResumenId)
                    .HasName("IX_ResumenId");

                entity.HasIndex(e => e.Tipo)
                    .HasName("IX_Tipo");

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorTipo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Resumen)
                    .WithMany(p => p.Error)
                    .HasForeignKey(d => d.ResumenId)
                    .HasConstraintName("FK_dbo.Error_dbo.Resumen_ResumenId");
            });

            modelBuilder.Entity<EspecialidadCiudad>(entity =>
            {
                entity.ToTable("EspecialidadCiudad", "Catalogo");

                entity.HasIndex(e => new { e.CiudadId, e.EspecialidadId, e.PrestadorId })
                    .HasName("IX_EspecialidadCiudad")
                    .IsUnique();

                entity.Property(e => e.EstadoActivo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.EspecialidadCiudad)
                    .HasForeignKey(d => d.CiudadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadCiudad_Ciudad");

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.EspecialidadCiudad)
                    .HasForeignKey(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadCiudad_Especialidad");

                entity.HasOne(d => d.Prestador)
                    .WithMany(p => p.EspecialidadCiudad)
                    .HasForeignKey(d => d.PrestadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadCiudad_Prestador");
            });

            modelBuilder.Entity<EspecialidadMedica>(entity =>
            {
                entity.ToTable("EspecialidadMedica", "Catalogo");

                entity.HasIndex(e => e.CodigoAlfa)
                    .HasName("IdxEspecialidadMedica01")
                    .IsUnique();

                entity.Property(e => e.CodigoAlfa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoAtencion>(entity =>
            {
                entity.ToTable("EstadoAtencion", "ServiciosMedicos");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoCuentaBancaria>(entity =>
            {
                entity.HasKey(e => new { e.CodigoBanco, e.Fecha, e.Documento, e.Saldo });

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Documento).HasMaxLength(50);

                entity.Property(e => e.Saldo).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Codigo).HasMaxLength(50);

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Monto).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Tipo).HasMaxLength(2);
            });

            modelBuilder.Entity<ExcepcionCita>(entity =>
            {
                entity.ToTable("ExcepcionCita", "ServiciosMedicos");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Funcionalidad>(entity =>
            {
                entity.ToTable("Funcionalidad", "Seguridad");

                entity.HasIndex(e => new { e.ProductoId, e.ModuloId, e.Codigo })
                    .HasName("IdxFuncionalidad01")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProductoId, e.ModuloId, e.RutaBase, e.RutaSecundaria, e.RutaAdicional })
                    .HasName("IdxFuncionalidad02");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RutaAdicional)
                    .HasMaxLength(265)
                    .IsUnicode(false);

                entity.Property(e => e.RutaBase)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RutaSecundaria)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Modulo)
                    .WithMany(p => p.Funcionalidad)
                    .HasForeignKey(d => d.ModuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Funcionalidad_Modulo");
            });

            modelBuilder.Entity<FuncionarioPrestador>(entity =>
            {
                entity.ToTable("FuncionarioPrestador", "GestionPacientes");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gap>(entity =>
            {
                entity.HasIndex(e => e.BeneficiarioCedula)
                    .HasName("IX_BeneficiarioCedula");

                entity.HasIndex(e => e.ResumenId)
                    .HasName("IX_ResumenId");

                entity.HasIndex(e => e.Tipo)
                    .HasName("IX_Tipo");

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Resumen)
                    .WithMany(p => p.GapNavigation)
                    .HasForeignKey(d => d.ResumenId)
                    .HasConstraintName("FK_dbo.Gap_dbo.Resumen_ResumenId");
            });

            modelBuilder.Entity<ImagenOrdenAtencion>(entity =>
            {
                entity.HasKey(e => e.CodigoImagen)
                    .HasName("PK_Table_1_1");

                entity.ToTable("ImagenOrdenAtencion", "Liquidaciones");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoOrdenAtencionNavigation)
                    .WithMany(p => p.ImagenOrdenAtencion)
                    .HasForeignKey(d => d.CodigoOrdenAtencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ImagenOrd__Codig__778AC167");
            });

            modelBuilder.Entity<InclusionExclusionDiaria>(entity =>
            {
                entity.ToTable("InclusionExclusionDiaria", "SincronizacionPrestador");

                entity.HasIndex(e => e.Fecha)
                    .HasName("IdxInclusionExclusionDiaria02");

                entity.HasIndex(e => e.MensajeError)
                    .HasName("IdxInclusionExclusionDiaria03");

                entity.HasIndex(e => new { e.NumeroConvenio, e.NumeroPersona, e.InclusionExclusion, e.Reintento, e.CodigoMovimiento })
                    .HasName("IdxInclusionExclusionDiaria01")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvioPrestador).HasColumnType("datetime");

                entity.Property(e => e.FechaProcesada).HasColumnType("datetime");

                entity.Property(e => e.InclusionExclusion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MensajeError)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<InstruccionEntrega>(entity =>
            {
                entity.ToTable("InstruccionEntrega", "Certificado");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CallePrincipal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CalleSecundaria)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Canton)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionOficina)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionTitularContrato).HasColumnType("text");

                entity.Property(e => e.EntregaPersonalizada)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FuncionarioOficina)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDomicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OficinaEntrega)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionOficina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCertificadoNavigation)
                    .WithMany(p => p.InstruccionEntrega)
                    .HasForeignKey(d => d.IdCertificado)
                    .HasConstraintName("FK_InstruccionEntrega_Certificado");
            });

            modelBuilder.Entity<ItemCatalogo>(entity =>
            {
                entity.ToTable("ItemCatalogo", "Configuracion");

                entity.HasIndex(e => e.Codigo)
                    .HasName("AK_Codigo_ItemCatalogo")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalogo)
                    .WithMany(p => p.ItemCatalogo)
                    .HasForeignKey(d => d.CatalogoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemCatalogo_Catalogo");
            });

            modelBuilder.Entity<LotePago>(entity =>
            {
                entity.ToTable("LotePago", "Liquidaciones");

                entity.HasIndex(e => new { e.Id, e.FechaEmision, e.NumeroConvenioPrestador, e.UsuarioGeneradorId })
                    .HasName("IdxLotePago01");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.HasOne(d => d.UsuarioGenerador)
                    .WithMany(p => p.LotePago)
                    .HasForeignKey(d => d.UsuarioGeneradorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LotePago_UsuarioGenerador");
            });

            modelBuilder.Entity<LotePagoDetalle>(entity =>
            {
                entity.HasKey(e => new { e.LotePagoId, e.ReclamoId });

                entity.ToTable("LotePagoDetalle", "Liquidaciones");

                entity.HasIndex(e => new { e.LotePagoId, e.ReclamoId, e.EstadoPagado })
                    .HasName("IdxLotePagoDetalle01");

                entity.Property(e => e.MontoSaludsa).HasColumnType("money");

                entity.HasOne(d => d.LotePago)
                    .WithMany(p => p.LotePagoDetalle)
                    .HasForeignKey(d => d.LotePagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LotePagoDetalle_LotePago");
            });

            modelBuilder.Entity<MasivoMovimiento>(entity =>
            {
                entity.Property(e => e.CodigoProductoSigmep)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegionSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicioSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MovimientoDatoAnterior)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.MovimientoFecha).HasColumnType("datetime");

                entity.Property(e => e.MovimientoFechaEfecto).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasivoServicioAdicional>(entity =>
            {
                entity.Property(e => e.BeneficiarioApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioFechaDigitacion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaExclusion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaInclusion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioPasaporte)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoGeneroSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProductoSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegionSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicioSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContratoFechaDigitacion).HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaFin).HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaInicio).HasColumnType("datetime");

                entity.Property(e => e.ServicioFechaFin).HasColumnType("datetime");

                entity.Property(e => e.ServicioFechaInicio).HasColumnType("datetime");

                entity.Property(e => e.TitularApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TitularCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitularNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TitularPasaporte)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MensajeError>(entity =>
            {
                entity.ToTable("MensajeError", "Administracion");

                entity.HasIndex(e => e.Codigo)
                    .HasName("UX_MensajeError")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MensajeExterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MensajeInterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.ToTable("Modulo", "Seguridad");

                entity.HasIndex(e => new { e.EntidadRelacionadaId, e.Nombre })
                    .HasName("IdxModulo01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movimiento>(entity =>
            {
                entity.HasIndex(e => e.ResumenId)
                    .HasName("IX_ResumenId");

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProductoSigmep)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegionSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicioSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MovimientoDatoAnterior)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.MovimientoFecha).HasColumnType("datetime");

                entity.Property(e => e.MovimientoFechaEfecto).HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Resumen)
                    .WithMany(p => p.Movimiento)
                    .HasForeignKey(d => d.ResumenId)
                    .HasConstraintName("FK_dbo.Movimiento_dbo.Resumen_ResumenId");
            });

            modelBuilder.Entity<Niveles>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.CodigoNivelesNavigation)
                    .WithMany(p => p.InverseCodigoNivelesNavigation)
                    .HasForeignKey(d => d.CodigoNiveles)
                    .HasConstraintName("FK_Niveles_CodigoNiveles_Niveles_Codigo");
            });

            modelBuilder.Entity<NotificacionTerminosCondiciones>(entity =>
            {
                entity.ToTable("NotificacionTerminosCondiciones", "Administracion");

                entity.Property(e => e.DireccionIp)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.DispositivoNavegador)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaNotificacion).HasColumnType("datetime");

                entity.Property(e => e.SistemaOperativo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ObservacionCanales>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoCanalesNavigation)
                    .WithMany(p => p.ObservacionCanales)
                    .HasForeignKey(d => d.CodigoCanales)
                    .HasConstraintName("FK_ObservacionCanales_CodigoCanales_Canales_Codigo");
            });

            modelBuilder.Entity<ObservacionNiveles>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoNivelesNavigation)
                    .WithMany(p => p.ObservacionNiveles)
                    .HasForeignKey(d => d.CodigoNiveles)
                    .HasConstraintName("FK_ObservacionNiveles_CodigoNiveles_Niveles_Codigo");
            });

            modelBuilder.Entity<ObservacionRangos>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoRangosNavigation)
                    .WithMany(p => p.ObservacionRangos)
                    .HasForeignKey(d => d.CodigoRangos)
                    .HasConstraintName("FK_ObservacionRangos_CodigoRangos_Rangos_Codigo");
            });

            modelBuilder.Entity<ObservacionSalas>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoSalasNavigation)
                    .WithMany(p => p.ObservacionSalas)
                    .HasForeignKey(d => d.CodigoSalas)
                    .HasConstraintName("FK_ObservacionSalas_CodigoSalas_Salas_Codigo");
            });

            modelBuilder.Entity<ObservacionSubtipo>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoSubtipoNavigation)
                    .WithMany(p => p.ObservacionSubtipo)
                    .HasForeignKey(d => d.CodigoSubtipo)
                    .HasConstraintName("FK_ObservacionSubtipo_CodigoSubtipo_Subtipos_Codigo");
            });

            modelBuilder.Entity<ObservacionTipo>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoTipoNavigation)
                    .WithMany(p => p.ObservacionTipo)
                    .HasForeignKey(d => d.CodigoTipo)
                    .HasConstraintName("FK_ObservacionTipo_CodigoTipo_Tipo_Codigo");
            });

            modelBuilder.Entity<OrdenAtencion>(entity =>
            {
                entity.HasKey(e => e.CodigoOrdenAtencion)
                    .HasName("PK_Table_1");

                entity.ToTable("OrdenAtencion", "Liquidaciones");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoCliente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoPrestador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoCie10)
                    .HasColumnName("DiagnosticoCIE10")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCaducidad).HasColumnType("datetime");

                entity.Property(e => e.FechaDecision).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.MedicoTratante)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MedicoTratanteRuc)
                    .HasColumnName("MedicoTratanteRUC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreBeneficiario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombresTitular)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacionBeneficiario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacionTitular)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeCobertura)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorNombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorRuc)
                    .HasColumnName("PrestadorRUC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOrdenAtencion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAprobador)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenCentroMedico>(entity =>
            {
                entity.ToTable("OrdenCentroMedico", "ServiciosMedicos");

                entity.HasIndex(e => new { e.IdCiudad, e.IdPrestador, e.Orden })
                    .HasName("Unique_OrdenCentroMedico")
                    .IsUnique();

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.OrdenCentroMedico)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenCentroMedico_Ciudad");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.OrdenCentroMedico)
                    .HasForeignKey(d => d.IdPrestador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenCentroMedico_Prestador");
            });

            modelBuilder.Entity<Organizacion>(entity =>
            {
                entity.ToTable("Organizacion", "Entidad");

                entity.HasIndex(e => e.EntidadId)
                    .HasName("IdxOrganizacion01")
                    .IsUnique();

                entity.HasIndex(e => e.Nombre)
                    .HasName("IdxOrganizacion03");

                entity.HasIndex(e => new { e.NacionalidadId, e.TipoIdentificacionId, e.Identificacion })
                    .HasName("IdxOrganizacion02")
                    .IsUnique();

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Organizacion)
                    .HasForeignKey<Organizacion>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizacion_Entidad");

                entity.HasOne(d => d.Nacionalidad)
                    .WithMany(p => p.Organizacion)
                    .HasForeignKey(d => d.NacionalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizacion_Nacionalidad");

                entity.HasOne(d => d.TipoIdentificacion)
                    .WithMany(p => p.Organizacion)
                    .HasForeignKey(d => d.TipoIdentificacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizacion_TipoIdentificacion");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.ToTable("Pais", "Catalogo");

                entity.HasIndex(e => e.NombreComunPais)
                    .HasName("IdxPais02");

                entity.HasIndex(e => new { e.CodigoIsoalfa2, e.CodigoIsoalfa3, e.CodigoIsonumerico, e.CodigoTelefonico })
                    .HasName("IdxPais01")
                    .IsUnique();

                entity.Property(e => e.CodigoIsoalfa2)
                    .IsRequired()
                    .HasColumnName("CodigoISOAlfa2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoIsoalfa3)
                    .IsRequired()
                    .HasColumnName("CodigoISOAlfa3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoIsonumerico).HasColumnName("CodigoISONumerico");

                entity.Property(e => e.CodigoTelefonico)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreComunPais)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NombreIdioma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreIsopais)
                    .IsRequired()
                    .HasColumnName("NombreISOPais")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NombreNacionalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.ToTable("Parametro", "Administracion");

                entity.HasIndex(e => new { e.ProductoId, e.Mnemonico })
                    .HasName("IdxParametro01")
                    .IsUnique();

                entity.Property(e => e.CodigoTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mnemonico)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ValorChar)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValorTexto)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parametro1>(entity =>
            {
                entity.ToTable("Parametro", "ContabilizacionCitas");

                entity.HasIndex(e => new { e.CodigoCiudadHomologado, e.NumeroConvenio, e.SucursalCodigoExterno, e.CodigoAlfaEspecialidad, e.EstadoActivo })
                    .HasName("IdxParametro01")
                    .IsUnique();

                entity.Property(e => e.CodigoAlfaEspecialidad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SucursalCodigoExterno)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParametroServicioWeb>(entity =>
            {
                entity.HasKey(e => e.IdParametroServicioWeb);

                entity.ToTable("ParametroServicioWeb", "Administracion");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Servicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParametroServicioWebs>(entity =>
            {
                entity.HasKey(e => e.IdParametroServicioWeb)
                    .HasName("PK_dbo.ParametroServicioWebs");
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.HasIndex(e => e.PolizaId)
                    .HasName("IX_PolizaId");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.PeriodoEstado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Poliza)
                    .WithMany(p => p.Periodo)
                    .HasForeignKey(d => d.PolizaId)
                    .HasConstraintName("FK_dbo.Periodo_dbo.Poliza_PolizaId");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona", "Entidad");

                entity.HasIndex(e => e.EntidadId)
                    .HasName("IdxPersona01")
                    .IsUnique();

                entity.HasIndex(e => new { e.PrimerApellido, e.PrimerNombre })
                    .HasName("IdxPersona03");

                entity.HasIndex(e => new { e.NacionalidadId, e.TipoIdentificacion, e.Identificacion })
                    .HasName("IdxPersona02")
                    .IsUnique();

                entity.Property(e => e.EstadoActivo)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SegundoNombre)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelefonoMovil)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Persona)
                    .HasForeignKey<Persona>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_Entidad");

                entity.HasOne(d => d.Nacionalidad)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.NacionalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_Nacionalidad");
            });

            modelBuilder.Entity<PersonaActualizada>(entity =>
            {
                entity.HasKey(e => e.NumeroPersona);

                entity.ToTable("PersonaActualizada", "Entidad");

                entity.Property(e => e.NumeroPersona).ValueGeneratedNever();

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<Poliza>(entity =>
            {
                entity.HasIndex(e => e.NumeroPoliza)
                    .HasName("IX_NumeroPoliza")
                    .IsUnique();

                entity.HasIndex(e => e.ProveedorId)
                    .HasName("IX_ProveedorId");

                entity.HasIndex(e => e.ServicioCatalogoId)
                    .HasName("IX_ServicioCatalogoId");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroPoliza)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Version).IsRequired();

                entity.Property(e => e.VersionFecha).HasColumnType("datetime");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Poliza)
                    .HasForeignKey(d => d.ProveedorId)
                    .HasConstraintName("FK_dbo.Poliza_dbo.Proveedor_ProveedorId");

                entity.HasOne(d => d.ServicioCatalogo)
                    .WithMany(p => p.Poliza)
                    .HasForeignKey(d => d.ServicioCatalogoId)
                    .HasConstraintName("FK_dbo.Poliza_dbo.Servicio_ServicioCatalogoId");
            });

            modelBuilder.Entity<Prestador>(entity =>
            {
                entity.ToTable("Prestador", "Prestador");

                entity.HasIndex(e => new { e.TipoPrestadorId, e.EntidadId })
                    .HasName("IdxPrestador01")
                    .IsUnique();

                entity.Property(e => e.EstadoActivo)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestador_Entidad");

                entity.HasOne(d => d.TipoPrestador)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.TipoPrestadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestador_TipoPrestador");
            });

            modelBuilder.Entity<PrestadorGesPacientes>(entity =>
            {
                entity.ToTable("PrestadorGesPacientes", "GestionPacientes");
            });

            modelBuilder.Entity<PrestadorUsuario>(entity =>
            {
                entity.ToTable("PrestadorUsuario", "Prestador");

                entity.HasIndex(e => new { e.PrestadorId, e.UsuarioId })
                    .HasName("IdxPrestadorUsuario01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Prestador)
                    .WithMany(p => p.PrestadorUsuario)
                    .HasForeignKey(d => d.PrestadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorUsuario_Prestador");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.PrestadorUsuario)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorUsuario_Usuario");
            });

            modelBuilder.Entity<PresupuestoDirector>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.CodigoProducto).HasMaxLength(255);

                entity.HasOne(d => d.CodigoSalaNavigation)
                    .WithMany(p => p.PresupuestoDirector)
                    .HasForeignKey(d => d.CodigoSala)
                    .HasConstraintName("FK_PresupuestoDirector_CodigoSala_Salas_Codigo");
            });

            modelBuilder.Entity<PresupuestoVendedor>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.HasOne(d => d.CodigoRangoNavigation)
                    .WithMany(p => p.PresupuestoVendedor)
                    .HasForeignKey(d => d.CodigoRango)
                    .HasConstraintName("FK_PresupuestoVendedor_CodigoRango_Rangos_Codigo");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("IX_Nombre")
                    .IsUnique();

                entity.Property(e => e.CorreoElectronicoContacto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaConvenio).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaContacto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.ToTable("Provincia", "Catalogo");

                entity.HasIndex(e => e.PaisId)
                    .HasName("IdxProvincia01");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Provincia_Pais");
            });

            modelBuilder.Entity<Rangos>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.CodigoCanalesNavigation)
                    .WithMany(p => p.Rangos)
                    .HasForeignKey(d => d.CodigoCanales)
                    .HasConstraintName("FK_Rangos_CodigoCanales_Canales_Codigo");

                entity.HasOne(d => d.CodigoSubtipoNavigation)
                    .WithMany(p => p.Rangos)
                    .HasForeignKey(d => d.CodigoSubtipo)
                    .HasConstraintName("FK_Rangos_CodigoSubtipo_Subtipos_Codigo");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region", "Catalogo");

                entity.HasIndex(e => e.PaisId)
                    .HasName("IdxRegion01");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Region_Pais");
            });

            modelBuilder.Entity<RestriccionEspecialidad>(entity =>
            {
                entity.ToTable("RestriccionEspecialidad", "Catalogo");

                entity.HasIndex(e => e.EspecialidadId)
                    .HasName("IX_RestriccionEspecialidad")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Genero).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Especialidad)
                    .WithOne(p => p.RestriccionEspecialidad)
                    .HasForeignKey<RestriccionEspecialidad>(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RestriccionEspecialidad_RestriccionEspecialidad");
            });

            modelBuilder.Entity<Resumen>(entity =>
            {
                entity.HasIndex(e => e.CatalogoEstadoId)
                    .HasName("IX_CatalogoEstadoId");

                entity.HasIndex(e => e.PeriodoId)
                    .HasName("IX_PeriodoId");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaGeneracion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Gap).HasColumnName("GAP");

                entity.HasOne(d => d.CatalogoEstado)
                    .WithMany(p => p.Resumen)
                    .HasForeignKey(d => d.CatalogoEstadoId)
                    .HasConstraintName("FK_dbo.Resumen_dbo.CatalogoGeneral_CatalogoEstadoId");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.Resumen)
                    .HasForeignKey(d => d.PeriodoId)
                    .HasConstraintName("FK_dbo.Resumen_dbo.Periodo_PeriodoId");
            });

            modelBuilder.Entity<ResumenDetalle>(entity =>
            {
                entity.HasIndex(e => e.BeneficiarioCedula)
                    .HasName("IX_BeneficiarioCedula");

                entity.HasIndex(e => e.ContratoId)
                    .HasName("IX_ContratoId");

                entity.HasIndex(e => e.ResumenId)
                    .HasName("IX_ResumenId");

                entity.HasIndex(e => e.TitularCedula)
                    .HasName("IX_TitularCedula");

                entity.Property(e => e.BeneficiarioApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioFechaDigitacion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaExclusion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaInclusion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCategoriaSigmep)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProductoSigmep)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegionSigmep)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicioSigmep)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContratoFechaDigitacion).HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaFin).HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ServicioFechaFin).HasColumnType("datetime");

                entity.Property(e => e.ServicioFechaInicio).HasColumnType("datetime");

                entity.Property(e => e.TitularApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TitularCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TitularNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Resumen)
                    .WithMany(p => p.ResumenDetalle)
                    .HasForeignKey(d => d.ResumenId)
                    .HasConstraintName("FK_dbo.ResumenDetalle_dbo.Resumen_ResumenId");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol", "Seguridad");

                entity.HasIndex(e => new { e.ProductoId, e.EstadoActivo })
                    .HasName("IdxRol02");

                entity.HasIndex(e => new { e.ProductoId, e.Nombre })
                    .HasName("IdxRol01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolFuncionalidad>(entity =>
            {
                entity.ToTable("RolFuncionalidad", "Seguridad");

                entity.HasIndex(e => new { e.RolId, e.FuncionalidadId })
                    .HasName("IdxRolFuncionalidad01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Funcionalidad)
                    .WithMany(p => p.RolFuncionalidad)
                    .HasForeignKey(d => d.FuncionalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolFuncionalidad_Funcionalidad");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolFuncionalidad)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolFuncionalidad_Rol");
            });

            modelBuilder.Entity<Salas>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Abreviacion).HasMaxLength(255);

                entity.Property(e => e.CodigoProducto).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.CodigoCanalesNavigation)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.CodigoCanales)
                    .HasConstraintName("FK_Salas_CodigoCanales_Canales_Codigo");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServicioBeneficiario>(entity =>
            {
                entity.HasIndex(e => e.BeneficiarioServicioId)
                    .HasName("IX_BeneficiarioServicioId");

                entity.HasIndex(e => e.ServicioAdicionalId)
                    .HasName("IX_ServicioAdicionalId");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.BeneficiarioServicio)
                    .WithMany(p => p.ServicioBeneficiario)
                    .HasForeignKey(d => d.BeneficiarioServicioId)
                    .HasConstraintName("FK_dbo.ServicioBeneficiario_dbo.Beneficiario_BeneficiarioServicioId");

                entity.HasOne(d => d.ServicioAdicional)
                    .WithMany(p => p.ServicioBeneficiario)
                    .HasForeignKey(d => d.ServicioAdicionalId)
                    .HasConstraintName("FK_dbo.ServicioBeneficiario_dbo.Servicio_ServicioAdicionalId");
            });

            modelBuilder.Entity<SolicitudCitaMedicoDestacado>(entity =>
            {
                entity.ToTable("SolicitudCitaMedicoDestacado", "ServiciosMedicos");

                entity.Property(e => e.CodigoEspecialidad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoPlataforma).HasDefaultValueSql("((3))");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSolicitud).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.MotivoRechazo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RegistradoPor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubespecialidadMedica>(entity =>
            {
                entity.ToTable("SubespecialidadMedica", "Catalogo");

                entity.HasIndex(e => e.CodigoAlfa)
                    .HasName("IdxSubespecialidadMedica02")
                    .IsUnique();

                entity.HasIndex(e => new { e.EspecialidadMedicaId, e.CodigoAlfa })
                    .HasName("IdxSubespecialidadMedica01")
                    .IsUnique();

                entity.Property(e => e.CodigoAlfa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspecialidadMedica)
                    .WithMany(p => p.SubespecialidadMedica)
                    .HasForeignKey(d => d.EspecialidadMedicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubespecialidadMedica_EspecialidadMedica");
            });

            modelBuilder.Entity<Subtipos>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Tematica>(entity =>
            {
                entity.ToTable("Tematica", "Homologacion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(127)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.CodigoNivelNavigation)
                    .WithMany(p => p.Tipo)
                    .HasForeignKey(d => d.CodigoNivel)
                    .HasConstraintName("FK_Tipo_CodigoNivel_Niveles_Codigo");
            });

            modelBuilder.Entity<TipoEntidad>(entity =>
            {
                entity.ToTable("TipoEntidad", "Entidad");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("IdxTipoEntidad01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoIdentificacion>(entity =>
            {
                entity.ToTable("TipoIdentificacion", "Entidad");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("IdxTipoIdentificacion01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CodigoAlfa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPrestador>(entity =>
            {
                entity.ToTable("TipoPrestador", "Prestador");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("IdxTipoPrestador01")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TotalCitaDisponible>(entity =>
            {
                entity.ToTable("TotalCitaDisponible", "ContabilizacionCitas");

                entity.Property(e => e.FechaDisponibilidad).HasColumnType("datetime");

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.HasOne(d => d.Parametro)
                    .WithMany(p => p.TotalCitaDisponible)
                    .HasForeignKey(d => d.ParametroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TotalCitaDisponible_Parametro");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario", "Seguridad");

                entity.HasIndex(e => new { e.EntidadRelacionadaId, e.NombreUsuario })
                    .HasName("IdxUsuario01")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntidadRelacionadaId, e.NombreUsuario, e.EstadoActivo, e.Bloqueado, e.FinBloqueo })
                    .HasName("IdxUsuario02");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EntidadRelacionada)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.EntidadRelacionadaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_EntidadRelacionada");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Persona");
            });

            modelBuilder.Entity<UsuarioRol>(entity =>
            {
                entity.ToTable("UsuarioRol", "Seguridad");

                entity.HasIndex(e => new { e.UsuarioId, e.RolId })
                    .HasName("IdxUsuarioRol01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.UsuarioRol)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioRol_Rol");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioRol)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioRol_Usuario");
            });
        }
    }
}
