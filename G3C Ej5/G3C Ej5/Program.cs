using System;
using System.Linq;

namespace G3C_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            String iw = "";
            String[] rw = {"0"};
            int cu = -1;
            String wo = rw.Last();
            Double vn = 0, uv = 1, rf = 0;
            Console.WriteLine("Resolución de la media armónica.");
            do
            {
                Console.WriteLine("Ingrese los datos a procesar, recuerde siempre separar uno del otro con una coma \",\".");
                iw = Console.ReadLine();
                rw = iw.Trim(' ').Split(',');
                foreach (var ci in rw)
                {
                    cu++;
                    if ((rw[cu].Trim(' ')) == "")
                    {
                        if (rw.Last() == "")
                        {
                            wo = "1";
                        }
                        uv = 1;
                        vn = 0;
                        Console.WriteLine("Error, uno o más valores son nulos;");
                        cu = -1;
                        break;
                    }
                    else
                    {
                        if (rw.Last() == "")
                        {
                            wo = "1";
                        } else
                        {
                            uv = Double.Parse(rw.Last());
                        }
                        vn = Double.Parse(rw[cu]);
                        if ( (vn == 0) || ((rw.Last()).Equals('0')) )
                        {
                            Console.WriteLine("Error, uno o más valores son iguales a 0;");
                            uv = 1;
                            vn = 0;
                            cu = -1;
                            wo = "1";
                            break;
                        }
                    }
                }
            } while (vn != uv);
            for (int x = 0; x <= cu; x++)
            {
                rf = rf + (1 / (Double.Parse(rw[x])));
            }
            rf = (cu + 1) / rf;
            Console.Write("El resultado de la operación en la que tenemos como datos:");
            for (int x = 0; x <= cu; x++)
            {
                if (x == (cu - 1))
                {
                    Console.Write(" \"" + rw[x].Trim() + "\" y");
                }
                else if (x == cu)
                {
                    Console.Write(" \"" + rw[x].Trim() + "\" ");
                }
                else
                {
                    Console.Write(" \"" + rw[x].Trim() + "\",");
                }
            }
            Console.WriteLine("es: \"" + rf + "\".");   
            Console.ReadKey();

        }
    }
}