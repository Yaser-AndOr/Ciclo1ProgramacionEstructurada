using System;

class Program
{
    struct programa
    {
        public String Universidad;
        public String Carrera;
    }
    struct Estudiante
    {
        public String nombre;
        public int edad;
        public programa Estudios;
    }
    static void Main(string[] args)
    {
        int f = 1;
        ConsoleKeyInfo ltr;
        Estudiante student = new Estudiante();
        do
        {
            Console.Title = "Ejemplo4 de estructuras anidadas";
            //Entrada de datos
            Console.Write("Ingrese Nombre: ");
            student.nombre = Console.ReadLine();
            Console.Write("Edad: ");
            student.edad = int.Parse(Console.ReadLine());
            Console.Write("Carrera: ");
            //Accedemos a miembros de otra estructura
            student.Estudios.Carrera = Console.ReadLine();
            Console.Write("Universidad: ");
            student.Estudios.Universidad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Mostrando datos: ");
            Console.WriteLine("Estudiante: " + student.nombre);
            Console.WriteLine("Edad: " + student.edad);
            Console.WriteLine("Carrera: " + student.Estudios.Carrera);
            Console.WriteLine("Universidad: " + student.Estudios.Universidad);
            Console.WriteLine("\n¿Desea continuar ingresando? s/n");
            ltr = Console.ReadKey();
            Console.Clear();
        } while (ltr.Key != ConsoleKey.N) ;
        Console.WriteLine("Pase un buen día.");
        Console.ReadKey();
    }
}