using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Servicios.Log
{
    internal interface ILog
    {
        void GuardarLog(log log);

        List<log> listarLogs();
    }
}
