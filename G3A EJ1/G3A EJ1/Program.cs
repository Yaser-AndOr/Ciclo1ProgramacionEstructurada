using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3A_EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double k, m, y, v;
            Console.Write("Ingrese la cantidad de kilómetros a procesar:");
            k = Double.Parse(Console.ReadLine());
            m = k * 1000;
            y = m * 1.09361;
            v = m * 1.1963;
            Console.Write("En \"" + k + "\" kilómetros hay \"" + m + "\" metros, \"" +
                y + "\" yardas y \"" + v + "\" varas.");
            Console.ReadKey();
        }
    }
}