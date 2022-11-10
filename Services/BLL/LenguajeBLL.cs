//using Services.DAL.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Services.BLL
//{
//    public class LenguajeBLL
//    {


//        /// <summary>
//        /// Repositorio de lenguajes.
//        /// </summary>
//        readonly static ILenguajeRepository lengrepo;


//        /// <summary>
//        /// Lenguajes cargados y listos para ser utilizados.
//        /// </summary>
//        static Dictionary<string, Dictionary<string, string>> lenguajes;


//        /// <summary>
//        /// Lenguajes soportados.
//        /// </summary>
//        static Dictionary<string, string> lenguajessoportados;




//        /// <summary>
//        /// Guarda un archivo de idioma en el archivo correspondiente al lenguaje especificado.
//        /// </summary>
//        /// <param name="shortname"></param>
//        /// <param name="lang"></param>
//        public static void GuardarLenguajeArch(string shortname, Dictionary<string, string> leng)
//        {
//            lengrepo.WriteLanguageFile(shortname, leng);
//        }


//        public void Inicio()
//        {
//            lenguajessoportados = new Dictionary<string, string>();

//            lenguajes = new Dictionary<string, Dictionary<string, string>>();

//            //Dictionary<string, string> _loadedlanguages = lengrepo.GetSupportedLanguages();

//            Dictionary<string, string> item = new Dictionary<string, string>();

//            foreach (var supplang in _loadedlanguages)
//            {
//                item = new Dictionary<string, string>(lengrepo.GetArchivoLenguaje(supplang.Key));

//                if (item.Count >= 1)
//                {
//                    lenguajes.Add(supplang.Key, item);
//                    //supportedlanguages.Add(supplang.Key, supplang.Value);
//                }
//            }
//        }
//    }
//}
