using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DAL.Models
{
    [Browsable(false)]
    public partial class HistorialPaciente
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdPaciente { get; set; }
        public string? Comentario { get; set; }
        public int? IdMedico { get; set; }

        public virtual Medico? IdMedicoNavigation { get; set; }
        public virtual Paciente? IdPacienteNavigation { get; set; }
    }
}
