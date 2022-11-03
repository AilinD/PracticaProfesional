using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Dto
{
    public class SintomaDto
    {
        [Key]
        public int IdSintoma { get; set; }
        public string sintoma { get; set; }
    }
}
