using System;
using ExeptionPropia;

namespace ClaseExepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un numero: ");
            bool flag = ParseExeption.TryParse( Console.ReadLine(), out num);

            if(!flag)
            {
                Console.WriteLine("No es un numero!");
            }
            else
            {
                Console.WriteLine("El numero es: " + num);
            }

        }

    }
 
}
