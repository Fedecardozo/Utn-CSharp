using System;

namespace ExeptionPropia
{
    public class ParseExeption
    {
        public static bool TryParse(string cadena, out int entero)
        {
            bool retorno = false;

            try
            {
                entero = int.Parse(cadena);
                retorno = true;
            }
            catch (Exception e)
            {
                entero = 0;
            }

            return retorno;
        }
    }
}
