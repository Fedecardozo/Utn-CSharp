using System;

namespace Ejercicios_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool flag;
            int len;
            string triangulo = "";
            string lineasTriangulo = "";
            string espacio = "";

            Console.WriteLine("Ingrese altura para el triangulo: ");
            flag = int.TryParse(Console.ReadLine(), out numero);

            while (!flag || numero < 0)
            {
                Console.WriteLine("Error! reingrese altura para el triangulo: ");
                flag = int.TryParse(Console.ReadLine(), out numero);
            }

            for (int i = 0; i < numero; i++)
            {
                len = i + i + 1;
                for (int j = 0; j < len; j++)
                {
                    
                    lineasTriangulo = lineasTriangulo + "*";
                }

                for(int s = numero - i; s>0; s--)
                {
                    espacio = espacio + " ";
                }

                triangulo = triangulo + "\t"+ espacio + lineasTriangulo + "\n";
                lineasTriangulo = "";
                espacio = "";
            }
            Console.WriteLine(triangulo);
        }
    }
}
