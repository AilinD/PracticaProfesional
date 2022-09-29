using ServiceLayer.DAL.Factory;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public class LoggerBLL
    {
        public static void WriteLog(string message, EventLevel level, string user)
        {
            DALFactory.LoggerRepository.WriteLog(message, level, user);

           

        }
    }
}
