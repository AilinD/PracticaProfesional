using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Interfaces
{
    public interface  ILoggerRepository
    {
        void WriteLog(string message, EventLevel level, string user);
    }
}
