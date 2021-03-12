using System;

namespace Guia8_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Entrada = {"","" };
            Double[] Polares = { 0,0};
            Double RectanX = 0, RectanY = 0;
            Console.WriteLine("Ingrese las coordenadas polares en el siguiente formato: (5 , 60 ), asumiendo que el primer\n" +
                "dígito corresponde a una medida en centímetros y el segundo a un ángulo en grados.");

            Entrada = Console.ReadLine().Trim(' ', '(', ')').Split(',');
            for (int x = 0; x < 2; x++)
            {
                Polares[x] = Double.Parse(Entrada[x]);
            }
            RectanX = ConversionX(Polares[0], Polares[1]);
            RectanY = ConversionY(Polares[0], Polares[1]);
            Console.WriteLine($"Las coordenadas polares ({Polares[0]}, {Polares[1]}) tienen como correspondencia en coordenadas\n" +
                $"rectangulares las siguientes coordenadas: ({RectanX}, {RectanY})");
            Console.ReadKey();
        }
        public static double ConversionX(Double radio, Double angulo)
        {
            Double RectanX = 0;
            RectanX = radio * Math.Cos(angulo * Math.PI / 180);
            RectanX = Math.Truncate(RectanX * 100) / 100;
            return RectanX;
        }
        public static double ConversionY(Double radio, Double angulo)
        {
            Double RectanY = 0;
            RectanY = radio * Math.Sin(angulo * Math.PI / 180);
            RectanY = Math.Truncate(RectanY * 100) / 100;
            return RectanY;
        }
    }
}
