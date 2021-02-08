using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Tot = 0, Resp = 0, Resul = 0;
            Console.WriteLine("Ingrese la cantidad de preguntas totales:");
            Tot = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de preguntas respondidas:");
            Resp = Double.Parse(Console.ReadLine());
            Resul = (Resp * 100) / Tot;
            if (Tot >= 90)
            {
                Console.WriteLine("El empleado se encuentra en el nivel máximo");
            }
            else if (Tot >= 75 && Tot < 90)
            {
                Console.WriteLine("El empleado se encuentra en el nivel medio");
            }
            else if (Tot >= 50 && Tot <75)
            {
                Console.WriteLine("El empleado se encuentra en el nivel regular");
            }
            else if (Tot < 50)
            {
                Console.WriteLine("El empleado se encuentra fuera de nivel");
            }
            Console.ReadKey();
        }
    }
}
