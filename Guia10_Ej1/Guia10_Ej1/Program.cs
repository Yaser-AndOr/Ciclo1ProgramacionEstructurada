using System;

namespace Guia10_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Filas = 0, Columnas = 0, neg = 0, pos = 0, zero = 0, max = 0;
            String[] zeros, negs, poss;
            Console.Write("Escriba la cantidad de filas de la matriz: ");
            Filas = int.Parse(Console.ReadLine());
            Console.Write("\nEscriba la cantidad de columnas de la matriz: ");
            Columnas = int.Parse(Console.ReadLine());
            Console.Clear();
            int[,] matriz = new int[Filas, Columnas];
            max = Filas * Columnas;
            zeros = new String[max];
            negs = new String[max];
            poss = new String[max];
            for (int x = 0; x < Filas; x++)
            {
                for (int y = 0; y < Columnas; y++)
                {
                    Console.Write($"Ingrese el valor [{x + 1}, {y + 1}]: ");
                    matriz[x, y] = int.Parse(Console.ReadLine());
                    if (matriz[x, y] == 0)
                    {
                        zeros[zero] = $"[{x + 1}, {y + 1}]";
                        zero++;
                    }
                    else if (matriz[x, y] > 0)
                    {
                        poss[pos] = $"[{x + 1}, {y + 1}]";
                        pos++;
                    }
                    else if (matriz[x, y] < 0)
                    {
                        negs[neg] = $"[{x + 1}, {y + 1}]";
                        neg++;
                    }
                }
            }
            Console.Clear();
            Console.Write($"Hay {zero} números con valor \"0\", en las posiciones: ");
            for (int x = 0; x < zero; x++)
            {
                if (x == (zero - 1))
                {
                    Console.WriteLine($"{zeros[x]}.");
                }
                else
                {
                    Console.Write($"{zeros[x]}, ");
                }
            }
            Console.Write($"\nHay {neg} números con valor negativo, en las posiciones: ");
            for (int x = 0; x < neg; x++)
            {
                if (x == (neg - 1))
                {
                    Console.WriteLine($"{negs[x]}.");
                }
                else
                {
                    Console.Write($"{negs[x]}, ");
                }
            }
            Console.Write($"\nHay {pos} números con valor positivos, en las posiciones: ");
            for (int x = 0; x < pos; x++)
            {
                if (x == (pos - 1))
                {
                    Console.WriteLine($"{poss[x]}.");
                }
                else
                {
                    Console.Write($"{poss[x]}, ");
                }
            }
            Console.ReadKey();
        }
    }
}