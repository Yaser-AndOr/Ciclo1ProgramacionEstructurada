using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia7Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num = 0;
            do
            {
                if (num < 1 || num > 15 )
                {
                    Console.WriteLine("Ingrese un numero del 1 al 15");
                }
                num = Double.Parse(Console.ReadLine());
            } while (num > 15 || num < 1);
            for (int x = 0; x < num; x++)
            {
                Console.Write("* ");
            }
            Console.ReadKey();
        }
    }
}
