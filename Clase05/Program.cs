using System;
using MiBiblioteca;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear 4 temperas:
            1) Red-Alba-50
            2) Blue-Alba-50
            3) Red-Alba-25
            4) Black-Pinturita-50
            5) Green-Temperita-50*/

            Tempera[] temperas = new Tempera[5];
            temperas[0] = new Tempera(ConsoleColor.Red, "Alba", 50);
            temperas[1] = new Tempera(ConsoleColor.Blue, "Alba", 50);
            temperas[2] = new Tempera(ConsoleColor.Red, "Alba", 25);
            temperas[3] = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            temperas[4] = new Tempera(ConsoleColor.Green, "Temperita", 50);

            #region Comparacion temperas
            /*Comparar (temperas):
            1) == 2)
            1) == 3)
            1) == 4)
            1) == null
            null == 1)*/

            Console.WriteLine("*** Comparacion de temeras ***\n");
            Console.WriteLine(temperas[0] == temperas[1]);
            Console.WriteLine(temperas[0] == temperas[2]);
            Console.WriteLine(temperas[0] == temperas[3]);
            Console.WriteLine(temperas[0] == null);
            Console.WriteLine(null == temperas[0]);

            #endregion

            /*Sumar (temperas):
            1) + 2)
            1) + 3)
            1) + 4)
            1) + null*/

            Console.WriteLine("\n*** Sumas ***");

            Tempera aux;

            aux = temperas[0] + temperas[1];
            Console.WriteLine("1) " + (int)aux);
            aux = temperas[0] + temperas[2];
            Console.WriteLine("2) " + (int)aux);
            aux = temperas[0] + temperas[3];
            Console.WriteLine("3) " + (int)aux);
            aux = temperas[0] + temperas[4];
            Console.WriteLine("4) " + (int)aux);



            /*Sumar (temperas):
            1) + 20
            2) + 30*/
            Console.WriteLine("Sumar temperas por cantidad");
            aux = (temperas[0] + 20);
            Console.WriteLine("1) " +(int)aux);
            aux = (temperas[0] + 30);
            Console.WriteLine("2) " +(int)aux);

        }
    }
}
