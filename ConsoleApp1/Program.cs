using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "prueba.txt";
            escribirArchivo(filepath);
            Console.WriteLine();
            leerarchivo(filepath);
            Console.ReadLine();
        }
        public static void escribirArchivo(string filepath)
        {
            StreamWriter escribir = new StreamWriter(filepath, true);
            string temp;
            do
            {
                Console.Write("Ingrese nombre , -1 para terminar:  ");
                temp = Console.ReadLine();

                if (temp != "-1")
                    escribir.WriteLine(temp);
            } while (temp != "-1");

            escribir.Close();
        }
        public static void leerarchivo(string filepath)
        {
            int cant = 0;
            StreamReader leer = new StreamReader(filepath);
            while (!leer.EndOfStream)
            {
                Console.WriteLine(leer.ReadLine());
                cant++;
            }
            Console.WriteLine("se tiene {0} nombres", cant);
            leer.Close();
        }
    }
}
