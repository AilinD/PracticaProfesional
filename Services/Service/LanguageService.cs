using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public static class LanguageService
    {
        static Dictionary<string, string> DiccionarioLenguaje = new Dictionary<string, string>();
        static LanguageService()
        {
            DiccionarioLenguaje = GetLanguageFile(ConfigurationManager.AppSettings["LanguageOptions"].ToString());
        }

        /// <summary>
        /// Busca y carga un archivo de lenguaje de formato JSON. La carpeta de busca por defecto es \locale\.
        /// </summary>
        /// <param name="Language">Nombre corto del lenguaje. Ejemplo: "es" para español, "en" para inglés.</param>
        /// <returns>Retorna un diccionario que contiene las traducciones del lenguaje indicado.</returns>
        public static Dictionary<string, string> GetLanguageFile(string Language)
        {
            try
            {
                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory().ToString() + "\\Recursos\\" + Language + ".json");

                Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(sr.ReadToEnd());

                sr.Close();

                return values;
            }
            catch (Exception ex)
            {
                return new Dictionary<string, string>();
            }
        }


        public static string Translate( string traduccion)
        {
            return DiccionarioLenguaje[traduccion];
        }
    }
}

