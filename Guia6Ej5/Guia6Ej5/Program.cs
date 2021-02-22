using System;

namespace Guia6Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Impresión de los números del 1 al 30, exceptuando el 25, presione cualquier tecla para continuar.");
            Console.ReadKey();
            for (int x = 1; x < 31; x++)
            {
                if (x < 30)
                {
                    if (x != 25)
                    Console.Write(x + ", ");
                } else if (x == 30)
                {
                    Console.Write(x + ". \n" +
                        "Presone cualquier tecla para salir");
                }
            }
            Console.ReadKey();
        }
    }
}
