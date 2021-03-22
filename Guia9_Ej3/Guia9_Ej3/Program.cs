using System;

namespace Guia9_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            var azar = new Random();
            var arreglo = new byte[20];
            byte prueba = 0, valid = 0;
            azar.NextBytes(arreglo);
            Console.WriteLine("Ruleta de la suerte, ingresa un número y descubre si el programa lo tiene");
            prueba = byte.Parse(Console.ReadLine());
            for (int x = 0; x < 20; x++)
            {
                if (prueba == arreglo[x])
                {
                    Console.WriteLine($"El número coincide con un número que se encentra \n" +
                        $"en la posición {(x+1)} del arreglo");
                    valid = 1;
                }
            }
            if (valid == 0)
            {
                Console.WriteLine("Mejor suerte a la próxima...");
            }
            Console.ReadKey();
        }
    }
}
