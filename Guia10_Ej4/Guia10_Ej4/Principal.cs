using System;
using Txt;

namespace Guia10_Ej4
{
    class Principal
    {
        static void Main(string[] args)
        {
            String[] palabras = new String[3];
            int valid = 0;
            Texto CText = new Texto();
            palabras[0] = CText.Ingreso("primer");
            palabras[1] = CText.Ingreso("segundo");
            valid = string.Compare(palabras[0], palabras[1]);
            palabras[2] = CText.Estado(valid);
            Console.WriteLine($"Los textos son {palabras[2]}");
            Console.ReadKey();
        }
    }
}
