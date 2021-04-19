using System;

class Program
{
    struct datoscancion
    {
        public int segundos, KB;
        public String titulo, nombre;
    }
    struct Cancionesa
    {
        public String nombre;
        public datoscancion cancion;
    }
    static void Main(string[] args)
    {
        ConsoleKeyInfo ltr;
        Cancionesa Canciones = new Cancionesa();
        do
        {
            Console.Title = "Ejemplo4 de estructuras anidadas";
            //Entrada de datos
            Console.Write("Ingrese Nombre del Artista: ");
            Canciones.nombre = Console.ReadLine();
            Console.Write("Titulo: ");
            Canciones.cancion.titulo = Console.ReadLine();
            Console.Write("Duracion (en segundos): ");
            //Accedemos a miembros de otra estructura
            Canciones.cancion.segundos = int.Parse(Console.ReadLine());
            Console.Write("Tamaño (KB): ");
            Canciones.cancion.KB = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"" +
                $"Mostrando datos: Artista:  {Canciones.nombre}\n" +
                $"Titulo:  {Canciones.cancion.titulo}\n" +
                $"Duracion: {Canciones.cancion.segundos} segundos\n" +
                $"Tamaño: {Canciones.cancion.KB} KB" +
                $"\n¿Desea continuar ingresando? s/n");
            ltr = Console.ReadKey();
            Console.Clear();
        } while (ltr.Key != ConsoleKey.N);
        Console.WriteLine("Pase un buen día.");
        Console.ReadKey();
    }
}