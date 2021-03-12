using System;

namespace Guia8_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año de nacimiento, posteriormente el programa devolverá la edad");
            Edad();
            Console.ReadKey();
        }

        static void Edad()
        {
            int año = 0, actual = 0, edad = 0;
            for (int x = 0; x < 1; x = x) {
                año = int.Parse(Console.ReadLine());
                actual = int.Parse(DateTime.Today.ToString("yyyy"));
                if (año >= actual)
                {
                    Console.WriteLine("Escriba un año de nacimiento coherente");
                } else
                {
                    x = 1;
                }
            }
            edad = actual - año;
            if (edad == 1)
                Console.WriteLine($"El sujeto tiene { (edad) } año");
            if (edad > 1)
                Console.WriteLine($"El sujeto tiene { (edad) } años");
        }
    }
}
