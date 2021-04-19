using System;
using Procedimientos;

namespace Guia10_Ej3
{
    class Principal
    {
        static void Main(string[] args)
        {
            int[,] cuatroportreh = new int[4, 3];
            int prom = 0;
            Procesos proc = new Procesos();
            Console.WriteLine("Llene una matriz 4x3 con números enteros");
            cuatroportreh = proc.Matriz();
            prom = proc.Promedio(cuatroportreh);
            Console.Clear();
            Console.WriteLine($"El promedio de la matriz es igual a {prom}");
            Console.ReadKey();
        }
    }
}
