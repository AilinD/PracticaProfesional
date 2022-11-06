using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class SysCExpertContext : DbContext
    {
        public SysCExpertContext()
        {
        }

        public SysCExpertContext(DbContextOptions<SysCExpertContext> options)
            : base(options)
        {
        }

        public SysCExpertContext(string cadena) : base(GetOptions(cadena))
        {
        }
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        public virtual DbSet<Diagnostico> Diagnosticos { get; set; } = null!;
        public virtual DbSet<Especialidad> Especialidads { get; set; } = null!;
        public virtual DbSet<Estudio> Estudios { get; set; } = null!;
        public virtual DbSet<EstudioPaciente> EstudioPacientes { get; set; } = null!;
        public virtual DbSet<Guardium> Guardia { get; set; } = null!;
        public virtual DbSet<HistorialPaciente> HistorialPacientes { get; set; } = null!;
        public virtual DbSet<Horario> Horarios { get; set; } = null!;
        public virtual DbSet<HorarioProfesional> HorarioProfesionals { get; set; } = null!;
        public virtual DbSet<Medico> Medicos { get; set; } = null!;
        public virtual DbSet<MedicoPorEspecialidad> MedicoPorEspecialidads { get; set; } = null!;
        public virtual DbSet<ObraSocial> ObraSocials { get; set; } = null!;
        public virtual DbSet<ObraSocialPaciente> ObraSocialPacientes { get; set; } = null!;
        public virtual DbSet<Paciente> Pacientes { get; set; } = null!;
        public virtual DbSet<Recepcionistum> Recepcionista { get; set; } = null!;
        public virtual DbSet<Sintoma> Sintomas { get; set; } = null!;
        public virtual DbSet<Turno> Turnos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-H0P0HUN\\SQLEXPRESS;Initial Catalog=SysCExpert;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diagnostico>(entity =>
            {
                entity.ToTable("Diagnostico");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Diagnosticos)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK_Diagnostico_Medico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Diagnosticos)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_Diagnostico_Paciente");
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.ToTable("Especialidad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estudio>(entity =>
            {
                entity.ToTable("Estudio");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstudioPaciente>(entity =>
            {
                entity.ToTable("EstudioPaciente");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdEstudioNavigation)
                    .WithMany(p => p.EstudioPacientes)
                    .HasForeignKey(d => d.IdEstudio)
                    .HasConstraintName("FK_EstudioPaciente_Estudio");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.EstudioPacientes)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EstudioPaciente_Medico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.EstudioPacientes)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_EstudioPaciente_Paciente");
            });

            modelBuilder.Entity<Guardium>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Guardia)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK_Guardia_Medico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Guardia)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_Guardia_Paciente");
            });

            modelBuilder.Entity<HistorialPaciente>(entity =>
            {
                entity.ToTable("HistorialPaciente");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.HistorialPacientes)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK_HistorialPaciente_Medico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.HistorialPacientes)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_HistorialPaciente_Paciente");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.ToTable("Horario");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HorarioProfesional>(entity =>
            {
                entity.HasKey(e => new { e.IdMedico, e.IdHorario });

                entity.ToTable("HorarioProfesional");

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.HorarioProfesionals)
                    .HasForeignKey(d => d.IdHorario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HorarioProfesional_Horario");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.HorarioProfesionals)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HorarioProfesional_Medico");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.ToTable("Medico");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto).HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedicoPorEspecialidad>(entity =>
            {
                entity.ToTable("MedicoPorEspecialidad");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.MedicoPorEspecialidads)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicoPorEspecialidad_Especialidad");

                entity.HasOne(d => d.Medico)
                    .WithMany(p => p.MedicoPorEspecialidads)
                    .HasForeignKey(d => d.MedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicoPorEspecialidad_Medico");
            });

            modelBuilder.Entity<ObraSocial>(entity =>
            {
                entity.ToTable("ObraSocial");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObraSocialPaciente>(entity =>
            {
                entity.ToTable("ObraSocialPaciente");

                entity.HasOne(d => d.IdObraSocialNavigation)
                    .WithMany(p => p.ObraSocialPacientes)
                    .HasForeignKey(d => d.IdObraSocial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObraSocialPaciente_ObraSocial1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ObraSocialPacientes)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObraSocialPaciente_Paciente");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente)
                    .HasName("PK_Paciente_1");

                entity.ToTable("Paciente");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto).HasMaxLength(50);

                entity.Property(e => e.Dirección)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recepcionistum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sintoma>(entity =>
            {
                entity.HasKey(e => e.IdSintoma);

                entity.ToTable("Sintoma");

                entity.Property(e => e.IdSintoma).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasMany(d => d.IdPacientes)
                    .WithMany(p => p.IdSintomas)
                    .UsingEntity<Dictionary<string, object>>(
                        "SintomaPaciente",
                        l => l.HasOne<Paciente>().WithMany().HasForeignKey("IdPaciente").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SintomaPaciente_Paciente"),
                        r => r.HasOne<Sintoma>().WithMany().HasForeignKey("IdSintoma").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SintomaPaciente_Sintoma"),
                        j =>
                        {
                            j.HasKey("IdSintoma", "IdPaciente");

                            j.ToTable("SintomaPaciente");
                        });
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.ToTable("Turno");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK_Turno_Medico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Turno_Paciente");

                entity.HasOne(d => d.IdRecepcionistaNavigation)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.IdRecepcionista)
                    .HasConstraintName("FK_Turno_Recepcionista");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
