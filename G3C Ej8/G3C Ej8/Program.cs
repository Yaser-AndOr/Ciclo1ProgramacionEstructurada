using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3C_Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            String etl = "";
            Double dj = 0, dr = 0, dd = 0, dt = 0, pj = 0, pr = 0, pd = 0;
            Console.WriteLine("Bienvenido al sistema de ahorro de Juan, Raquel y Daniel.\n" +
                "Puede depositar a nombre de uno de los integrantes, primero ingrese un \"comando\",\n" +
                "luego, si lo que desea depositar, ingrese el nombre de Juan o de Raquel, para \n" +
                "determinar quién está depositando, por último ingrese la cantidad a depositar.\n" +
                "Lista de comandos: \"Depositar\", \"Consultar capital\", \"Salir\"");
            do
            {
                Console.WriteLine("Esperando orden.");
                etl = Console.ReadLine();
                if (etl.Trim().Equals("Depositar"))
                {
                    f = 1;
                    do
                    {
                        Console.WriteLine("¿Quién es el depositante?");
                    etl = Console.ReadLine();
                        if (etl.Trim().Equals("Juan"))
                        {
                            Console.WriteLine("Ingrese el valor, en dólares, a depositar.");
                            dj += Double.Parse(Console.ReadLine());
                            etl = "";
                            f = 0;
                        }
                        else if (etl.Trim().Equals("Raquel"))
                        {
                            Console.WriteLine("Ingrese el valor, en dólares, a depositar.");
                            dr += Double.Parse(Console.ReadLine());
                            etl = "";
                            f = 0;
                        }
                        else if (etl.Trim().Equals("Daniel"))
                        {
                            Console.WriteLine("Ingrese el valor, en soles, a depositar.");
                            dd += (Double.Parse(Console.ReadLine())) / 3.25;
                            etl = "";
                            f = 0;
                        }
                        else
                        {
                            if (f == 1)
                            {
                                Console.WriteLine("Error, el nombre ingresado no está registrado.");
                            }
                        }
                    } while (f == 1);
                }
                else if (etl.Trim().Equals("Consultar capital"))
                {
                    dt = dj + dr + dd;
                    if (dt == 0) {
                        pj = (dj * 100) / 1;
                        pr = (dr * 100) / 1;
                        pd = (dd * 100) / 1;
                    }
                    else
                    {
                        pj = (dj * 100) / dt;
                        pr = (dr * 100) / dt;
                        pd = (dd * 100) / dt;
                    }
                    Console.WriteLine("Se tiene un capital de: \"$" + dt + "\"; Juan ha aportado un \"" + pj + "%\",\n" +
                        "Raquel ha aportado un: \"" + pr + "%\", y Daniel ha aportado un: \"" + dt + "%\".");
                }
                else if (etl.Trim().Equals("Salir"))
                {
                    f = 1;
                    do
                    {
                        Console.WriteLine("¿Seguro de que quiere salir? (y/n)");
                        etl = Console.ReadLine();
                        if (etl.Trim().Equals("y"))
                        {
                            break;
                        }
                        else if (etl.Trim().Equals("n"))
                        {
                            f = 0;
                            break;
                        } else
                        {
                            Console.WriteLine("Error, ingrese un código válido.");
                        }
                    } while (f == 1);
                }
            } while (f == 0);
            Console.WriteLine("Programa terminado.");
            Console.ReadKey();
        }
    }
}
