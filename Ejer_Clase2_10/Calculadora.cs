using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Clase2_10
{
    class Calculadora
    {

        public static int Factorial(int numero)
        {
            int retorno=0;

            for(int i=1; i<=numero; i++)
            {

                if(i == 1)
                {
                    retorno = i;
                }
                else
                {
                    retorno *= i;
                }
                Console.WriteLine("{0} - {1}",i,retorno);
            }

            return retorno;
        }
    }
}
