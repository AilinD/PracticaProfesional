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
        public static ILenguajeRepositorio LenguajeRepositorio { get; private set; }


        static DALFactory()
        {
           // LenguajeRepositorio = CreateInstance<ILenguajeRepositorio>("BaseServices." + JsonRepository + ".LanguageRepository");
        }
    }
}
