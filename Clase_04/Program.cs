using System;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  //Crear una instancia de 'Cosa'
                //Establecer valor a sus atributos
                //Mostrar valores de los atributos*/

            Cosa Gato = new Cosa();

           /* Gato.EstablecerValor(2);
            Gato.EstablecerValor("Mini");
            Gato.EstablecerValor(new DateTime(2021,12,07));*/

            Console.WriteLine(Cosa.Mostrar(Gato));

            Console.ReadLine();

        }
    }
}
