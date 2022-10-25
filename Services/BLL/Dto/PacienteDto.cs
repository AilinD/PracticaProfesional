using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Dto
{
    public  class PacienteDto
    {
        [Key]
        public int IdPaciente { get; set; }
        public int DNI { get; set; }
        public string? Apellido { get; set; }

        public string Contacto { get; set; }
        public string? Dirección { get; set; }

        public string? Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        
        public string? Nombre { get; set; }
        //public string? ObraSocial { get; set; }
    }
}
