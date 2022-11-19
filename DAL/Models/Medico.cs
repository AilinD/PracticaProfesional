using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Medico
    {
        public Medico()
        {
            Diagnosticos = new HashSet<Diagnostico>();
            EstudioPacientes = new HashSet<EstudioPaciente>();
            MedicoPorEspecialidads = new HashSet<MedicoPorEspecialidad>();
        }

        public int IdMedico { get; set; }
        public int Matricula { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public string? Contacto { get; set; }

        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
        public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; }
        public virtual ICollection<MedicoPorEspecialidad> MedicoPorEspecialidads { get; set; }
    }
}
