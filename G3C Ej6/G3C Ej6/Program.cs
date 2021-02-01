using System;
using System.Linq;

namespace G3C_Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            String iw = "";
            String[] rw = { "0" };
            Double rv = 0;
            int cu = -1;
            String wo = rw.Last();
            Double vn = 0, uv = 1, rf = 0;
            Console.WriteLine("Resolución del promedio y desviación típca en base a 4 datos brindados por el usuario");
            do
            {
                Console.WriteLine("Ingrese los 4 datos a procesar, recuerde siempre separar uno del otro con una coma \",\".");
                iw = Console.ReadLine();
                rw = iw.Trim(' ').Split(',');
                foreach (var ci in rw)
                {
                    cu += 1;
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
                        }
                        else
                        {
                            uv = Double.Parse(rw.Last());
                        }
                        vn = Double.Parse(rw[cu]);
                    }
                    if (cu > 2) { break; }
                }
                if (cu > -1) { break; }
            } while ((cu < 3) && (vn != uv));
            for (int x = 0; x <= cu; x++)
            {
                rv = rv + (Double.Parse(rw[x]));
            }
            rv = rv / (cu + 1);
            for (int x = 0; x <= cu; x++)
            {
                rf = rf + Math.Pow(((Double.Parse(rw[x])) - rv), 2);
            }
            rf = Math.Sqrt((rf / (cu + 1)));
            Console.Write("Teniendo en cuenta los datos:");
            for (int x = 0; x <= cu; x++)
            {
                if (x == (cu - 1))
                {
                    Console.Write(" \"" + rw[x].Trim() + "\" y ");
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
            Console.WriteLine("el promedio es: \"" + rv + "\" y la desviación típica es: \"" + rf + "\".");
            Console.ReadKey();
        }
    }
}
