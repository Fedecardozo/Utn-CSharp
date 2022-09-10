using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejer_02
{
    class Sello
    {
        public static ConsoleColor color;
        public static string mensaje;
        public static string Imprimir()
        { 
            return Sello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            string bordes = "";
            string auxMensaje = "";

            if(Sello.mensaje.Length > 0)
            {
                for(int i = 0; i<=Sello.mensaje.Length+1; i++)
                {
                    bordes = bordes + "*";
                }
                auxMensaje = bordes + "\n*" + Sello.mensaje + "*\n" + bordes;
            }

            return auxMensaje;

        }
    }
}
