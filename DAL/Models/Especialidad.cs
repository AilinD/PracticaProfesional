using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DAL.Models
{
    [Browsable(false)]
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
