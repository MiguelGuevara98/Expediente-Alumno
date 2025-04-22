using System;

namespace actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");

            Console.Write("Nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            string edad = Console.ReadLine();

            Console.Write("Fecha de Nacimiento (dd/mm/aaaa): ");
            string fechaNacimiento = Console.ReadLine();

            Console.Write("Carrera a la que desea ingresar: ");
            string carrera = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Gracias {nombre} por formar parte de UMI/Universidad Coppel, Bienvenido a la carrera {carrera}.");
            Console.WriteLine("\nDatos ingresados:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Fecha de Nacimiento: {fechaNacimiento}");
            Console.WriteLine($"Carrera: {carrera}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
