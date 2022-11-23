using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DAL.Models
{
    [Browsable(false)]
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
