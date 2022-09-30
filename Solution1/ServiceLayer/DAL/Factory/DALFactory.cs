using ServiceLayer.DAL.Implementaciones;
using ServiceLayer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Factory
{
    /// <summary>
    /// Clase para servicios de base
    /// </summary>
    internal class DALFactory
    {
        public static LenguajeRepositorio LanguageRepository { get; private set; }

        public static LoggerRepository LoggerRepository()
        {
            return new LoggerRepository();
        }


    }
}
