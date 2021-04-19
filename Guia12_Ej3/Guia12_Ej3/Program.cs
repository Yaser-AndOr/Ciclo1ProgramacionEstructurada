using System;

class Program
{
    struct Data
    {
        public int[] Año;
        public String[] Color, Marca, Modelo, Propietario;
    }
    struct Autos
    {
        public int[] placa;
        public Data DataGen;
    }
    public static int Num(String ingr)
    {
        int x = 0;
        Console.Write(ingr);
        x = int.Parse(Console.ReadLine());
        return x;
    }
    public static String Pal(String ingr)
    {
        String x = "";
        Console.Write(ingr);
        x = Console.ReadLine();
        return x;
    }
    static void Main(string[] args)
    {
        int f = 0;
        Autos coches = new Autos();
        Console.WriteLine("¿Cuantos registros se harán?");
        f = int.Parse(Console.ReadLine());
        coches.placa = new int[f];
        coches.DataGen.Año = new int[f];
        coches.DataGen.Color = new String[f];
        coches.DataGen.Marca = new String[f];
        coches.DataGen.Modelo = new String[f];
        coches.DataGen.Propietario = new String[f];
        for (int x = 0; x < f; x++)
        {
            Console.Clear();
            coches.placa[x] = Num($"Ingrese la placa del auto {x + 1}: ");
            coches.DataGen.Color[x] = Pal("Ingrese el color del auto: ");
            coches.DataGen.Año[x] = Num("Ingrese el año del auto: ");
            coches.DataGen.Marca[x] = Pal("Ingrese la marca del auto: ");
            coches.DataGen.Modelo[x] = Pal("Ingrese el modelo del auto: ");
            coches.DataGen.Propietario[x] = Pal("Ingrese el propietario del auto: ");
        }
        Console.Clear();
        for (int x = 0; x < f; x++)
        {
            Console.WriteLine($"" +
                $"Registro {x+1}\n" +
                $"Placa: {coches.placa[x]}\n" +
                $"Color: {coches.DataGen.Color[x]}\n" +
                $"Año: {coches.DataGen.Año[x]}\n" +
                $"Marca: {coches.DataGen.Marca[x]}\n" +
                $"Modelo: {coches.DataGen.Modelo[x]}\n" +
                $"Propietario: {coches.DataGen.Propietario[x]}\n" +
                $"");
        }
        Console.WriteLine("Pase un buen día.");
        Console.ReadKey();
    }
}