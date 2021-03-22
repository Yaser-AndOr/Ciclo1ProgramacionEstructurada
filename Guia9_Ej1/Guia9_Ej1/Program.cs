using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] nota = new double[9];
            int mayor85 = 0;
            for (int x = 0; x < 9; x++) {
                Console.WriteLine($"Ingrese la nota {(x+1)}");
                nota[x] = Double.Parse(Console.ReadLine());
                if (nota[x] == 8.5)
                {
                    mayor85++;
                }
            }
            Console.WriteLine($"Hay {mayor85} notas iguales a 8.5");
            Console.ReadKey();
        }
    }
}
