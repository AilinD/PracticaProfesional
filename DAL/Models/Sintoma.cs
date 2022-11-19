using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sintoma
    {
        public Sintoma()
        {
            SintomaPacientes = new HashSet<SintomaPaciente>();
        }

        public int IdSintoma { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<SintomaPaciente> SintomaPacientes { get; set; }
    }
}
