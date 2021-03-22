using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantEmpl = 0, sldmnr = 0, sldmyr = 0;
            Double[] sueldo;
            Console.WriteLine("Ingrese el número de empleados");
            cantEmpl = int.Parse(Console.ReadLine());
            sueldo = new Double[cantEmpl];
            for (int x = 0; x < cantEmpl; x++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el sueldo del empleado {(x + 1)} (entre 100 a 500)");
                    sueldo[x] = Double.Parse(Console.ReadLine());
                    if (sueldo[x] < 100 || sueldo[x] > 500)
                       Console.WriteLine("Error, valor de sueldo inválido");
                }
                while (sueldo[x] < 100 || sueldo[x] > 500);
                if (sueldo[x] >= 100 && sueldo[x] <= 300)
                    sldmnr++;
                if (sueldo[x] >= 350 && sueldo[x] <= 500)
                    sldmyr++;
            }
            Console.WriteLine($"Hay {sldmnr} empleados que cobran un sueldo que oscila entre $100 y $300\n" +
                $"Hay {sldmyr} empleados que cobran un sueldo mayor a $350");
            Console.ReadKey();
        }
    }
}
