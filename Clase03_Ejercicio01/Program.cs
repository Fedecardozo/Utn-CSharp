using System;
using MiBiblioteca;

namespace Clase03_Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(10555,"Federico Cardozo");

            Console.WriteLine("Inicio " + cuenta.Mostrar());
            
            cuenta.Ingresar(5000);

            Console.WriteLine("Ingreso 5000: \n" + cuenta.Mostrar());

            cuenta.Retirar(10000);

            Console.WriteLine("Retiro 10000: \n" + cuenta.Mostrar());

            cuenta.Retirar(8000);

            Console.WriteLine("Saldo negativo: \n" + cuenta.Mostrar());

        }
    }
}
