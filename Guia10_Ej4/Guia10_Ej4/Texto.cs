using System;

namespace Txt
{
    class Texto
    {
        public String Ingreso(String numero)
        {
            String ingr = "";
            Console.WriteLine($"Ingrese el {numero} texo");
            ingr = Console.ReadLine();
            return ingr;
        }
        public String Estado(int validar)
        {
            String state = "";
            if (validar == 0)
                state = "iguales.";
            if (validar == 1)
                state = "diferentes, el primer texto es más largo.";
            if (validar == -1)
                state = "diferentes, el segundo texto es más largo.";
            return state;
        }
    }
}
