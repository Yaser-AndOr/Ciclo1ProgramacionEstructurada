using System;

namespace G3C_Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sv = {"Monto inicial: ", "Monto final: ", "Masa de incremento anual: %"};
            Double n = 0, d = 0, m = 0, a = 0, pd = 0;
            Double[] dv = {0, 0, 0};
            Console.WriteLine("Cálculo de años en los que un préstamo aumentará su valor; ingrese a continuación" +
                "los valores de:");
            for (int x = 0; x < 3; x++)
            {
                Console.Write(sv[x]);
                dv[x] = Double.Parse(Console.ReadLine());
            }
            n = (Math.Log(dv[1]/dv[0])) / (Math.Log(1+(dv[2] * 0.01))) ;
            a = Math.Floor(n);
            m = (n - a) * 12;
            pd = Math.Floor(m);
            d = Math.Ceiling((m - pd) * 30.40167);
            Console.WriteLine("El incremento terminará en: \"" + a + "\" años, \"" + pd + "\" meses y \"" + d + "\" " +
                "días.");
            Console.ReadKey();
        }
    }
}