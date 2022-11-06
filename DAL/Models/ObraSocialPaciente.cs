using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ObraSocialPaciente
    {
        public int Id { get; set; }
        public int IdObraSocial { get; set; }
        public int IdPaciente { get; set; }

        public virtual ObraSocial IdObraSocialNavigation { get; set; } = null!;
        public virtual Paciente IdPacienteNavigation { get; set; } = null!;
    }
}
