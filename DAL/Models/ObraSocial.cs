using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DAL.Models
{
    [Browsable(false)]
    public partial class ObraSocial
    {
        public ObraSocial()
        {
            ObraSocialPacientes = new HashSet<ObraSocialPaciente>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<ObraSocialPaciente> ObraSocialPacientes { get; set; }
    }
}
