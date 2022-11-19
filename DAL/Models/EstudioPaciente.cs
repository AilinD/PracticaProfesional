using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EstudioPaciente
    {
        public int Id { get; set; }
        public int? IdEstudio { get; set; }
        public string? Comentarios { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdMedico { get; set; }
        public int? IdPaciente { get; set; }

        public virtual Estudio? IdEstudioNavigation { get; set; }
        public virtual Medico? IdMedicoNavigation { get; set; }
        public virtual Paciente? IdPacienteNavigation { get; set; }
    }
}
