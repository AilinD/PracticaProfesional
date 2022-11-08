using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class EnfermedadDto
    {
        [Key]
        public int ID { get; set; }
        public string Descripcion { get; set; }

        //public List<Sintoma> sintomas { get; set; }
    }
}
