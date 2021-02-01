using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3C_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            String iw = "";
            Double co, di, rf;
            Console.Write("Ingrese el precio del producto: $");
            co = Double.Parse(Console.ReadLine());
            do {
                Console.Write("Ingrese la cantidad de dinero con la que pagó el cliente: $");
                di = Double.Parse(Console.ReadLine());
                if (di < co)
                {
                    Console.WriteLine("Error, el costo del producto es mayor que el dinero ingresado por una" +
                        "diferencia de $" + (co - di) + ".");
                }
            } while (co > di);
            rf = di - co;
            Console.WriteLine("El cambio para el cliente es de: $" + rf + ", sobre un producto cuyo costo asciende" +
                " a: $" + co + ", habiendo el cliente entregado: $" + di + ".");
            Console.ReadKey();
        }
    }
}
