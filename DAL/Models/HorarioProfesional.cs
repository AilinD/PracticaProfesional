using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HorarioProfesional
    {
        public int? Id { get; set; }
        public int IdMedico { get; set; }
        public int IdHorario { get; set; }

        public virtual Horario IdHorarioNavigation { get; set; } = null!;
        public virtual Medico IdMedicoNavigation { get; set; } = null!;
    }
}
