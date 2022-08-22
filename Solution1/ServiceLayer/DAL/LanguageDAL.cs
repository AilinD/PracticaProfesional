using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Business.Exceptions;

namespace ServiceLayer.DAL
{
    internal class LanguageDAL
    {
       // private static string pathBase = ConfigurationManager.AppSettings["PathDefaultLanguageName"];
        //public static string Translate(string word)
        //{
        //    string currentCulture = Thread.CurrentThread.CurrentUICulture.Name;

        //    using (StreamReader str = new StreamReader(/*pathBase +*/ currentCulture))
        //    {
        //        while (!str.EndOfStream)
        //        {
        //            string line = str.ReadLine();
        //            string[] words = line.Split('=');

        //            if (words[0] == word)
        //            {
        //                return words[1];
        //            }
        //        }
        //        //La palabra no ha sido encontrada...
        //        //throw new WordNotFoundException();
        //    }
        //}
    }
}
