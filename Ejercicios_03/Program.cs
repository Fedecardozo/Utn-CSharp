using System;

namespace Ejercicios_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.*/

            int numero;
            int opcion;
            int contador = 0;
            bool salir = false;


            do
            {

                Console.WriteLine("Ingrese numero: ");
                //numero = int.Parse(Console.ReadLine());
                bool flag = int.TryParse(Console.ReadLine(), out numero);
                
                while(!flag)
                {
                    Console.WriteLine("ERROR. Ingrese un numero");
                    flag = int.TryParse(Console.ReadLine(), out numero);                 
                }

                if (flag)
                {
                    for(int i = 1; i<=numero; i++)
                    {
                        contador = 0;
                        for(int j = 2; j<=numero; j++)
                        {
                            //Console.WriteLine("Los numeros primos son: {0},{1}", i,j);
                            if(i % j == 0)
                            {
                                contador++;
                            }
                            
                        }

                        if (contador == 1)
                        {
                            Console.WriteLine("Los numeros primos son: {0}", i);
                        }
                    }
                }

                Console.WriteLine("\n*** Opciones *** \n1-Continuar \n2-Salir \nIngrese opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    salir = false;
                }
                else
                {
                    salir = true;
                }

            } while(!salir);   

            
        }
    }
}
