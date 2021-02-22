using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia7Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            Console.WriteLine("Ingrese 2 numeros enteros , el programa se encargará de imprimir los numeros pares que hay\n" +
                " entre estos 2, siempre y cuando el primer numero sea menor que el segundo.");
            do
            {
                if (n1 > n2)
                {
                    Console.WriteLine("Error, el primer numero debe ser menor que el prmero \n");
                }
                try
                {
                    Console.WriteLine("Ingrese el primer numero");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = int.Parse(Console.ReadLine());
                } catch (FormatException)
                {
                    Console.WriteLine("Escribe un puto numero, pedazo de pendejete");
                }

                } while (n1 > n2);
            if ((n1 % 2 == 0) == false)
            {
                n1++;
                Console.Write(n1 + ", ");
            }
            for (int x = n1; x < (n2 - 2); x+=2)
            {
                n1 += 2;
                Console.Write(n1 + ", ");
            }
            Console.ReadKey();
        }
    }
}
