using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    [Browsable(false)]

    public partial class Diagnostico
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdMedico { get; set; }
        public string? diagnostico { get; set; }
        public int? IdPaciente { get; set; }

        public virtual Medico? IdMedicoNavigation { get; set; }
        public virtual Paciente? IdPacienteNavigation { get; set; }
    }
}
