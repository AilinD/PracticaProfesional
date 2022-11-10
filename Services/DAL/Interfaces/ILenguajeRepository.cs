using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Interfaces
{
    /// <summary>
    /// Interfaz para el lenguaje
    /// </summary>
    internal interface ILenguajeRepository
    {
        /// <summary>
        /// Permite cargar un archivo de lenguaje
        /// </summary>
        /// <param name="Lenguaje"></param>
        /// <returns></returns>
        Dictionary<string, string> GetArchivoLenguaje(string Lenguaje);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shortname"></param>
        /// <param name="traducciones"></param>
        void WriteLanguageFile(string shortname, Dictionary<string, string> traducciones);

    }
}
