using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //printf(); = Console.WriteLine();
            //scanf(); = Console.ReadLine();

            string nombre;
            int edad = 24;

            Console.WriteLine("\nIngrese nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("\nSu nombre es: {0} \nMi edad es: {1}",nombre,edad);
            Console.ReadLine();
        }
    }
}
