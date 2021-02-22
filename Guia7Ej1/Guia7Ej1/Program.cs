using System;

namespace Guia7Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            String rl = "";
            Double Dt = 0, Rt = 0, Y = 0;
            int band = 0;
            do
            {
                Console.Clear();
                Console.Title = "Menú de operaciones";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("                              Menú");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[a] Seno de X     [b] Coseno de X     [c] Tangente de X     [d] Raíz cuadrade de X\n" +
                    "[e] Potencia de Y^X     [f] Verificar si X es par o impar     [g] Salir del programa");
                rl = Console.ReadLine();
                if (rl != "g")
                {
                    Console.WriteLine("Ingrese el dato a procesar");
                    do
                    {
                        try
                        {
                            Dt = Double.Parse(Console.ReadLine());
                            band = 1;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ingrese un dato numérico");
                        }
                    } while (band == 0);
                }
                switch (rl)
                {
                    case "a":
                        Rt = Math.Sin(Dt);
                        Console.WriteLine("El Seno de \"" + Dt + "\" es igual a: " + Rt);
                        band = 0;
                        break;
                    case "b":
                        Rt = Math.Cos(Dt);
                        Console.WriteLine("El Coseno de \"" + Dt + "\" es igual a: " + Rt);
                        band = 0;
                        break;
                    case "c":
                        Rt = Math.Tan(Dt);
                        Console.WriteLine("La Tangente de \"" + Dt + "\" es igual a: " + Rt);
                        band = 0;
                        break;
                    case "d":
                        Rt = Math.Sqrt(Dt);
                        Console.WriteLine("La raíz cuadrada de \"" + Dt + "\" es igual a: " + Rt);
                        band = 0;
                        break;
                    case "e":
                        Console.WriteLine("Ingrese el dato \"Y\" a elavar a la " + Dt + " potencia");
                        Y = Double.Parse(Console.ReadLine());
                        Rt = Math.Pow(Y, Dt);
                        Console.WriteLine("La potencia \"" + Dt + "\" del dato \"" + Y + "\" es igual a: " + Rt);
                        band = 0;
                        break;
                    case "f":
                        if (Dt % 2 == 0)
                        {
                            Console.WriteLine("El numero\"" + Dt + "\" es par.");
                        }
                        else
                        {
                            Console.WriteLine("El numero\"" + Dt + "\" es impar.");
                        }
                        band = 0;
                        break;
                    case "g":
                        Console.WriteLine("Gracias por usar este servicio :D");
                        band = 1;
                        break;
                    default:
                        band = 0;
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            } while (band == 0);
        }
    }
}
