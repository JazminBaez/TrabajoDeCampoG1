using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using seguridad_barrios_privados.Properties;
namespace seguridad_barrios_privados.Modelos;

public partial class DbBarriosPrivadosContext : DbContext
{
    public DbBarriosPrivadosContext()
    {
    }

    public DbBarriosPrivadosContext(DbContextOptions<DbBarriosPrivadosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Direccion> Direcciones { get; set; }

    public virtual DbSet<Egreso> Egresos { get; set; }

    public virtual DbSet<Ingreso> Ingresos { get; set; }

    public virtual DbSet<Rol> Roles { get; set; }

    public virtual DbSet<Solicitud> Solicitudes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Visitante> Visitantes { get; set; }

    public virtual DbSet<SolicitudConDetalle> SolicitudConDetalle { get; set; }

    public virtual DbSet<IngresoConDetalle> IngresoConDetalle { get; set; }

    public virtual DbSet<EgresoConDetalle> EgresoConDetalle { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Resources.conexion);
        //imprimer por consola
        Console.WriteLine("en dbbarriosprivadoscontext" + optionsBuilder.Options);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Direccion>(entity =>
        {
            entity.HasKey(e => e.IdDireccion).HasName("PK__direccio__25C35D07F48A3CA7");

            entity.ToTable("direccion");

            entity.Property(e => e.IdDireccion)
            .ValueGeneratedOnAdd()
                .HasColumnName("id_direccion");
           entity.Property(e => e.Altura).HasColumnName("altura")
             .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("altura"); 
            entity.Property(e => e.Calle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("calle");
        });

        modelBuilder.Entity<Egreso>(entity =>
        {
            entity.HasKey(e => e.IdEgreso).HasName("PK__egreso__6B30851BEE555499");

            entity.ToTable("egreso");

            entity.Property(e => e.IdEgreso)
               .ValueGeneratedOnAdd()
                .HasColumnName("id_egreso");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.Egresos)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__egreso__id_ingre__47DBAE45");
        });

        modelBuilder.Entity<Ingreso>(entity =>
        {
            entity.HasKey(e => e.IdIngreso).HasName("PK__ingreso__8FF0F0DE52073BF1");

            entity.ToTable("ingreso");

            entity.Property(e => e.IdIngreso)
               .ValueGeneratedOnAdd()
                .HasColumnName("id_ingreso");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.Ingresos)
                .HasForeignKey(d => d.IdSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ingreso__id_soli__44FF419A");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__rol__6ABCB5E02624BD5D");

            entity.ToTable("rol");

            entity.Property(e => e.IdRol)
             .ValueGeneratedOnAdd()
                .HasColumnName("id_rol");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud).HasName("PK__solicitu__5C0C31F34654F0F0");

            entity.ToTable("solicitud");

            entity.Property(e => e.IdSolicitud)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_solicitud");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdVisitante).HasColumnName("id_visitante");

            entity.Property(s => s.Estado)
                .IsRequired()
                .HasDefaultValue(0)
                .HasColumnName("estado");


            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__solicitud__id_us__412EB0B6");

            entity.HasOne(d => d.IdVisitanteNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.IdVisitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__solicitud__id_visitante");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuario__4E3E04AD53FB230C");

            entity.ToTable("usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdDireccion).HasColumnName("id_direccion");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.Property(s => s.Estado)
              .IsRequired()
              .HasDefaultValue(0)
              .HasColumnName("estado");

            entity.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdDireccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuario__id_dire__3C69FB99");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuario__id_rol__3B75D760");
        });

        modelBuilder.Entity<Visitante>(entity =>
        {
            entity.HasKey(e => e.IdVisitante).HasName("PK__visitant__1EF2D87D1D46DDDB");

            entity.ToTable("visitante");

            entity.Property(e => e.IdVisitante)
                  .ValueGeneratedOnAdd()
                .HasColumnName("id_visitante");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
