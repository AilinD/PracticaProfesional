using Business.Exceptions;
using ServiceLayer.DAL.Factory;
using ServiceLayer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public static class LanguageBLL
    {
      
        public static string Translate(string word)
        {
            try
            {
                return DALFactory.LanguageRepository.Find(word);
            }
            catch (WordNotFoundException)
            {
                DALFactory.LanguageRepository.WriteNewWord(word, String.Empty);
                return word;
            }
        }
    }
}
