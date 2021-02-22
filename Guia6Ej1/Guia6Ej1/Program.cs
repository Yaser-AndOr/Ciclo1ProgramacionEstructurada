using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Double entrada = 0, multiplo = 0;
            Console.WriteLine("Mostrar la tabla de multiplicar de un número dado por el usuario \n" +
                "Escriba el número a procesar");
            entrada = Double.Parse(Console.ReadLine());
            for (multiplo = 1; multiplo <= 10; multiplo++)
            {
                Console.WriteLine(entrada + " x " + multiplo + " = " + (entrada * multiplo));
            }
            Console.ReadKey();
        }
    }
}
