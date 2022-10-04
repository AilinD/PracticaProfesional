using Serilog;
//using Serilog.Formatting.Compact;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Servicios.Log
{
    public static class LoggerService
    {
        public static void WriteLog(string message, EventLevel level, string user)
        {
            ServiceLayer.BLL.LoggerBLL.WriteLog(message, level, user);
        }

     
    }
}
