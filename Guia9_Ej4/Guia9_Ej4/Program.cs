using System;
using System.Linq;

namespace Guia9_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            String meses = "";
            int[] ventas = new int[9];
            int max = ventas[0], min = ventas[0], sumatoria = 0, promedio = 0, menores = 0;
            for (int x = 0; x < 9; x++)
            {
                Console.Write($"Ventas del {(x+1)} mes: ");
                ventas[x] = int.Parse(Console.ReadLine());
                sumatoria += ventas[x];
            }
            promedio = sumatoria / 9;
            for (int x = 0; x<9;x++)
            {
                if (ventas[x] < promedio)
                {
                    meses += ($"{(x+1)}, ");
                    menores++;
                }
            }
            Console.WriteLine($"\nEl mayor ingreso fue de: {ventas.Max()}\n" +
                $"El menor ingreso fue de: {ventas.Min()}\n" +
                $"El promedio de ventas es de: {promedio}\n" +
                $"Hay {menores} meses que vendieron menos que el promedio \n" +
                $"Los meses con menor ingreso que el promedio son: {meses}");
            Console.ReadKey();
        }
    }
}
