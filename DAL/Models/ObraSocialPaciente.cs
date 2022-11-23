using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DAL.Models
{
    [Browsable(false)]
    public partial class ObraSocialPaciente
    {
        public int Id { get; set; }
        public int IdObraSocial { get; set; }
        public int IdPaciente { get; set; }

        public virtual ObraSocial IdObraSocialNavigation { get; set; } = null!;
        public virtual Paciente IdPacienteNavigation { get; set; } = null!;
    }
}
