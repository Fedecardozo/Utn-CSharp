using System;
using MiBiblioteca;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear 5 temperas:
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


            #region Ejercicio Parte 1
            /*Comparar (temperas):
            1) == 2)
            1) == 3)
            1) == 4)
            1) == null
            null == 1)*/

            /*
            Console.WriteLine("*** Comparacion de temeras ***\n");
            Console.WriteLine(temperas[0] == temperas[1]);
            Console.WriteLine(temperas[0] == temperas[2]);
            Console.WriteLine(temperas[0] == temperas[3]);
            Console.WriteLine(temperas[0] == null);
            Console.WriteLine(null == temperas[0]);*/

            /*Sumar (temperas):
            1) + 2)
            1) + 3)
            1) + 4)
            1) + null*/

            /*Console.WriteLine("\n*** Sumas ***");

            Tempera aux;

            aux = temperas[0] + temperas[1];
            Console.WriteLine("1) " + (int)aux);
            aux = temperas[0] + temperas[2];
            Console.WriteLine("2) " + (int)aux);
            aux = temperas[0] + temperas[3];
            Console.WriteLine("3) " + (int)aux);
            aux = temperas[0] + temperas[4];
            Console.WriteLine("4) " + (int)aux);*/



            /*Sumar (temperas):
            1) + 20
            2) + 30*/

            /*Console.WriteLine("Sumar temperas por cantidad");
            aux = (temperas[0] + 20);
            Console.WriteLine("1) " +(int)aux);
            aux = (temperas[0] + 30);
            Console.WriteLine("2) " +(int)aux);*/


            #endregion

            Paleta paletinia = 3;

            Console.WriteLine("\n\n\t**** Ejercicio 4 Paleta ****");

            Console.WriteLine("\nComparacion de la paleta con la tempera 1:");
            Console.WriteLine("\nTiene que ser Falso: " + (paletinia == temperas[0]));

            Console.WriteLine("\nSuma de la paleta con las tempera:");
            Console.WriteLine("1)Aca se tiene que agregar a la paleta\n" + (string)(paletinia + temperas[0]));
            Console.WriteLine("2)Aca se tiene que agregar a la paleta\n" + (string)(paletinia + temperas[1]));
            Console.WriteLine("3)Aca se tiene que acumular a la paleta Red 75\n" + (string)(paletinia + temperas[2]));
            Console.WriteLine("4)Aca se tiene que agregar a la paleta\n" + (string)(paletinia + temperas[3]));
            Console.WriteLine("5)Aca no tiene que hacer nada\n" + (string)(paletinia + temperas[4]));

            Tempera nueva = new Tempera(ConsoleColor.Red,"Alba",50);
            Console.WriteLine("Cantidad tempera[0]" + Tempera.Mostrar(temperas[0]));
            Console.WriteLine("1)Aca se tiene que restar a la paleta 25 \n" + (string)(paletinia - nueva));
            Console.WriteLine("2)Aca se tiene que restar a la paleta 0 \n" + (string)(paletinia - temperas[1]));
            Console.WriteLine("5)Aca no hace nada " +(string)(paletinia - temperas[4]));

            Console.WriteLine("\n\nCreo nueva paleta");
            Paleta nuevaPaleta = 2;

            Console.WriteLine("5)Aca se tiene que agregar a la nueva paleta\n" + (string)(nuevaPaleta + temperas[4]));
            Console.WriteLine("4)Aca se tiene que agregar a la nueva paleta\n" + (string)(nuevaPaleta + temperas[3]));
            Console.WriteLine("3)Aca no tiene que hacer nada\n" + (string)(nuevaPaleta + temperas[2]));
            Console.WriteLine("2)Aca no tiene que hacer nada\n" + (string)(nuevaPaleta + temperas[1]));

            Console.WriteLine("\n\t SUMA DE 2 PALETAS");
            Console.WriteLine((string)(paletinia + nuevaPaleta));

        }
    }
}
