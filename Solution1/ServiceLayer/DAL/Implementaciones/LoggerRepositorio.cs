using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Implementaciones
{
    public class LoggerRepository
    {

        private string pathLog = ConfigurationManager.AppSettings["PathLog"];

      
        public void WriteLog(string message, EventLevel level, string user)
        {
            string fileName = pathLog + DateTime.Now.ToString("yyyyMMdd") ;

            //Aplicar sus políticas...
            //1 opción: En función de la severity que configuren en su app.config
            //Registro desde ese nivel hacia arriba...
            //2 política de limpieza: Definir cada cuánto tiempo/tamaño? limpio mis logs...

            using (StreamWriter streamWriter = new StreamWriter(fileName, true))
            {
                string fromattedMessage = $"{DateTime.Now.ToString("yyyyMMdd hh:mm:ss tt")} [LEVEL {level.ToString()}] User: {user}, Mensaje: {message}";
                streamWriter.WriteLine(fromattedMessage);
            }
    }  }
}
