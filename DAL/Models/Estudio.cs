using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DAL.Models
{
    [Browsable(false)]
    public partial class Estudio
    {
        public Estudio()
        {
            EstudioPacientes = new HashSet<EstudioPaciente>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; }
    }
}
