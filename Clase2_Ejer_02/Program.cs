using System;

namespace Clase2_Ejer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string msj;
            //EJEMPLO 1
            /*Sello.mensaje = "hola mundo";
            msj = Sello.Imprimir();//retorna string

            Console.WriteLine(msj);*/
            
            /* EJEMPLO 2
            Sello.Borrar();
            msj = Sello.Imprimir();//retorna string

            Console.WriteLine(msj);*/

            Sello.mensaje = "hola mundo C#";
            Sello.color = ConsoleColor.Red;

            //Sello.ArmarFormatoMensaje();
            Sello.ImprimirEnColor();
            msj = Sello.Imprimir();//retorna string
            Console.WriteLine(msj);



        }
    }
}
