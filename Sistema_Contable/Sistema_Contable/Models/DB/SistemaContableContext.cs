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
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<VcuentasContable> VcuentasContables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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

                entity.Property(e => e.IdAsiento).HasColumnName("ID_Asiento");

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

                entity.Property(e => e.IdAsientoDetalle).HasColumnName("ID_AsientoDetalle");

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

                entity.Property(e => e.IdEstadoFinanciero).HasColumnName("ID_EstadoFinanciero");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Roles__3214EC07A640A438");

                entity.Property(e => e.IdRol).HasColumnName("Id_Rol");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__DE4431C5F5B53F4B");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Correo, "UQ__Usuario__60695A196CE67073")
                    .IsUnique();

                entity.HasIndex(e => e.Usuario1, "UQ__Usuario__E3237CF7FBE65A15")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdRol).HasColumnName("ID_Rol");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Usuario");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Roles");
            });

            modelBuilder.Entity<VcuentasContable>(entity =>
            {
                entity.HasNoKey();

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
