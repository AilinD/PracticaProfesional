using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public static class LanguageManager
    {
        public static string Translate(string word)
        {
            try
            {
                return DAL.LanguageDAL.Translate(word);
            }
            catch (WordNotFoundException ex)
            {
                DAL.LanguageDAL.Add(word, String.Empty, "DefaultCulture");
                throw;
            }
        }
    }
}
