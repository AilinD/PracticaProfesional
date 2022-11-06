using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MedicoPorEspecialidad
    {
        public int Id { get; set; }
        public int IdMedico { get; set; }
        public int IdEspecialidad { get; set; }

        public virtual Especialidad IdEspecialidadNavigation { get; set; } = null!;
        public virtual Medico IdMedicoNavigation { get; set; } = null!;
    }
}
