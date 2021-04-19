using System;

namespace Guia11_Ej1
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] vect = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int* ap;
            int pc = 0;
            for (int x = 0; x < 8; x++) {
                pc = vect[x];
                ap = &pc;
                Console.WriteLine($"Numero {vect[x]}:\n" +
                    $"Referencia: {*ap}");
            }
            Console.ReadKey();
        }
    }
}
