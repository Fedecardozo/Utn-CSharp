using System;

namespace Ejer_Clase2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int numero;
            string binario;

            Console.WriteLine("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());

            binario = Conversor.ConvertirDecimalABinario(numero);
            Console.WriteLine(binario);
            Console.WriteLine("Tamaño: {0}",binario.Length);
            Console.WriteLine(binario.Substring(8,4));*/

            int numeroDecimal = Conversor.ConvertirBinarioADecimal(1011001011);
            Console.WriteLine("{0}",numeroDecimal);
        }
    }
}
