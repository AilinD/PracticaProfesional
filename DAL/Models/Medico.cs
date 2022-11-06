using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Medico
    {
        public Medico()
        {
            Diagnosticos = new HashSet<Diagnostico>();
            EstudioPacientes = new HashSet<EstudioPaciente>();
            Guardia = new HashSet<Guardium>();
            HistorialPacientes = new HashSet<HistorialPaciente>();
            HorarioProfesionals = new HashSet<HorarioProfesional>();
            MedicoPorEspecialidads = new HashSet<MedicoPorEspecialidad>();
            Turnos = new HashSet<Turno>();
        }

        public int Id { get; set; }
        public int Matricula { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public string? Contacto { get; set; }

        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
        public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; }
        public virtual ICollection<Guardium> Guardia { get; set; }
        public virtual ICollection<HistorialPaciente> HistorialPacientes { get; set; }
        public virtual ICollection<HorarioProfesional> HorarioProfesionals { get; set; }
        public virtual ICollection<MedicoPorEspecialidad> MedicoPorEspecialidads { get; set; }
        public virtual ICollection<Turno> Turnos { get; set; }
    }
}
