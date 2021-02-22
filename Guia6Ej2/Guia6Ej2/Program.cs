using System;

namespace Guia6Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            String iw;
            String[] rw = { };
            Double p1 = 0, p2 = 0;
            int band = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Calculadora de tabla\n" +
                "Ingrese coordenadas de un plano cartesiano, el programa determinará el cuadrante en el que se encuentran.\n" +
                "El formato para ingresar las coordenadas es: \"(x,y)\"; si desea salir presione \"enter\" sin haber escrito nada.");
            do {
                Console.Write("Ingrese las coordenadas: ");
                iw = Console.ReadLine();
                rw = iw.Trim(' ', '(', ')').Split(',');
                if (rw[0] == "" || rw[1] == "")
                {
                    break;
                    band = 1;
                }
                p1 = Double.Parse(rw[0]);
                p2 = Double.Parse(rw[1]);
                if (p1 > 0)
                {
                    if (p2 > 0)
                    {
                        Console.WriteLine("El punto está en el primer cuadrante");
                    }
                    if (p2 < 0)
                    {
                        Console.WriteLine("El punto está en el cuarto cuadrante");
                    }
                    if (p2 == 0)
                    {
                        Console.WriteLine("El punto está en el origen del eje \"y\", y en \"x = " + p1 + "\".");
                    }
                }
                if (p1 < 0)
                {
                    if (p2 > 0)
                    {
                        Console.WriteLine("El punto está en el segundo cuadrante");
                    }
                    if (p2 < 0)
                    {
                        Console.WriteLine("El punto está en el tercer cuadrante");
                    }
                    if (p2 == 0)
                    {
                        Console.WriteLine("El punto está en el origen del eje \"y\", y en \"x = " + p1 + "\".");
                    }
                }
                if (p1 == 0)
                {
                    if (p2 > 0)
                    {
                        Console.WriteLine("El punto está en el origen del eje \"x\", y en \"y = " + p2 + "\".");
                    }
                    if (p2 < 0)
                    {
                        Console.WriteLine("El punto está en el origen del eje \"x\", y en \"y = " + p2 + "\".");
                    }
                    if (p2 == 0)
                    {
                        Console.WriteLine("El punto está en el origen.");
                    }
                }
            }
            while (band == 0);
            Console.ReadKey();
        }
    }
}
