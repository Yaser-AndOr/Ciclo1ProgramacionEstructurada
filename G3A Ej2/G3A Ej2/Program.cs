using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3A_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            string iw = "";
            string[] rw;
            Double b;
            Double h;
            Double rf;
            int cu = -1;
            Console.Write("Calculadora del área de un triángulo, teniendo en cuenta su base y su altura\n" +
                "Indicaciones: \n" +
                "Ingrese los valores de la base y la altura en ese orden. \n" +
                "Separe ambos valores por una coma. \n" +
                "b, h: ");
            iw = Console.ReadLine();
            rw = iw.Trim(' ').Split(',');
            foreach (var ci in rw)
            {
                cu++;
            }
            b = Double.Parse(rw[cu - 1]);
            h = Double.Parse(rw[cu]);
            rf = ((b * h) / 2);
            Console.WriteLine("El área del triángulo con base \"" + b + "\" " +
                "y altura \"" + h + "\" es: \"" + rf + "\".");
            Console.ReadKey();
        }
    }
}
