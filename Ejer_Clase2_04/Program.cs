using System;

namespace Ejer_Clase2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
            El método devolverá el resultado de la operación.
            Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
            Este método devolverá true si el operando es distinto de cero.
            Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
            El usuario decidirá cuándo finalizar el programa.*/
            float resultado=0;
            int numero=0;
            int numero2=0;
            char operador= ' ';
            bool continuar = true;
            bool isNumero = true;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                isNumero = int.TryParse(Console.ReadLine(), out numero);

                while (!isNumero)
                {
                    Console.WriteLine("ERROR! reingrese nuevamente: ");
                    isNumero = int.TryParse(Console.ReadLine(), out numero);
                }

                Console.WriteLine("Ingrese segundo numero: ");
                isNumero = int.TryParse(Console.ReadLine(), out numero2);

                while (!isNumero)
                {
                    Console.WriteLine("ERROR! reingrese nuevamente: ");
                    isNumero = int.TryParse(Console.ReadLine(), out numero2);
                }

                Console.WriteLine("Ingrese operador '+' '-' '/' '*': ");
                operador = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(numero,numero2,operador);

                Console.WriteLine("RESULTADO: {0},{1}", resultado,true);
                
                Console.WriteLine("Desea continuar? 1-0 : ");
                continuar = bool.Parse(Console.ReadLine());

            } while (continuar);

        }
    }
}
