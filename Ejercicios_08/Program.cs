using System;

namespace Ejercicios_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool flag;
            string triangulo = "";
            string lineasTriangulo = "";

            Console.WriteLine("Ingrese altura para el triangulo: ");
            flag = int.TryParse(Console.ReadLine(),out numero);

            while(!flag || numero <0)
            {
                Console.WriteLine("Error! reingrese altura para el triangulo: ");
                flag = int.TryParse(Console.ReadLine(), out numero);
            }
            /*
             *0 + 1 = 1
             *1 + 2 = 3
             *2 + 3 = 5
             *3 + 4 = 7
             *4 + 5 = 9
             */

            for(int i=0; i<numero; i++)
            {
                //Console.WriteLine("{0}",i+i+1);
                for (int j=0; j<i+i+1; j++)
                {
                    lineasTriangulo = lineasTriangulo + "*";
                }

                triangulo = triangulo + lineasTriangulo + "\n";
                //Tambien funciona asi
                //Console.WriteLine(lineasTriangulo);
                lineasTriangulo = "";
            }
            Console.WriteLine(triangulo);

        }
    }
}
