using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Diagnostico
    {
        public string Id { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public int? IdMedico { get; set; }
        public string? Nombre { get; set; }
        public int? IdPaciente { get; set; }

        public virtual Medico? IdMedicoNavigation { get; set; }
        public virtual Paciente? IdPacienteNavigation { get; set; }
    }
}
