using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Dto
{
    public class EspecialidadDto
    {
        [Key]
        public int id { get; set; }
        public string especialidad { get; set; }
    }
}
