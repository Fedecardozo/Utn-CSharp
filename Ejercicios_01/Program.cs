using System;

namespace Ejercicios_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            int numero;
            int min=0;
            int max=0;
            int acumulador = 0;
            float promedio = 0;

            Console.WriteLine("Ingrese 5 numeros: ");

            for(int i=0; i<5; i++)
            {
                Console.WriteLine("N°{0}: ",i+1);
                numero = int.Parse(Console.ReadLine());

                min = numero;
                max = numero;

                if(i > 0)
                {
                    if(min < numero)
                    {
                        min = numero;
                    }
                    if (numero > max)
                    {
                        max = numero;
                    }
                }

                acumulador = acumulador + numero;
            }

            promedio = acumulador / 5;
            
            Console.WriteLine("\nEl numero mas alto es: {0} \nEl numero minimo es: {1} \n El promedio es: {2}",max,min,promedio);

            Console.ReadLine();
        }
    }
}
