using Services.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL
{
    public class LoggerBLL
    {
        #region Singleton
        private readonly static LoggerBLL _instance = new LoggerBLL();

        public static LoggerBLL Current
        {
            get
            {
                return _instance;
            }
        }

        private LoggerBLL()
        {
            //Implement here the initialization code
        }
        #endregion
        public static void WriteLog(string message, EventLevel level, string user)
        {
            DALFactory.LoggerRepository().WriteLog(message, level, user);



        }
    }
}
