using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Turno
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string? Fecha { get; set; }
        public int? IdMedico { get; set; }
        public int? IdRecepcionista { get; set; }

        public virtual Medico? IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; } = null!;
        public virtual Recepcionistum? IdRecepcionistaNavigation { get; set; }
    }
}
