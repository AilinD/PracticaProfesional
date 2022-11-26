using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class EstudioPacienteDTO
    {
        public string? Comentarios { get; set; }
        public DateTime? Fecha { get; set; }

        public string? Estudio { get; set; }

        public string? Medico { get; set; }

        public string? Paciente { get; set; }
    }
}
