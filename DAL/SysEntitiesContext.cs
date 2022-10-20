using DOMAIN;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class SysEntitiesContext:DbContext
    {
        private readonly IConfiguration _configuration;


        public SysEntitiesContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //public virtual DbSet<Diagnostico> Diagnostico { get; set; }
        //public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Estudio> Estudio { get; set; }
        //public virtual DbSet<EstudioPaciente> EstudioPaciente { get; set; }
        public virtual DbSet<Guardia> Guardia { get; set; }
        //public virtual DbSet<HistorialPaciente> HistorialPaciente { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        //public virtual DbSet<HorarioProfesional> HorarioProfesional { get; set; }
        public virtual DbSet<Medico> Medico { get; set; }
        //public virtual DbSet<MedicoPorEspecialidad> MedicoPorEspecialidad { get; set; }
        //public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<ObraSocial> ObraSocial { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Recepcionista> Recepcionista { get; set; }
        public virtual DbSet<Sintoma> Sintoma { get; set; }
        public virtual DbSet<Turno> Turnoes { get; set; }


    }
}
