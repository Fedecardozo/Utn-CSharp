using System;

namespace Ejer_clase2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
             * Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.*/

            /* PUNNTO 1
            int numero;
            int min = 100;
            int max = 0;

            Console.WriteLine("Ingrese 10 numeros: ");
            
            for(int i=0; i<10; i++)
            {
                numero = int.Parse(Console.ReadLine());

                if(Validador.Validar(numero,-100,100))
                {
                    if(max <= numero)
                    {
                        max = numero;
                    }
                    if(min >= numero)
                    {
                        min = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }

            }

            Console.WriteLine("Numero maximo:{0} \nNumero minimo:{1} ",max,min);*/

            // PUNTO 2

            int acumulador = 0;
            int numero;
            bool continuar = true;
            bool isNumero = true;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                isNumero = int.TryParse(Console.ReadLine(), out numero);

                while (!isNumero)
                {
                    Console.WriteLine("ERROR! reingrese nuevamente: ");
                    isNumero = int.TryParse(Console.ReadLine(), out numero);
                }

                acumulador += numero;

                continuar = Validador.ValidarRespuesta("Desea continuar? SI - NO: ");

            } while (continuar);

            Console.WriteLine("TOTAL SUMADO: {0}",acumulador);
        }
    }
}
