using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MedicoPorEspecialidad
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public int IdEspecialidad { get; set; }

        public virtual Especialidad IdEspecialidadNavigation { get; set; } = null!;
        public virtual Medico Medico { get; set; } = null!;
    }
}
