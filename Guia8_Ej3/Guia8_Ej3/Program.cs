using System;

namespace Guia8_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo entrada;
            do
            {
                Console.WriteLine("" +
                    "-----------------------------------------------\n" +
                    "#                    Menú                     #\n" +
                    "#         [a] Dividir [b] Obtener cubo        #\n" +
                    "#         [c] Cálculo de IMC [d] Salir        #\n" +
                    "-----------------------------------------------");
                entrada = Console.ReadKey(true);
                switch (entrada.Key)
                {
                    case ConsoleKey.A:
                        Dividir();
                        break;
                    case ConsoleKey.B:
                        Cubo();
                        break;
                    case ConsoleKey.C:
                        IMC();
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Gracias por utilizar nuestros servicios =D");
                        break;
                    default:
                        Console.WriteLine("Ingrese una letra contemplada en el menú");
                        break;
                }
            } while (entrada.Key != ConsoleKey.D);
            Console.ReadKey();
        }
        public static void Dividir()
        {
            String[] entrada = { "", "" };
            Double x = 0, y = 0, resul = 0;
            Console.WriteLine("Esciba los números a dividir de la siguiente forma: x/y");
            entrada = Console.ReadLine().Trim(' ').Split('/');
            x = Double.Parse(entrada[0]);
            y = Double.Parse(entrada[1]);
            resul = Math.Truncate((x / y) * 100) / 100;
            Console.WriteLine($"El resultado de la división \" {x} / {y} \" es igual a: {resul}");
        }
        public static void Cubo()
        {
            Double entrada = 0, resul = 0;
            Console.WriteLine("Esciba el número a elevar al cubo");
            entrada = Double.Parse(Console.ReadLine());
            resul = Math.Truncate((Math.Pow(entrada, 3)) * 100) / 100;
            Console.WriteLine($"El cubo de {entrada} es igual a: {resul}");
        }
        public static void IMC()
        {
            String[] entrada = { "", "" };
            Double kg = 0, mt = 0, imc = 0;
            Console.WriteLine("Ingrese el peso (kg) y la altura (cm) de la siguiente forma: p,h");
            entrada = Console.ReadLine().Trim(' ').Split(',');
            kg = Double.Parse(entrada[0]);
            mt = Double.Parse(entrada[1]) / 100;
            imc = Math.Truncate((kg / (Math.Pow(mt, 2)))* 100) / 100;
            Console.WriteLine($"El paciente de peso {kg} Kg y altura {mt} m, tiene un IMC\n" +
                $"igual a : {imc}");
        }
    }
}
