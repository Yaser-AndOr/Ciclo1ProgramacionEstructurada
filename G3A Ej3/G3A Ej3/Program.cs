using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3A_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double r;
            Double rf;
            Console.Write("Resolución de la fórmula \"(4 / 3) * (pi * r^3)\" \n" +
                "Ingrese el valor de \"r\": ");
            r = Double.Parse(Console.ReadLine());
            rf = (4 * (System.Math.Pow(r, 3)) * System.Math.PI) / 3;
            Console.WriteLine("El resultado a dicha operación, teniendo en cuenta el valor de entrada \"" +
                r + "\" es: \"" + rf + "\".");
            Console.ReadKey();
        }
    }
}
