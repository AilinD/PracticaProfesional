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
    public class LoggerRepositorio
    {
        #region Singleton
        private readonly static LoggerRepositorio _instance = new LoggerRepositorio();

        public static LoggerRepositorio Current
        {
            get
            {
                return _instance;
            }
        }

        private LoggerRepositorio()
        {
            //Implement here the initialization code
        }
        #endregion

        private string pathLog = ConfigurationManager.AppSettings["PathLog"];

        private string pathFile = ConfigurationManager.AppSettings["LogFileName"];
        //public void WriteLog(string message, EventLevel level, string user)
        //{
        //    string fileName = pathLog + DateTime.Now.ToString("yyyyMMdd") + pathFile;


        //    using (StreamWriter streamWriter = new StreamWriter(fileName, true))
        //    {
        //        string fromattedMessage = $"{DateTime.Now.ToString("yyyyMMdd hh:mm:ss tt")} [LEVEL {level.ToString()}] User: {user}, Mensaje: {message}";
        //        streamWriter.WriteLine(fromattedMessage);
        //    }
        //}

        public void WriteLog(/*string message, EventLevel level, string user*/)
        {
            //using (var log = new LoggerConfiguration()
            //.WriteTo.Console()
            //.CreateLogger())
            //{
            //    log.Information("Hello, Serilog!");
            //    log.Warning("Goodbye, Serilog.");
            //}
            //Log.Logger = new LoggerConfiguration()
            //    .MinimumLevel.Verbose()
            //    .WriteTo.Console(theme: AnsiConsoleTheme.Code)
            //    .CreateLogger();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@)

            try
            {
                Log.Debug("Application is starting");
                Log.Information("Hello {name}",Environment.GetEnvironmentVariable("Username"));
                Log.Warning("You are not allowed to see this");


                //ThrowError();
            }
            catch (Exception ex)
            {
                Log.Error(ex,"Something went wrong!");
            }
            Log.CloseAndFlush();
             void ThrowError()
            {
                throw new NullReferenceException();
            }
        }
    }
}
