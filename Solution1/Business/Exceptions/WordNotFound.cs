using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions
{
    public class WordNotFoundException : Exception
    {
        public WordNotFoundException() : base("La palabra no fue encontrada")
        {
            this.HelpLink = "Help";
        }
    }
}
