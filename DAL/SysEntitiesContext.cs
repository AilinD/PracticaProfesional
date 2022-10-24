using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SysEntitiesContext:DbContext
    {

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public SysEntitiesContext(string cadena):base(GetOptions(cadena))
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }


        ////public virtual DbSet<Diagnostico> Diagnostico { get; set; }
        ////public virtual DbSet<Especialidad> Especialidad { get; set; }
        //public virtual DbSet<Estudio> Estudio { get; set; }
        ////public virtual DbSet<EstudioPaciente> EstudioPaciente { get; set; }
        //public virtual DbSet<Guardia> Guardia { get; set; }
        ////public virtual DbSet<HistorialPaciente> HistorialPaciente { get; set; }
        //public virtual DbSet<Horario> Horario { get; set; }
        ////public virtual DbSet<HorarioProfesional> HorarioProfesional { get; set; }
        //public virtual DbSet<Medico> Medico { get; set; }
        ////public virtual DbSet<MedicoPorEspecialidad> MedicoPorEspecialidad { get; set; }
        ////public virtual DbSet<Medicos> Medicos { get; set; }
        //public virtual DbSet<ObraSocial> ObraSocial { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        //public virtual DbSet<Recepcionista> Recepcionista { get; set; }
        //public virtual DbSet<Sintoma> Sintoma { get; set; }
        //public virtual DbSet<Turno> Turnoes { get; set; }


    }
}
