using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SintomaPaciente
    {
        public int IdSintoma { get; set; }
        public int IdPaciente { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdMedico { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; } = null!;
        public virtual Sintoma IdSintomaNavigation { get; set; } = null!;
    }
}
