using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n = 0, mp = 0;
            int np = 0, nn = 0, m5 = 0;
            Console.WriteLine("Ingrese 10 números, el programa se encargará de evaluar cuántos son positivos, negativos,\n" +
                "múltiplos de 15, o el acumulativo de todos los múltiplos de 2.");
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese el digito " + (x + 1));
                n = Double.Parse(Console.ReadLine());
                if (n < 0)
                    nn++;
                if (n > 0)
                    np++;
                if (n % 15 == 0)
                    m5++;
                if (n % 2 == 0)
                    mp += n;
            }
            Console.WriteLine("Hay " + nn + " números negativos, " + np + "números positivos, " + m5 + " múltiplos de 15\n" +
                "y el conjunto de todos los múltiplos de 2 es: " + mp);
            Console.ReadKey();
        }
    }
}