using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Servicios.Log
{
    internal class LoggerService
    {
        public static void WriteLog(string message, EventLevel level, string user)
        {
            ServiceLayer.BLL.LoggerBLL.WriteLog(message, level, user);
        }
    }
}
