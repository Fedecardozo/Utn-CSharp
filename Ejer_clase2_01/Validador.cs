using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_clase2_01
{
    class Validador
    {
        /// <summary>
        /// Validacion maximo y minimo
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>bool</returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;
            if(valor > min && valor < max)
            {
                retorno = true;
            }
            return retorno;

        }
        public static bool ValidarRespuesta(string mensaje)
        {
            bool retorno = false;

            Console.WriteLine(mensaje);
         
            if (Console.ReadLine().Substring(0,1).ToUpper() == "S")
            {
                retorno = true;
            }

            return retorno;
        }


    }
}
