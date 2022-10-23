using Services.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL
{
    internal class DALFactory
    {
        //public static LenguajeRepo lenguajeRepo { get; private set; }
        public static LoggerRepository LoggerRepository()
        {
            return new LoggerRepository();
        }
    }
}
