using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    /// <summary>
    /// Clase que sirve para insertar en la base del negocio
    /// </summary>
    public class DiagnosticoDto
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdMedico { get; set; }
        public string? diagnostico { get; set; }
        public int? IdPaciente { get; set; }
    }
}
