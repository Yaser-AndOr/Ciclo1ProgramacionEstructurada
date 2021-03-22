using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9_Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Nombres = new String[5];
            int[] Edades = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"Ingrese el {(x+1)}° nombre");
                Nombres[x] = Console.ReadLine();
                Console.WriteLine($"Ingrese la edad de {Nombres[x]}");
                Edades[x] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x < 5; x++)
            {
                if (Edades[x] >= 18)
                    Console.WriteLine($"{Nombres[x]} es mayor de edad.");
            }
            Console.ReadKey();
        }
    }
}
