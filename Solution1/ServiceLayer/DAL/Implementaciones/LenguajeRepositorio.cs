using ServiceLayer.Domain.Exepciones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Implementaciones
{
    internal class LenguajeRepositorio
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
        #endregion

        private string basePath = ConfigurationManager.AppSettings["LanguagePath"];


        public string Find(string word)
        {
            using (var sr = new StreamReader(basePath + "." + Thread.CurrentThread.CurrentCulture.Name))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('=');

                    if (line[0] == word)
                    //Encontré la clave buscada...
                    {
                        if (String.IsNullOrEmpty(line[1]))
                            //Aplicar una bitácora...
                            return line[0];

                        return line[1];//Retorno la traducción...
                    }
                }
            }

            throw new WordNotFoundExeption();
        }
    }
}
