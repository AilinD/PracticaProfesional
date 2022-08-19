using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Enfermedad
    {
        public Guid ID { get; set; }
        public string Descripcion { get; set; }

        public List<Sintoma> sintomas { get; set; }
    }
}
