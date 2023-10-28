using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace seguridad_barrios_privados.Models
{

    public partial class DbBarriosPrivadosContext : DbContext
    {
        public DbBarriosPrivadosContext()
        {
        }

        public DbBarriosPrivadosContext(DbContextOptions<DbBarriosPrivadosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Egreso> Egresos { get; set; }

        public virtual DbSet<Ingreso> Ingresos { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Solicitude> Solicitudes { get; set; }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual DbSet<Visitante> Visitantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Egreso>(entity =>
            {
                entity.HasKey(e => e.IdEgreso).HasName("PK__egresos__6B30851B5AE311B2");

                entity.ToTable("egresos");

                entity.Property(e => e.IdEgreso).HasColumnName("id_egreso");
           
                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");
                entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.Egresos)
                    .HasForeignKey(d => d.IdIngreso)
                    .HasConstraintName("FK__egresos__id_ingr__4D94879B");
            });

            modelBuilder.Entity<Ingreso>(entity =>
            {
                entity.HasKey(e => e.IdIngreso).HasName("PK__ingresos__8FF0F0DEC4AFFA30");

                entity.ToTable("ingresos");

                entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");
                entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");

                entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.Ingresos)
                    .HasForeignKey(d => d.IdSolicitud)
                    .HasConstraintName("FK__ingresos__id_sol__4AB81AF0");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol).HasName("PK__roles__6ABCB5E0B698EDFF");

                entity.ToTable("roles");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Solicitude>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud).HasName("PK__solicitu__5C0C31F34DD6A40D");

                entity.ToTable("solicitudes");

                entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
                entity.Property(e => e.Baja).HasColumnName("baja");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");
                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
                entity.Property(e => e.IdVisitante).HasColumnName("id_visitante");

                entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__solicitud__id_us__46E78A0C");

                entity.HasOne(d => d.IdVisitanteNavigation).WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.IdVisitante)
                    .HasConstraintName("FK__solicitud__id_vi__47DBAE45");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario).HasName("PK__usuarios__4E3E04AD04162266");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Email, "UQ__usuarios__AB6E616409ED87A5").IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
                entity.Property(e => e.Apellido)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("apellido");
                entity.Property(e => e.Contrasena)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.IdRol).HasColumnName("id_rol");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__usuarios__id_rol__440B1D61");
            });

            modelBuilder.Entity<Visitante>(entity =>
            {
                entity.HasKey(e => e.IdVisitante).HasName("PK__visitant__1EF2D87D8A795BAE");

                entity.ToTable("visitantes");

                entity.HasIndex(e => e.Dni, "UQ__visitant__D87608A75C8D969E").IsUnique();

                entity.Property(e => e.IdVisitante).HasColumnName("id_visitante");
                entity.Property(e => e.Apellido)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("apellido");
                entity.Property(e => e.Dni)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dni");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
