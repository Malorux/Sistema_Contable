using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Sistema_Contable.Models.DB
{
    public partial class SistemaContableContext : DbContext
    {
        public SistemaContableContext()
        {
        }

        public SistemaContableContext(DbContextOptions<SistemaContableContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AsientoContable> AsientoContables { get; set; }
        public virtual DbSet<AsientoDetalle> AsientoDetalles { get; set; }
        public virtual DbSet<CatalogoCuentum> CatalogoCuenta { get; set; }
        public virtual DbSet<CatalogosEstado> CatalogosEstados { get; set; }
        public virtual DbSet<Clasificacion> Clasificacions { get; set; }
        public virtual DbSet<EstadosFinanciero> EstadosFinancieros { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<VcuentasContable> VcuentasContables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost; Database=SistemaContable; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AsientoContable>(entity =>
            {
                entity.HasKey(e => e.IdAsiento);

                entity.ToTable("AsientoContable");

                entity.Property(e => e.IdAsiento)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Asiento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.TotalDebe).HasColumnType("money");

                entity.Property(e => e.TotalHaber).HasColumnType("money");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AsientoContables)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsientoContable_Usuario");
            });

            modelBuilder.Entity<AsientoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdAsientoDetalle);

                entity.ToTable("AsientoDetalle");

                entity.Property(e => e.IdAsientoDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_AsientoDetalle");

                entity.Property(e => e.Debe).HasColumnType("money");

                entity.Property(e => e.Haber).HasColumnType("money");

                entity.Property(e => e.IdAsiento).HasColumnName("ID_Asiento");

                entity.Property(e => e.IdCuenta).HasColumnName("ID_Cuenta");

                entity.HasOne(d => d.IdAsientoNavigation)
                    .WithMany(p => p.AsientoDetalles)
                    .HasForeignKey(d => d.IdAsiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsientoDetalle_AsientoContable");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AsientoDetalles)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsientoDetalle_CatalogoCuenta");
            });

            modelBuilder.Entity<CatalogoCuentum>(entity =>
            {
                entity.HasKey(e => e.IdCuenta)
                    .HasName("PK__Catalogo__820D611FF5112558");

                entity.Property(e => e.IdCuenta).HasColumnName("ID_Cuenta");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdClasificacion).HasColumnName("ID_Clasificacion");

                entity.Property(e => e.IdPadre).HasColumnName("ID_Padre");

                entity.Property(e => e.Naturaleza)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NombreCuenta)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SaldoInicial).HasColumnType("money");

                entity.HasOne(d => d.IdClasificacionNavigation)
                    .WithMany(p => p.CatalogoCuenta)
                    .HasForeignKey(d => d.IdClasificacion)
                    .HasConstraintName("FK__CatalogoC__ID_Cl__534D60F1");

                entity.HasOne(d => d.IdPadreNavigation)
                    .WithMany(p => p.InverseIdPadreNavigation)
                    .HasForeignKey(d => d.IdPadre)
                    .HasConstraintName("FK__CatalogoC__ID_Pa__52593CB8");
            });

            modelBuilder.Entity<CatalogosEstado>(entity =>
            {
                entity.HasKey(e => e.IdCuenta);

                entity.Property(e => e.IdCuenta)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Cuenta");

                entity.Property(e => e.IdEstadoFinanciero).HasColumnName("ID_EstadoFinanciero");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithOne(p => p.CatalogosEstado)
                    .HasForeignKey<CatalogosEstado>(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Catalogos_Estados_CatalogoCuenta");

                entity.HasOne(d => d.IdEstadoFinancieroNavigation)
                    .WithMany(p => p.CatalogosEstados)
                    .HasForeignKey(d => d.IdEstadoFinanciero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Catalogos_Estados_EstadosFinancieros");
            });

            modelBuilder.Entity<Clasificacion>(entity =>
            {
                entity.HasKey(e => e.IdClasificacion)
                    .HasName("PK__Clasific__0D78096B3B278932");

                entity.ToTable("Clasificacion");

                entity.Property(e => e.IdClasificacion).HasColumnName("ID_Clasificacion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<EstadosFinanciero>(entity =>
            {
                entity.HasKey(e => e.IdEstadoFinanciero);

                entity.Property(e => e.IdEstadoFinanciero)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_EstadoFinanciero");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Persona");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.ToTable("TipoUsuario");

                entity.Property(e => e.IdTipoUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_TipoUsuario");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__DE4431C555586D3D");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.NombreUsuario, "UQ__Usuario__6B0F5AE033F69E28")
                    .IsUnique();

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_Usuario");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("ID_TipoUsuario");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_TipoUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithOne(p => p.Usuario)
                    .HasForeignKey<Usuario>(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Persona");
            });

            modelBuilder.Entity<VcuentasContable>(entity =>
            {
                //entity.HasNoKey( );

                entity.HasKey(e => e.IdCuenta);

                entity.ToView("VCuentasContable");

                entity.Property(e => e.Auxiliar)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCuenta).HasColumnName("ID_Cuenta");

                entity.Property(e => e.IdPadre).HasColumnName("ID_Padre");

                entity.Property(e => e.NombreCuentaC)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
