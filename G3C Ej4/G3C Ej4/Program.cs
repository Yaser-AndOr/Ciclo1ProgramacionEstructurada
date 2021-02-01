using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3C_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            String iw;
            String[] rw;
            Double h = 0, r = 0, rf = 0;
            Console.Write("Indicación: ingrese los datos \"h\" y \"r\", en ese orden y separados por una coma \",\"\n" +
                "Solución de la ecuación \"2*pi*r*(h+r)\", donde; \n" +
                "h, r: ");
            iw = Console.ReadLine();
            rw = iw.Trim(' ').Split(',');
            foreach (var ci in rw)
            {
                h = Double.Parse(rw[0]);
                r = Double.Parse(rw[1]);
                rf = 2 * Math.PI * r * (h + r);
            }
            Console.WriteLine("El resultado a dicha operación es: \"" + rf + "\".");
            Console.ReadKey();
        }
    }
}
