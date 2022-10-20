//using Serilog.Formatting.Compact;
using DAL.Interfaces;
using Services.Logger;
using System.Diagnostics.Tracing;

namespace Services
{
    public class LoggerService : ILoggingService
    {
        private ILoggerRepository _loggerRepository;
        public LoggerService(ILoggerRepository loggerRepository)
        {
            _loggerRepository = loggerRepository;
        }

        public void WriteLog(string message, EventLevel level, string user)
        {
            _loggerRepository.WriteLog(message, level, user);
        }
    }
}
