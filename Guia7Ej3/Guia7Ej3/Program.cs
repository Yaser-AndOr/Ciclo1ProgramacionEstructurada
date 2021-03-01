using System;

namespace Guia7Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            Console.WriteLine("Ingrese 2 numeros enteros , el programa se encargará de imprimir los numeros pares que hay\n" +
                " entre estos 2, siempre y cuando el primer numero sea menor que el segundo.");

            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            if ((n1 % 2 == 0) == false)
            {
                n1++;
                Console.Write(n1 + ", ");
            }
            if (n2 > n1)
            {
                for (int x = n1; x < (n2 - 2); x += 2)
                {
                    n1 += 2;
                    Console.Write(n1 + ", ");
                }
            }
            else if (n1 > n2)
            {
                for (int x = n1; x > (n2 + 2); x -= 2)
                {
                    n1 -= 2;
                    Console.Write(n1 + ", ");
                }
            }
            Console.ReadKey();
        }
    }
}