using System;
using MiBiblioteca;

namespace Clase03_Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona();
            Persona persona3 = new Persona();

            //Persona 1 por default

            //Persona 2
            persona2.Dni = 41623988;
            persona2.FechaNacimiento = new DateTime(1998,11,28);
            persona2.Nombre = "Claribelcita";

            //Persona 3
            persona3.Dni = 38853892;
            persona3.FechaNacimiento = new DateTime(2010,3,5);
            persona3.Nombre = "El Flaco";

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad()+"\n");

            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad() + "\n");

            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());

        }
    }
}
