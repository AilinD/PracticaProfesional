using ServiceLayer.DAL.Implementaciones;
using ServiceLayer.Servicios.Criptografía;
using ServiceLayer.Servicios.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPruebas
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //private string key = "";
            //Console.WriteLine("Digite una palabra");

            //string opcion = "";

            //opcion = Console.ReadLine();

            //Console.WriteLine("Palabra enviada");

            //string v =Cryptografia.Hash(opcion);

            //Console.WriteLine("Palabra encriptada : {0}",v);

            //string desenc = Hashing.DecryptString();

            //Console.WriteLine("Palabra Desencriptada: {0}",desenc);

            //Console.ReadKey();


            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            Console.WriteLine("Please enter a string for encryption");
            var str = Console.ReadLine();
            var encryptedString = Hashing.EncryptString(key, str);
            Console.WriteLine($"encrypted string = {encryptedString}");

            var decryptedString = Hashing.DecryptString(key, encryptedString);
            Console.WriteLine($"decrypted string = {decryptedString}");

            LoggerRepositorio.Current.WriteLog();
            Console.ReadKey();   
        }
    }
}
