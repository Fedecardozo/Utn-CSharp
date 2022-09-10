using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Cosa
    {
        /*clase Cosa
        *-*-*-*-*-*-
        (-) entero:int
        (-) cadena:string
        (-) fecha:DateTime
        *-*-*-*-*-*-*-*-*-*-*
        (+) EstablecerValor(int):void
        (+) EstablecerValor(string):void
        (+) EstablecerValor(DateTime):void
        *-*-*-*-*-*-*-*-*-*
        (-) Mostrar():string -> de instancia
        (+) Mostrar(Cosa):string -> de clase*/

        /* Parte 2 Ejercicio
        (+) Cosa(DateTime, int, string)
        (+) Cosa(int, string)
        (+) Cosa(string)
        (+) Cosa()
        ---> en todos los casos la fecha por defecto debe ser la actual (a menos que se reciba por parámetro)
        ---> los valores predeterminados serán:
        10 -> int
        "sin valor" -> string
        'Now' -> DateTime*/

        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(int entero, string cadena):this(cadena)
        {
            this.entero = entero;
        }
        public Cosa(string cadena):this()
        {
            this.cadena = cadena;
        }
        public Cosa(DateTime fecha,int entero, string cadena)
        {
            this.fecha = fecha;
            this.entero = entero;
            this.cadena = cadena;
        }


        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        private string Mostrar()
        {
            StringBuilder muestra = new StringBuilder();

            muestra.AppendLine($"Entero: {this.entero}");
            muestra.AppendLine($"Cadena: {this.cadena}");
            muestra.AppendLine($"Fecha: {this.fecha.ToShortDateString()}");

            return muestra.ToString();
        }

        public static string Mostrar(Cosa cositas)
        {
            //LO COMENTADO ESTA MAL. SE TIENE QUE REUTILIZAR CODIGO
            /* StringBuilder muestra = new StringBuilder();

             muestra.AppendLine($"Entero: {cositas.entero}");
             muestra.AppendLine($"Cadena: {cositas.cadena}");
             muestra.AppendLine($"Fecha: {cositas.fecha.ToShortTimeString()}");

             return muestra.ToString();*/

            return cositas.Mostrar();

        }

    }
}
