using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public partial class Sintoma
    {
        public Sintoma()
        {
            IdPacientes = new HashSet<Paciente>();
        }

        [Key]
        public int IdSintoma { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Paciente> IdPacientes { get; set; }
    }
}
