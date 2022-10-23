using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Dto
{
    public class TurnoDto
    {
       public int DniPaciente {get;set;}
        public DateTime Fecha { get;set;}
        public int MatriculaMedico { get; set; }
        public int IdRecepcionista { get; set; }
    }
}
