using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecturia;
namespace Guia10_Ej5
{
    class Principal
    {
        static void Main(string[] args)
        {
            String[] palabras = new String[5];
            Collect wrd = new Collect();
            for (int x = 0; x < 4; x++)
            {
                palabras[x] = wrd.Palabra(x) + " ";
            }
            palabras[4] = string.Concat(palabras[0], palabras[1], palabras[2], palabras[3]);
            Console.WriteLine(palabras[4]);
            Console.ReadKey();
        }
    }
}
