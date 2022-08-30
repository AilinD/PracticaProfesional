using ServiceLayer.Servicios.Criptografía;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite una palabra");

            string opcion = "";

            opcion = Console.ReadLine();

            Console.WriteLine("Palabra enviada");

            string v =Cryptografia.Hash(opcion);

            Console.WriteLine("Palabra encriptada : {0}",v);

            string desenc = Cryptografia.DecryptString(v,opcion);

            Console.WriteLine("Palabra Desencriptada: {0}",desenc);

            Console.ReadKey();


        }
    }
}
