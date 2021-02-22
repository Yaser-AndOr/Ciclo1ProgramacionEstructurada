using System;

namespace Guia6Ej2
{
    class Program
    {
        static void Main(string[] args)
        {

           String[] rw = { "", "", "" };
            Double l1 = 0, l2 = 0, l3 = 0;
            int band = 0, isc = 0, equ = 0, esc = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Identificador de triángulos\n" +
                "Ingrese la medida de los lados de un triángulo, el programa determinará el tipo de triángulo que es.\n" +
                "Si desea salir presione ingrese el comando \"Salir\"; si desea ver la cantidad de triángulos de cada tipo,\n" +
                "ingrese el comando \"Cantidad\"; si desea ver el tipo de triángulo con menor cantidad dentro del conjunto,\n" +
                "ingrese el comando \"Menor\"");
            do
            {
                Double[] n = { 0, 0, 0 };
                for (int x = 0; x <= 2; x++)
                {
                    Console.WriteLine("Ingrese comando o lado " + (x + 1));
                    rw[x] = Console.ReadLine().Trim();
                    if (rw[x] == "Cantidad")
                    {
                        Console.WriteLine("Hay " + equ + " triángulos equiláteros, " + isc + " triángulos isósceles y "
                             + esc + " triángulos escalenos");
                        band = 1;
                        break;
                    }
                    else if (rw[x] == "Menor")
                    {
                        if (isc < equ && isc < esc)
                        {
                            Console.WriteLine("Hay menos cantidad de isósceles");
                        }
                        else if (equ < isc && equ < esc)
                        {
                            Console.WriteLine("Hay menos cantidad de equiláteros");
                        }
                        else if (esc < equ && esc < isc)
                        {
                            Console.WriteLine("Hay menos cantidad de escalenos");
                        }
                        else
                        {
                            Console.WriteLine("No hay un tipo de triángulo con menor cantidad que los otros");
                        }
                        band = 1;
                        break;
                    }
                    else if (rw[x] == "Salir")
                    {
                        band = 2;
                        break;
                    }
                }
                if (band == 2)
                {
                    break;
                }
                if (band == 0)
                {
                    if (rw[0] == "" || rw[1] == "" || rw[2] == "")
                    {
                        Console.WriteLine("Error, uno de los lados es nulo");
                    }
                    else
                    {
                        l1 = Double.Parse(rw[0]);
                        l2 = Double.Parse(rw[1]);
                        l3 = Double.Parse(rw[2]);
                        if (l1 == l2 && l3 == l2)
                        {
                            Console.WriteLine("Se trata de un triángulo Equilatero");
                            equ++;
                        }
                        if (l1 == l2 && l3 != l2 || l1 == l3 && l1 != l2 || l3 == l2 && l1 != l2)
                        {
                            Console.WriteLine("Se trata de un triángulo Isósceles");
                            isc++;
                        }
                        if (l1 != l2 && l3 != l2 && l1 != l3)
                        {
                            Console.WriteLine("Se trata de un triángulo Escaleno");
                            esc++;
                        }
                    }
                }
                band = 0;
            }
            while (band == 0);
            Console.ReadKey();
        }
    }
}


