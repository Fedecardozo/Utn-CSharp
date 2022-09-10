using System;

namespace Ejercicios_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            int numero;
            int cubo;
            int cuadrado;

            Console.WriteLine("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());

            if(numero == 0 )
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numero = int.Parse(Console.ReadLine());
            }
            else
            {
                cuadrado = (int) Math.Pow(numero,2);
                cubo = (int) Math.Pow(numero,3);

                Console.WriteLine("\nCuadrado: {0} \nCubo: {1}",cuadrado,cubo);
            }
        }
    }
}
