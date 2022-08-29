using ServiceLayer.Servicios.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL.Log
{
    public class Logger
    {
        internal Logger _logger;

        internal Logger ObtenerInstancia()
        {
            if(_logger == null)
            _logger = new Logger();
            return _logger;
        }

        public void Log(string mensaje)
        {
            var nlog = new log(mensaje);
        }
    }
}
