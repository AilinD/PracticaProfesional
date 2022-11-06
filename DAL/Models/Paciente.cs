using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Paciente
    {
        public Paciente()
        {
            Diagnosticos = new HashSet<Diagnostico>();
            EstudioPacientes = new HashSet<EstudioPaciente>();
            HistorialPacientes = new HashSet<HistorialPaciente>();
            ObraSocialPacientes = new HashSet<ObraSocialPaciente>();
            IdSintomas = new HashSet<Sintoma>();
        }

        public int IdPaciente { get; set; }
        public int Dni { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Dirección { get; set; }
        public string? Contacto { get; set; }
        public string? Sexo { get; set; }

        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
        public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; }
        public virtual ICollection<HistorialPaciente> HistorialPacientes { get; set; }
        public virtual ICollection<ObraSocialPaciente> ObraSocialPacientes { get; set; }

        public virtual ICollection<Sintoma> IdSintomas { get; set; }
    }
}
