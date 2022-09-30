using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public class UIException : Exception
    {
        public UIException(String message) : base(message)
        {

        }
    }
}
