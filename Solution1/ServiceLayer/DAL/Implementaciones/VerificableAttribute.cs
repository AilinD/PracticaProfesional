using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Implementaciones
{
    public class VerificableAttribute
    {
        string _prefix;
        public VerificableAttribute(string prefix)
        {
            _prefix = prefix;
        }

        public string Prefix { get { return _prefix; } }
    }
}
