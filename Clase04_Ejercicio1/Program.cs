using System;
using MiBiblioteca;

namespace Clase04_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(10);

            long resultado = sumador + sumador2;

            sumador.Sumar(10,15);

            Console.WriteLine(resultado);
            Console.WriteLine(sumador | sumador2);
            Console.WriteLine("Cantidad de sumas:" + (int)sumador);
        }
    }
}
