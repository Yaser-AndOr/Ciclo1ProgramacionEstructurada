using System;
using System.Linq;

namespace Guia10_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Filas = 0, Columnas = 0, max = 0, min = 0, ints = 0;
            int[] matriz;
            Console.Write("Escriba la cantidad de filas de la matriz: ");
            Filas = int.Parse(Console.ReadLine());
            Console.Write("\nEscriba la cantidad de columnas de la matriz: ");
            Columnas = int.Parse(Console.ReadLine());
            ints = Filas * Columnas;
            matriz = new int[ints];
            for (int x = 0; x < Filas; x++)
            {
                for (int y = 0; y < Columnas; y++)
                {
                    Console.Write($"Ingrese el valor [{x + 1}, {y + 1}]: ");
                    matriz[y] = int.Parse(Console.ReadLine());
                 }
            }
            max = matriz.Max();
            min = matriz.Min();
            Console.Clear();
            Console.WriteLine($"" +
                $"El mayor número de la matriz es: {max}\n" +
                $"El mayor número de la matriz es: {min}");
            Console.ReadKey();
        }
    }
}