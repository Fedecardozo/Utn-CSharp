using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Clase2_03
{
    class Conversor
    {

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string retorno = "";
            int resto;
            int divisor;

            if(numeroEntero > 1)
            {
                divisor = numeroEntero;

                while(divisor > 1)
                {
                    resto = divisor % 2;
                    divisor = divisor / 2;
                    retorno = resto + retorno;
                }

                retorno = 1 + retorno;

                if(retorno.Length % 4 != 0)
                {
                    for(int i=0; retorno.Length % 4 !=0; i++)
                    {
                        retorno = 0 + retorno;
                    }
     
                }
            }
            else if(numeroEntero >=0 && numeroEntero <=1)
            {
                retorno = retorno + numeroEntero;
            }



            return retorno;
            
        }

        public static int ConvertirBinarioADecimal(int numeroEntero) 
        {
            string entero = "";
            int acumulador = 0;
            int exponente = 0;

            entero = entero + numeroEntero;

            for(int i= entero.Length ; i>0 ; i--)
            {
                
                if (entero.Substring(i-1,1) == "1")
                {
                    acumulador += (int)Math.Pow(2,exponente);
                }

                exponente++; 
            }

            return acumulador;
        }

    }
}
