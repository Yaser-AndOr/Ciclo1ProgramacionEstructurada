using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] medida;
            int piezas = 0, ideales = 0;
            Console.WriteLine("Ingrese la cantidad de piezas a procesar");
            piezas = int.Parse(Console.ReadLine());
            medida = new Double[piezas];
            for (int x = 0; x < piezas; x++)
            {
                Console.WriteLine($"Ingrese la medida de la pieza");
                medida[x] = Double.Parse(Console.ReadLine());
                if (medida[x] <= 1.40 && medida[x] >= 1.20)
                {
                    ideales++;
                }
            }
            Console.WriteLine($"Hay {ideales} piezas ideales.");
            Console.ReadKey();
        }
    }
}
