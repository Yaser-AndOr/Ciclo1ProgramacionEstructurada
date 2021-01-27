using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3C_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double d, s;
            Console.Write("Calculo para saber la cantidad de segundos que hay en x cantidad de días.\n" +
                "Ingrese los días a calcular: ");
            d = Double.Parse(Console.ReadLine());
            s = d * 24 * 3600;
            Console.WriteLine("En \"" + d + "\" días hay \"" + s + "\" segundos.");
            Console.ReadKey();
        }
    }
}
