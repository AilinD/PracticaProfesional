using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sintoma
    {
        public Sintoma()
        {
            IdPacientes = new HashSet<Paciente>();
        }

        public int IdSintoma { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Paciente> IdPacientes { get; set; }
    }
}
