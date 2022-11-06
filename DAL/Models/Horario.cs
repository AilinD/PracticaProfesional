using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Horario
    {
        public Horario()
        {
            HorarioProfesionals = new HashSet<HorarioProfesional>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<HorarioProfesional> HorarioProfesionals { get; set; }
    }
}
