using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Domain.Exepciones
{
    internal class WordNotFoundExeption : Exception
    {
        public WordNotFoundExeption(string message) : base(message)
        {

        }
        public WordNotFoundExeption() : base("La palabra no fue encontrada")
        {

        }
    }
}
