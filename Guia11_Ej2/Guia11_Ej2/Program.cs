using System;

namespace Guia11_Ej1
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] vect = new int[10];
            int* ap;
            int pc = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.Write($"Ingrese el dato {x+1}: ");
                vect[x] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Matriz:");
            for (int x = 0; x < 10; x++)
            {
                pc = vect[x];
                ap = &pc;
                Console.WriteLine($"Numero [{x}]: {*ap}");
            }
            Console.WriteLine("Para ver la matriz ordenada presione cualquier tecla");
            Console.ReadKey();
            Console.Clear();
            for (int k = 0; k < 9; k++)
            {
                for (int f = 0; f < 9 - k; f++)
                {
                    if (vect[f] > vect[f + 1])
                    {
                        int pru;
                        pru = vect[f];
                        vect[f] = vect[f + 1];
                        vect[f + 1] = pru;
                    }
                }
            }
            Console.WriteLine("Ordenado");
            for (int x = 0; x < 10; x++)
            {
                pc = vect[x];
                ap = &pc;
                Console.WriteLine($"Numero [{x+1}]: {*ap}");
            }
            Console.WriteLine("Para salir presione cualquier tecla");
            Console.ReadKey();
        }
    }
}
