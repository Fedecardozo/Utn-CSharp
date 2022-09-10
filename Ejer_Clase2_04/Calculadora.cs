using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Clase2_04
{
    class Calculadora
    {
        public static float Calcular(int num, int num2, char operador)
        {
            float resultado = 0;

            switch(operador)
            {
                case '+': resultado = num + num2; break;
                case '-': resultado = num - num2; break;
                case '*': resultado = num * num2; break;
                case '/': 
                    if(Calculadora.Validar(num2))
                    {
                        resultado = num + num2; 
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(int operando)
        {
            bool retorno = false;

            if(operando != 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
