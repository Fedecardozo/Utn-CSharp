using System;

namespace Ejercicios_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo:
            el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/

            int inicio;
            int fin;
            bool flag;

            Console.WriteLine("Ingrese anio de inicio: ");
            //numero = int.Parse(Console.ReadLine());
            flag = int.TryParse(Console.ReadLine(), out inicio);

            while (!flag || inicio <= 0)
            {
                Console.WriteLine("ERROR. Ingrese nuevamente");
                flag = int.TryParse(Console.ReadLine(), out inicio);
            }

            Console.WriteLine("Ingrese anio de fin: ");
            //numero = int.Parse(Console.ReadLine());
            flag = int.TryParse(Console.ReadLine(), out fin);

            while (!flag || fin < inicio)
            {
                Console.WriteLine("ERROR. Ingrese nuevamente");
                flag = int.TryParse(Console.ReadLine(), out fin);
            }

            Console.WriteLine("Anios bisiesto: ");
            for (int i=inicio; i<fin; i++)
            {
                if(i % 4 == 0)
                {
                    Console.WriteLine("{0}",i);
                }
            }
        }
    }
}
