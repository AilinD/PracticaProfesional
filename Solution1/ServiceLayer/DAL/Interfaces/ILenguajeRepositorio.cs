using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Interfaces
{
    public interface ILenguajeRepositorio
    {
        Dictionary<string, string> GetArchivoLenguaje(string Lenguaje);
        void EscribirArchivoLenguaje(string Abreviatura, Dictionary<string, string> archivoLenguaje);
    }
}
