using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            MedicoPorEspecialidads = new HashSet<MedicoPorEspecialidad>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<MedicoPorEspecialidad> MedicoPorEspecialidads { get; set; }
    }
}
