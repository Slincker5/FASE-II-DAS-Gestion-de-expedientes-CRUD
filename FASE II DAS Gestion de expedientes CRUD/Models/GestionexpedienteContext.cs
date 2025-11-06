using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;

public partial class GestionexpedienteContext : DbContext
{
    public GestionexpedienteContext()
    {
    }

    public GestionexpedienteContext(DbContextOptions<GestionexpedienteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Expediente> Expedientes { get; set; }

    public virtual DbSet<Materium> Materia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=GESTIONEXPEDIENTE;User Id=sa;Password=12345678;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.AlumnoId).HasName("PK__Alumno__90A6AA33D2C83993");

            entity.ToTable("Alumno");

            entity.Property(e => e.AlumnoId).HasColumnName("AlumnoID");
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Grado).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Expediente>(entity =>
        {
            entity.HasKey(e => e.ExpedienteId).HasName("PK__Expedien__EBC60A569E6C1148");

            entity.ToTable("Expediente");

            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.AlumnoId).HasColumnName("AlumnoID");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.Observaciones).HasMaxLength(200);

            entity.HasOne(d => d.Alumno).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.AlumnoId)
                .HasConstraintName("FK__Expedient__Alumn__3E52440B");

            entity.HasOne(d => d.Material).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK__Expedient__Mater__3F466844");
        });

        modelBuilder.Entity<Materium>(entity =>
        {
            entity.HasKey(e => e.MaterialId).HasName("PK__Materia__C50613179779BFA2");

            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.Docente).HasMaxLength(100);
            entity.Property(e => e.NombreMateria).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
