using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DAL.Models
{
    public partial class Estudio
    {
        [Browsable(false)]
        public Estudio()
        {
            EstudioPacientes = new HashSet<EstudioPaciente>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; }
    }
}
