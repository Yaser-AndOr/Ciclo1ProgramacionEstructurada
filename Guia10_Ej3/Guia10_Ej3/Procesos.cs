using System;

namespace Procedimientos
{
    class Procesos
    {
        public int[,] Matriz()
        {
            int[,] mtrz = new int[4,3];
            int f = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    do
                    {
                        f = 0;
                        try
                        {
                            Console.Write($"Introduzca el número [{x+1}, {y+1}]: ");
                            mtrz[x, y] = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ingrese un número entero");
                            f = 1;
                        }
                    } while (f == 1);
                }
            }
            return mtrz;
        }
        public int Promedio(int[,] mtrz)
        {
            int suma = 0, promediado = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    suma += mtrz[x, y];
                }
            }
            promediado = suma / 12;
            return promediado;
        }
    }
}
