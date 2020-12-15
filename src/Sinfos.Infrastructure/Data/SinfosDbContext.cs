using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sinfos.Infrastructure;

namespace Sinfos.Infrastructure.Data
{
    public partial class SinfosDbContext : DbContext
    {
        public SinfosDbContext()
        {
        }

        public SinfosDbContext(DbContextOptions<SinfosDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Aseguradoras> Aseguradoras { get; set; }
        public virtual DbSet<Cie10> Cie10 { get; set; }
        public virtual DbSet<CompleNotificacion> CompleNotificacion { get; set; }
        public virtual DbSet<DatosCuidador> DatosCuidador { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Desnutricion> Desnutricion { get; set; }
        public virtual DbSet<Desnutricion2> Desnutricion2 { get; set; }
        public virtual DbSet<DesnutricionFactores> DesnutricionFactores { get; set; }
        public virtual DbSet<DesnutricionFactoresVisita> DesnutricionFactoresVisita { get; set; }
        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<FailedJobs> FailedJobs { get; set; }
        public virtual DbSet<GruposEtnicos> GruposEtnicos { get; set; }
        public virtual DbSet<HabitosAlimentarios> HabitosAlimentarios { get; set; }
        public virtual DbSet<IceDesnutricion> IceDesnutricion { get; set; }
        public virtual DbSet<IdentPacienteNotificacion> IdentPacienteNotificacion { get; set; }
        public virtual DbSet<IdentPacienteNotificacion2> IdentPacienteNotificacion2 { get; set; }
        public virtual DbSet<InfoUpgdCaracterizacion> InfoUpgdCaracterizacion { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<NotificaIaasCaracterizacion> NotificaIaasCaracterizacion { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<PasswordResets> PasswordResets { get; set; }
        public virtual DbSet<RecursosDispoCaracterizacion> RecursosDispoCaracterizacion { get; set; }
        public virtual DbSet<ServiciosUpgdCaracterizacion> ServiciosUpgdCaracterizacion { get; set; }
        public virtual DbSet<TalhumUpgdCaracterizacion> TalhumUpgdCaracterizacion { get; set; }
        public virtual DbSet<TipoId> TipoId { get; set; }
        public virtual DbSet<TipoRegSalud> TipoRegSalud { get; set; }
        public virtual DbSet<TipoUciCaracterizacion> TipoUciCaracterizacion { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Veredas> Veredas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=sinfosv1;server=localhost;port=3306;user id=root;password= ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agenda>(entity =>
            {
                entity.ToTable("agenda");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccionMejora)
                    .HasColumnName("accion_mejora")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Hallazgo)
                    .HasColumnName("hallazgo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HoraFin)
                    .IsRequired()
                    .HasColumnName("hora_fin")
                    .HasMaxLength(10);

                entity.Property(e => e.HoraInicio)
                    .IsRequired()
                    .HasColumnName("hora_inicio")
                    .HasMaxLength(10);

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Aseguradoras>(entity =>
            {
                entity.HasKey(e => e.CodAse)
                    .HasName("PRIMARY");

                entity.ToTable("aseguradoras");

                entity.Property(e => e.CodAse)
                    .HasColumnName("cod_ase")
                    .HasMaxLength(6)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.Activa)
                    .HasColumnName("activa")
                    .HasColumnType("tinyint(1) unsigned zerofill")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NomAse)
                    .HasColumnName("nom_ase")
                    .HasMaxLength(60)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Cie10>(entity =>
            {
                entity.HasKey(e => e.CodCie)
                    .HasName("PRIMARY");

                entity.ToTable("cie10");

                entity.Property(e => e.CodCie)
                    .HasColumnName("cod_cie")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.NomCie)
                    .HasColumnName("nom_cie")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TranProt1)
                    .HasColumnName("tran_prot1")
                    .HasMaxLength(15)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TranProt2)
                    .HasColumnName("tran_prot2")
                    .HasMaxLength(15)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CompleNotificacion>(entity =>
            {
                entity.HasKey(e => e.IdNotif)
                    .HasName("PRIMARY");

                entity.ToTable("comple_notificacion");

                entity.HasIndex(e => e.CodCie)
                    .HasName("FK1_cod_cie");

                entity.HasIndex(e => e.CodDptoR)
                    .HasName("FK2_depar");

                entity.Property(e => e.IdNotif)
                    .HasColumnName("id_Notif")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Ajuste)
                    .HasColumnName("ajuste")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CerDef)
                    .HasColumnName("cer_def")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClasifCaso)
                    .HasColumnName("clasif_caso")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodCie)
                    .HasColumnName("cod_cie")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodDptoR)
                    .HasColumnName("cod_dpto_r")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ConFin)
                    .HasColumnName("con_fin")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DireccionR)
                    .HasColumnName("direccion_r")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecCon)
                    .HasColumnName("fec_con")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecDef)
                    .HasColumnName("fec_def")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecHos)
                    .HasColumnName("fec_hos")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fuente)
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IniSin)
                    .HasColumnName("ini_sin")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NomProfe)
                    .HasColumnName("Nom_profe")
                    .HasMaxLength(70)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PacHos)
                    .HasColumnName("pac_hos")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Telefono)
                    .HasColumnType("int(15)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipCas)
                    .HasColumnName("tip_cas")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.CodCieNavigation)
                    .WithMany(p => p.CompleNotificacion)
                    .HasForeignKey(d => d.CodCie)
                    .HasConstraintName("FK1_cod_cie");

                entity.HasOne(d => d.CodDptoRNavigation)
                    .WithMany(p => p.CompleNotificacion)
                    .HasForeignKey(d => d.CodDptoR)
                    .HasConstraintName("FK2_depar");
            });

            modelBuilder.Entity<DatosCuidador>(entity =>
            {
                entity.HasKey(e => e.NumIde)
                    .HasName("PRIMARY");

                entity.ToTable("datos_cuidador");

                entity.HasIndex(e => e.TipIdeCui)
                    .HasName("FK1_tip_Ide");

                entity.Property(e => e.NumIde)
                    .HasColumnName("num_ide")
                    .HasMaxLength(18)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.EdadCui)
                    .HasColumnName("edadCui")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Menores)
                    .HasColumnName("menores")
                    .HasColumnType("decimal(2,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NivEducat)
                    .HasColumnName("niv_educat")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumIdeCui)
                    .HasColumnName("num_ideCui")
                    .HasMaxLength(18)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OcupaCui)
                    .HasColumnName("ocupaCui")
                    .HasMaxLength(20)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriApeCui)
                    .HasColumnName("pri_apeCui")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriNomCui)
                    .HasColumnName("pri_nomCui")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegApeCui)
                    .HasColumnName("seg_apeCui")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegNomCui)
                    .HasColumnName("seg_nomCui")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipIdeCui)
                    .HasColumnName("tip_ideCui")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.NumIdeNavigation)
                    .WithOne(p => p.DatosCuidador)
                    .HasForeignKey<DatosCuidador>(d => d.NumIde)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_datos_cuidador_desnutricion_factores");

                entity.HasOne(d => d.TipIdeCuiNavigation)
                    .WithMany(p => p.DatosCuidador)
                    .HasForeignKey(d => d.TipIdeCui)
                    .HasConstraintName("FK1_tip_Ide");
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.CodDep)
                    .HasName("PRIMARY");

                entity.ToTable("departamentos");

                entity.Property(e => e.CodDep)
                    .HasColumnName("cod_dep")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.NomDep)
                    .HasColumnName("nom_dep")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Desnutricion>(entity =>
            {
                entity.ToTable("desnutricion");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Carnet)
                    .HasColumnName("carnet")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClasificacionPeso)
                    .HasColumnName("clasificacion_peso")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClasificacionTalla)
                    .HasColumnName("clasificacion_talla")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Edad)
                    .HasColumnName("edad")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EdadInicio)
                    .HasColumnName("edad_inicio")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Esquema)
                    .HasColumnName("esquema")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Imc)
                    .HasColumnName("imc")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Incres)
                    .HasColumnName("incres")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nivel)
                    .HasColumnName("nivel")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumIde)
                    .HasColumnName("num_ide")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Perimetro)
                    .HasColumnName("perimetro")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Peso)
                    .HasColumnName("peso")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PesoNacer)
                    .HasColumnName("peso_nacer")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriApe)
                    .HasColumnName("pri_ape")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriNom)
                    .HasColumnName("pri_nom")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegApe)
                    .HasColumnName("seg_ape")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegNom)
                    .HasColumnName("seg_nom")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Talla)
                    .HasColumnName("talla")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TallaNacer)
                    .HasColumnName("talla_nacer")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tiempo)
                    .HasColumnName("tiempo")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipIde)
                    .HasColumnName("tip_ide")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ZcoreEdad)
                    .HasColumnName("zcore_edad")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ZcoreTalla)
                    .HasColumnName("zcore_talla")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Desnutricion2>(entity =>
            {
                entity.ToTable("desnutricion2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Cambios)
                    .HasColumnName("cambios")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Delgadez)
                    .HasColumnName("delgadez")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Diagnostico)
                    .HasColumnName("diagnostico")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Edema)
                    .HasColumnName("edema")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Hiperpigmentacion)
                    .HasColumnName("hiperpigmentacion")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Palidez)
                    .HasColumnName("palidez")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Piel)
                    .HasColumnName("piel")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DesnutricionFactores>(entity =>
            {
                entity.HasKey(e => e.NumIde)
                    .HasName("PRIMARY");

                entity.ToTable("desnutricion_factores");

                entity.Property(e => e.NumIde)
                    .HasColumnName("num_ide")
                    .HasMaxLength(18)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.CarneVac)
                    .HasColumnName("carne_vac")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClasPeso)
                    .HasColumnName("clas_peso")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClasTalla)
                    .HasColumnName("clas_talla")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Complicaciones)
                    .HasColumnName("complicaciones")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CrecDllo)
                    .HasColumnName("crec_dllo")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Delgadez)
                    .HasColumnName("delgadez")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiagMedic)
                    .HasColumnName("diag_medic")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EComplem)
                    .HasColumnName("e_complem")
                    .HasColumnType("decimal(2,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EdadGes)
                    .HasColumnName("edad_ges")
                    .HasColumnType("decimal(2,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Edema)
                    .HasColumnName("edema")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EsqVac)
                    .HasColumnName("esq_vac")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Hiperpigm)
                    .HasColumnName("hiperpigm")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Imc)
                    .HasColumnName("imc")
                    .HasColumnType("decimal(5,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LesCabel)
                    .HasColumnName("les_cabel")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Palidez)
                    .HasColumnName("palidez")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PerBraqui)
                    .HasColumnName("per_braqui")
                    .HasColumnType("decimal(4,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PesoAct)
                    .HasColumnName("peso_act")
                    .HasColumnType("decimal(4,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PesoNac)
                    .HasColumnName("peso_nac")
                    .HasColumnType("decimal(4,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PielRese)
                    .HasColumnName("piel_rese")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RutaAtenc)
                    .HasColumnName("ruta_atenc")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TLechem)
                    .HasColumnName("t_lechem")
                    .HasColumnType("decimal(2,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TallaAct)
                    .HasColumnName("talla_act")
                    .HasColumnType("decimal(5,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TallaNac)
                    .HasColumnName("talla_nac")
                    .HasColumnType("decimal(4,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipoManej)
                    .HasColumnName("tipo_manej")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ZscorePt)
                    .HasColumnName("zscore_pt")
                    .HasColumnType("decimal(7,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ZscoreTe)
                    .HasColumnName("zscore_te")
                    .HasColumnType("decimal(7,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.NumIdeNavigation)
                    .WithOne(p => p.DesnutricionFactores)
                    .HasForeignKey<DesnutricionFactores>(d => d.NumIde)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_desnutricion_factores_ice_desnutricion");
            });

            modelBuilder.Entity<DesnutricionFactoresVisita>(entity =>
            {
                entity.HasKey(e => e.NumIde)
                    .HasName("PRIMARY");

                entity.ToTable("desnutricion_factores_visita");

                entity.Property(e => e.NumIde)
                    .HasColumnName("num_ide")
                    .HasMaxLength(18)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.AjusteSivigila)
                    .HasColumnName("ajusteSivigila")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClasPeso)
                    .HasColumnName("clas_peso")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClasTalla)
                    .HasColumnName("clas_talla")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Clasifi2)
                    .HasColumnName("clasifi2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Conclusiones)
                    .HasColumnName("conclusiones")
                    .HasMaxLength(70)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EntiCanalizada)
                    .HasColumnName("entiCanalizada")
                    .HasMaxLength(20)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FirmaCui)
                    .HasColumnName("firmaCui")
                    .HasColumnType("blob")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Imc)
                    .HasColumnName("imc")
                    .HasColumnType("decimal(5,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NombRetroali)
                    .HasColumnName("nombRetroali")
                    .HasMaxLength(40)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NombreProfecional)
                    .HasColumnName("nombreProfecional")
                    .HasMaxLength(40)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PerBraqui)
                    .HasColumnName("per_braqui")
                    .HasColumnType("decimal(4,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PesoAct)
                    .HasColumnName("peso_act")
                    .HasColumnType("decimal(4,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanInter)
                    .HasColumnName("planInter")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProgCanalizo)
                    .HasColumnName("progCanalizo")
                    .HasMaxLength(20)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RecomenIndivi)
                    .HasColumnName("recomenIndivi")
                    .HasMaxLength(70)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SeCanalizo)
                    .HasColumnName("seCanalizo")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SignosDnt)
                    .HasColumnName("signosDnt")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Subred)
                    .HasColumnName("subred")
                    .HasMaxLength(20)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TallaAct)
                    .HasColumnName("talla_act")
                    .HasColumnType("decimal(5,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ZscorePt)
                    .HasColumnName("zscore_pt")
                    .HasColumnType("decimal(7,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ZscoreTe)
                    .HasColumnName("zscore_te")
                    .HasColumnType("decimal(7,0)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Eventos>(entity =>
            {
                entity.HasKey(e => e.CodEve)
                    .HasName("PRIMARY");

                entity.ToTable("eventos");

                entity.Property(e => e.CodEve)
                    .HasColumnName("cod_eve")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.ClaPer)
                    .HasColumnName("cla_per")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ConFinal)
                    .HasColumnName("con_final")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExaLab)
                    .HasColumnName("exa_lab")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Formulario)
                    .HasColumnName("formulario")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Inmediata)
                    .HasColumnName("inmediata")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NomEve)
                    .HasColumnName("nom_eve")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipNot)
                    .HasColumnName("tip_not")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValSem)
                    .HasColumnName("val_sem")
                    .HasMaxLength(8)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<FailedJobs>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Connection)
                    .IsRequired()
                    .HasColumnName("connection");

                entity.Property(e => e.Exception)
                    .IsRequired()
                    .HasColumnName("exception")
                    .HasColumnType("longtext");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnName("payload")
                    .HasColumnType("longtext");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnName("queue");
            });

            modelBuilder.Entity<GruposEtnicos>(entity =>
            {
                entity.HasKey(e => e.CodGrupoEtni)
                    .HasName("PRIMARY");

                entity.ToTable("grupos_etnicos");

                entity.Property(e => e.CodGrupoEtni)
                    .HasColumnName("cod_grupo_etni")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.NomGrupo)
                    .HasColumnName("nom_grupo")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<HabitosAlimentarios>(entity =>
            {
                entity.HasKey(e => e.NumIde)
                    .HasName("PRIMARY");

                entity.ToTable("habitos_alimentarios");

                entity.Property(e => e.NumIde)
                    .HasColumnName("num_ide")
                    .HasMaxLength(18)
                    .IsFixedLength();

                entity.Property(e => e.AcidoFolico)
                    .HasColumnName("acido_folico")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AlimMayorFre)
                    .HasColumnName("alim_mayor_fre")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AlimMenorFre)
                    .HasColumnName("alim_menor_fre")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AlimeDiaAnte)
                    .HasColumnName("alime_dia_ante")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AnaliAlimen)
                    .HasColumnName("anali_alimen")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AnaliAlimenPorque)
                    .HasColumnName("anali_alimen_porque")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Antibiotico)
                    .HasColumnName("antibiotico")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ConsisMayor)
                    .HasColumnName("consis_mayor")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ConsumoFtlc)
                    .HasColumnName("consumo_ftlc")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CualFormLac)
                    .HasColumnName("cual_form_lac")
                    .HasMaxLength(20)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EdaAlimeSoli)
                    .HasColumnName("eda_alime_soli")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EdaLacComple)
                    .HasColumnName("eda_lac_comple")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EdaLacExcu)
                    .HasColumnName("eda_lac_excu")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EdaOtrasBebidas)
                    .HasColumnName("eda_otras_bebidas")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EgresoFtlc)
                    .HasColumnName("egreso_ftlc")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EntregaFtlc)
                    .HasColumnName("entrega_ftlc")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FormLac)
                    .HasColumnName("form_lac")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Grupo1)
                    .HasColumnName("grupo1")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Grupo2)
                    .HasColumnName("grupo2")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Grupo3)
                    .HasColumnName("grupo3")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Grupo4)
                    .HasColumnName("grupo4")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Grupo5)
                    .HasColumnName("grupo5")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Grupo6)
                    .HasColumnName("grupo6")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HstaEdaForm)
                    .HasColumnName("hsta_eda_form")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InicioLact)
                    .HasColumnName("inicioLact")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IntoleAlimen)
                    .HasColumnName("intole_alimen")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Intrahospitalario)
                    .HasColumnName("intrahospitalario")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OtraFormula)
                    .HasColumnName("otra_formula")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.NumIdeNavigation)
                    .WithOne(p => p.HabitosAlimentarios)
                    .HasForeignKey<HabitosAlimentarios>(d => d.NumIde)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_vista");
            });

            modelBuilder.Entity<IceDesnutricion>(entity =>
            {
                entity.HasKey(e => e.NumIde)
                    .HasName("PRIMARY");

                entity.ToTable("ice_desnutricion");

                entity.Property(e => e.NumIde)
                    .HasColumnName("num_ide")
                    .HasMaxLength(18)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.AlergCual)
                    .HasColumnName("alergCual")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Alergias)
                    .HasColumnName("alergias")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AnteceCual)
                    .HasColumnName("anteceCual")
                    .HasMaxLength(20)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AnteceNaci)
                    .HasColumnName("anteceNaci")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Antecedentes)
                    .HasColumnName("antecedentes")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Basuras)
                    .HasColumnName("basuras")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DireccionReci)
                    .HasColumnName("direccionReci")
                    .HasMaxLength(40)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EstadoHigvivienda)
                    .HasColumnName("estadoHigvivienda")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EstadoVacuna)
                    .HasColumnName("estadoVacuna")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estrato)
                    .HasColumnName("estrato")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Familograma)
                    .HasColumnName("familograma")
                    .HasColumnType("blob")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaInicioIec)
                    .HasColumnName("fecha_inicio_iec")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaSisvan)
                    .HasColumnName("fecha_SISVAN")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechanotUpgd)
                    .HasColumnName("fechanotUpgd")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FuenteAgua)
                    .HasColumnName("fuenteAgua")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Hospitalizacion)
                    .HasColumnName("hospitalizacion")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IceDomicilio)
                    .HasColumnName("iceDomicilio")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IceInstitucion)
                    .HasColumnName("iceInstitucion")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IngresosFamiliaresMes)
                    .HasColumnName("ingresos_familiares_mes")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ManipuAlimento)
                    .HasColumnName("manipuAlimento")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NombreUpegd)
                    .HasColumnName("nombreUpegd")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OtroanteceNutri)
                    .HasColumnName("otroanteceNutri")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProgApoyoalimen)
                    .HasColumnName("progApoyoalimen")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProgPriemerainfancia)
                    .HasColumnName("progPriemerainfancia")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServIdenti)
                    .HasColumnName("servIdenti")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipTenencia)
                    .HasColumnName("tip_tenencia")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipVivienda)
                    .HasColumnName("tip_vivienda")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.NumIdeNavigation)
                    .WithOne(p => p.IceDesnutricion)
                    .HasForeignKey<IceDesnutricion>(d => d.NumIde)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_ice");
            });

            modelBuilder.Entity<IdentPacienteNotificacion>(entity =>
            {
                entity.HasKey(e => e.IdNotif)
                    .HasName("PRIMARY");

                entity.ToTable("ident_paciente_notificacion");

                entity.Property(e => e.IdNotif)
                    .HasColumnName("id_Notif")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Anno)
                    .HasColumnName("anno")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Barrio)
                    .HasColumnName("barrio")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CenPoblad)
                    .HasColumnName("cen_poblad")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodEve)
                    .HasColumnName("cod_eve")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodPaisO)
                    .HasColumnName("cod_pais_o")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodUgp)
                    .HasColumnName("cod_ugp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodVere)
                    .HasColumnName("cod_vere")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Edad)
                    .HasColumnName("edad")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaNto)
                    .HasColumnName("fecha_nto")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Localidad)
                    .HasColumnName("localidad")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Medida)
                    .HasColumnName("medida")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("municipio")
                    .HasMaxLength(100);

                entity.Property(e => e.NumIde)
                    .HasColumnName("num_ide")
                    .HasMaxLength(18)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.Ocupacion)
                    .HasColumnName("ocupacion")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriApe)
                    .HasColumnName("pri_ape")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriNom)
                    .HasColumnName("pri_nom")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegApe)
                    .HasColumnName("seg_ape")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegNom)
                    .HasColumnName("seg_nom")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Semana)
                    .HasColumnName("semana")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipIde)
                    .HasColumnName("tip_ide")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<IdentPacienteNotificacion2>(entity =>
            {
                entity.HasKey(e => e.IdNotif)
                    .HasName("PRIMARY");

                entity.ToTable("ident_paciente_notificacion2");

                entity.Property(e => e.IdNotif)
                    .HasColumnName("id_Notif")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Administradora)
                    .HasColumnName("administradora")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Causa)
                    .HasColumnName("causa")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Certificado)
                    .HasColumnName("certificado")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Clasificacion)
                    .HasColumnName("clasificacion")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Condicion)
                    .HasColumnName("condicion")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estrato)
                    .HasColumnName("estrato")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecConsulta)
                    .HasColumnName("fec_consulta")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaDefuncion)
                    .HasColumnName("fecha_defuncion")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fuente)
                    .HasColumnName("fuente")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Grupo)
                    .HasColumnName("grupo")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Hospitalizacion)
                    .HasColumnName("hospitalizacion")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Hospitalizado)
                    .HasColumnName("hospitalizado")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InicioSintoma)
                    .HasColumnName("inicio_sintoma")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MunicipioRes)
                    .HasColumnName("municipio_res")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pertenencia)
                    .HasColumnName("pertenencia")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Poblacional)
                    .HasColumnName("poblacional")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Regimen)
                    .HasColumnName("regimen")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<InfoUpgdCaracterizacion>(entity =>
            {
                entity.HasKey(e => e.IdCarac)
                    .HasName("PRIMARY");

                entity.ToTable("info_upgd_caracterizacion");

                entity.HasIndex(e => e.CodPre)
                    .HasName("cod_pre");

                entity.Property(e => e.IdCarac)
                    .HasColumnName("id_carac")
                    .HasColumnType("int(100)");

                entity.Property(e => e.CodPre)
                    .HasColumnName("cod_pre")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodSub)
                    .HasColumnName("cod_Sub")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CorEle)
                    .HasColumnName("cor_ele")
                    .HasMaxLength(30)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dir)
                    .HasColumnName("dir")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EsUniInfo)
                    .HasColumnName("es_uni_info")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estadoupgd)
                    .HasColumnName("estadoupgd")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecActivi)
                    .HasColumnName("fec_activi")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecCar)
                    .HasColumnName("fec_car")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecSivigila)
                    .HasColumnName("fec_sivigila")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Localidad)
                    .HasColumnName("localidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NatJur)
                    .HasColumnName("nat_jur")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NitUpgd)
                    .HasColumnName("nit_upgd")
                    .HasMaxLength(12)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NivComplejidad)
                    .HasColumnName("niv_complejidad")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NotifAcc)
                    .IsRequired()
                    .HasColumnName("notif_acc")
                    .HasMaxLength(100);

                entity.Property(e => e.NotifIaas)
                    .HasColumnName("notif_iaas")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RazSoc)
                    .HasColumnName("raz_soc")
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepLeg)
                    .HasColumnName("rep_leg")
                    .HasMaxLength(40)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ResNot)
                    .HasColumnName("res_not")
                    .HasMaxLength(40)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(15)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.ToTable("localidad");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Migrations>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Batch)
                    .HasColumnName("batch")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Migration)
                    .IsRequired()
                    .HasColumnName("migration")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NotificaIaasCaracterizacion>(entity =>
            {
                entity.HasKey(e => e.IdCarac)
                    .HasName("PRIMARY");

                entity.ToTable("notifica_iaas_caracterizacion");

                entity.Property(e => e.IdCarac)
                    .HasColumnName("id_carac")
                    .HasColumnType("int(100)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BiProfesi)
                    .HasColumnName("bi_profesi")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ComiteInf)
                    .HasColumnName("comite_inf")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HospUnive)
                    .HasColumnName("hosp_unive")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IaasUltim)
                    .HasColumnName("iaas_ultim")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdentGye)
                    .HasColumnName("ident_gye")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InfTenden)
                    .HasColumnName("inf_tenden")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InformPat)
                    .HasColumnName("inform_pat")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabAutoma)
                    .HasColumnName("lab_automa")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabCce)
                    .HasColumnName("lab_cce")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabCci)
                    .HasColumnName("lab_cci")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabConPe)
                    .HasColumnName("lab_con_pe")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabMicrob)
                    .HasColumnName("lab_microb")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabPropio)
                    .HasColumnName("lab_propio")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabRemCe)
                    .HasColumnName("lab_rem_ce")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabReport)
                    .HasColumnName("lab_report")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabsContr)
                    .HasColumnName("labs_contr")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MicrCdi)
                    .HasColumnName("micr_cdi")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Microscan)
                    .HasColumnName("microscan")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Phoenix)
                    .HasColumnName("phoenix")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrueSucep)
                    .HasColumnName("prue_sucep")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QuienVcab)
                    .HasColumnName("quien_vcab")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RegExcepc)
                    .HasColumnName("reg_excepc")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SerCircar)
                    .HasColumnName("ser_circar")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SerCirgen)
                    .HasColumnName("ser_cirgen")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SerGineco)
                    .HasColumnName("ser_gineco")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SocialTen)
                    .HasColumnName("social_ten")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotCamas)
                    .HasColumnName("tot_camas")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Vitek)
                    .HasColumnName("vitek")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Whonet)
                    .HasColumnName("whonet")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdCaracNavigation)
                    .WithOne(p => p.NotificaIaasCaracterizacion)
                    .HasForeignKey<NotificaIaasCaracterizacion>(d => d.IdCarac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_caracteriz");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.CodPais)
                    .HasName("PRIMARY");

                entity.ToTable("pais");

                entity.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.Pais1)
                    .HasColumnName("pais")
                    .HasMaxLength(40)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PasswordResets>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasIndex(e => e.Email)
                    .HasName("password_resets_email_index");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RecursosDispoCaracterizacion>(entity =>
            {
                entity.HasKey(e => e.IdCarac)
                    .HasName("PRIMARY");

                entity.ToTable("recursos_dispo_caracterizacion");

                entity.Property(e => e.IdCarac)
                    .HasColumnName("id_carac")
                    .HasColumnType("int(100)");

                entity.Property(e => e.ActSiv)
                    .HasColumnName("act_siv")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Bacteriologo)
                    .HasColumnName("bacteriologo")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Computadora)
                    .HasColumnName("computadora")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Cove)
                    .HasColumnName("cove")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Enfermero)
                    .HasColumnName("enfermero")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EnfermeroIaas)
                    .IsRequired()
                    .HasColumnName("enfermero_iaas")
                    .HasMaxLength(10);

                entity.Property(e => e.Epidemiologo)
                    .HasColumnName("epidemiologo")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Especialista)
                    .HasColumnName("especialista")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FaxMod)
                    .HasColumnName("fax_mod")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Infectologo)
                    .HasColumnName("infectologo")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Internet)
                    .HasColumnName("internet")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MedicoGeneral)
                    .HasColumnName("medico_general")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Microbiologo)
                    .IsRequired()
                    .HasColumnName("microbiologo")
                    .HasMaxLength(10);

                entity.Property(e => e.NotAct)
                    .HasColumnName("not_act")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Otro)
                    .IsRequired()
                    .HasColumnName("otro")
                    .HasMaxLength(10);

                entity.Property(e => e.Promotor)
                    .IsRequired()
                    .HasColumnName("promotor")
                    .HasMaxLength(10);

                entity.Property(e => e.RadTel)
                    .HasColumnName("rad_tel")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TalHum)
                    .HasColumnName("tal_hum")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TecDis)
                    .HasColumnName("tec_dis")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tecnico)
                    .HasColumnName("tecnico")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelFax)
                    .HasColumnName("tel_fax")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TieCor)
                    .HasColumnName("tie_cor")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UAna)
                    .IsRequired()
                    .HasColumnName("u_ana")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UniAna)
                    .HasColumnName("uni_ana")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ServiciosUpgdCaracterizacion>(entity =>
            {
                entity.HasKey(e => e.IdCarac)
                    .HasName("PRIMARY");

                entity.ToTable("servicios_upgd_caracterizacion");

                entity.Property(e => e.IdCarac)
                    .HasColumnName("id_carac")
                    .HasColumnType("int(100)");

                entity.Property(e => e.ConsultaEsp)
                    .HasColumnName("consulta_esp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ConsultaGnrl)
                    .HasColumnName("consultaGnrl")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CuidIntensivos)
                    .HasColumnName("cuidIntensivos")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ginecobstetricia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Hematologia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Inmunologia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MedGnrl)
                    .HasColumnName("medGnrl")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MedInt)
                    .HasColumnName("medInt")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Microbiologia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Neurologia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Parasitologia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Patologia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pediatria)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Quimica)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Toxicologia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Urgencias)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Vacunacion)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Virologia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<TalhumUpgdCaracterizacion>(entity =>
            {
                entity.HasKey(e => e.IdCarac)
                    .HasName("PRIMARY");

                entity.ToTable("talhum_upgd_caracterizacion");

                entity.Property(e => e.IdCarac)
                    .HasColumnName("id_carac")
                    .HasColumnType("int(100)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Bacteriologo)
                    .HasColumnName("bacteriologo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EnferIaas)
                    .HasColumnName("enferIaas")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Enfermero)
                    .HasColumnName("enfermero")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Epidemiologo).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Infectologo)
                    .HasColumnName("infectologo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MedEspecialista)
                    .HasColumnName("medEspecialista")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MedGeneral)
                    .HasColumnName("medGeneral")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Microbiologo)
                    .HasColumnName("microbiologo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Otro)
                    .HasColumnName("otro")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PromotSalud)
                    .HasColumnName("promotSalud")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tecnico)
                    .HasColumnName("tecnico")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdCaracNavigation)
                    .WithOne(p => p.TalhumUpgdCaracterizacion)
                    .HasForeignKey<TalhumUpgdCaracterizacion>(d => d.IdCarac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_ccarter");
            });

            modelBuilder.Entity<TipoId>(entity =>
            {
                entity.HasKey(e => e.TipoIde)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_id");

                entity.Property(e => e.TipoIde)
                    .HasColumnName("tipo_ide")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.NomTipIde)
                    .HasColumnName("nom_tip_ide")
                    .HasMaxLength(15)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<TipoRegSalud>(entity =>
            {
                entity.HasKey(e => e.TipSs)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_reg_salud");

                entity.Property(e => e.TipSs)
                    .HasColumnName("tip_ss")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.Regimen)
                    .HasColumnName("regimen")
                    .HasMaxLength(25)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<TipoUciCaracterizacion>(entity =>
            {
                entity.HasKey(e => e.IdCarac)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_uci_caracterizacion");

                entity.Property(e => e.IdCarac)
                    .HasColumnName("id_carac")
                    .HasColumnType("int(100)");

                entity.Property(e => e.ActivaA)
                    .HasColumnName("activaA")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ActivaN)
                    .HasColumnName("activaN")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ActivaP)
                    .HasColumnName("activaP")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubtipoA)
                    .HasColumnName("subtipoA")
                    .HasMaxLength(25)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubtipoN)
                    .HasColumnName("subtipoN")
                    .HasMaxLength(25)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubtipoP)
                    .HasColumnName("subtipoP")
                    .HasMaxLength(25)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalCamasA)
                    .HasColumnName("totalCamasA")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalCamasN)
                    .HasColumnName("totalCamasN")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalCamasP)
                    .HasColumnName("totalCamasP")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UciA)
                    .HasColumnName("uciA")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UciN)
                    .HasColumnName("uciN")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UciP)
                    .HasColumnName("uciP")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email)
                    .HasName("users_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.FechaEnd)
                    .HasColumnName("fecha_end")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasColumnName("name2")
                    .HasMaxLength(255);

                entity.Property(e => e.Nit)
                    .HasColumnName("nit")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Profesion)
                    .HasColumnName("profesion")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RememberToken)
                    .HasColumnName("remember_token")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Secondname2)
                    .IsRequired()
                    .HasColumnName("secondname2")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("tipo_doc")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Veredas>(entity =>
            {
                entity.HasKey(e => e.CodVere)
                    .HasName("PRIMARY");

                entity.ToTable("veredas");

                entity.Property(e => e.CodVere)
                    .HasColumnName("cod_vere")
                    .HasMaxLength(8)
                    .IsFixedLength()
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20)
                    .IsFixedLength()
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
