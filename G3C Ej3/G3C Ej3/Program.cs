using System;

namespace G3C_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double rf;
            Console.Write("Calcular el área de un triángulo equilátero teniendo en cuenta la medida de uno" +
                "de sus lados. \n" +
                "Ingresar el valor del lado: ");
            rf = (Math.Pow((Double.Parse(Console.ReadLine())), 2) * Math.Sqrt(3) ) / 4;
            Console.WriteLine("El resultado a dicha operación es: \"" + rf + "\".");
            Console.ReadKey();
        }
    }
}
