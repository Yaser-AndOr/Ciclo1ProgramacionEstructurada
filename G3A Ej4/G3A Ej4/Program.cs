using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3A_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            String iw;
            String[] rw;
            int cu = -1;
            Double x1 = 0, y1 = 0, x2 = 0, y2 = 0, rf;
            Console.Write("Resolución de la fórmula \"(x2-x1)^2 + (y2-y1)^2\" \n" +
                "Ingrese los valores \"x1\" y \"y1\", en ese orden, y separados por una coma\n" +
                "x1, y1 : ");
            iw = Console.ReadLine();
            rw = iw.Trim(' ').Split(',');
            foreach (var ci in rw)
            {
                cu++;
            }
            x1 = Double.Parse(rw[cu - 1]);
            y1 = Double.Parse(rw[cu]);
            cu = -1;
            Console.Write("Ingrese los valores \"x2\" y \"y2\", en ese orden, y separados por una coma\n" +
                "x2, y2 : ");
            iw = Console.ReadLine();
            rw = iw.Trim(' ').Split(',');
            foreach (var ci in rw)
            {
                cu++;
            }
            x2 = Double.Parse(rw[cu - 1]);
            y2 = Double.Parse(rw[cu]);
            rf = (System.Math.Pow( (x2 - x1), 2) ) + (System.Math.Pow( (y2 - y1), 2) );
            Console.WriteLine("El resultado a dicha operación es: \"" + rf + "\".");
            Console.ReadKey(); 
        }
    }
}
