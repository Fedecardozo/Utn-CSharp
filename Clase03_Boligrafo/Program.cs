using System;
using MiBiblioteca;

namespace Clase03_Boligrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliAzul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50,ConsoleColor.Red);

            string pinto;

            boliAzul.Pintar(3, out pinto);

            Console.ForegroundColor = boliAzul.GetColor();

            Console.WriteLine(pinto);

            boliAzul.Recargar();
            

            Console.WriteLine("Tinta= {0} \nColor{1}", boliAzul.GetColor(), boliAzul.GetTinta());

            Console.WriteLine("\n**********************************************\n");

            Console.ForegroundColor = boliRojo.GetColor();

            boliRojo.Pintar(5, out pinto);

            Console.WriteLine(pinto);
            
            boliRojo.Recargar();
            
            Console.WriteLine("Tinta= {0} \nColor{1}", boliRojo.GetColor(), boliRojo.GetTinta());

        }
    }
}
