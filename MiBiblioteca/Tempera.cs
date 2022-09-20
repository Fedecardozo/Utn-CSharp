using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Tempera
    {
        private ConsoleColor color;
        private String marca;
        private Int32 cantidad;

        #region Constructores

        public Tempera()
        {
            this.color = ConsoleColor.Black;
            this.marca = "";
            this.cantidad = 0;
        }

        public Tempera(ConsoleColor color) :this()
        {
            this.color = color;
        }

        public Tempera(ConsoleColor color, String marca) :this(color)
        {
            this.marca = marca;
        }

        public Tempera(ConsoleColor color, String marca, Int32 cantidad) :this(color,marca)
        {
            this.cantidad = cantidad;
        }

        #endregion

        #region Metodos

        private string Mostar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Cantidad: {this.cantidad}");

            return sb.ToString();
        }

        public static string Mostrar(Tempera tempera)
        {
            return tempera.Mostar();
        }

        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            bool retorno = false;

            if (tempera1 is null && tempera2 is null)
                retorno = true;
            else if(tempera1 is not null && tempera2 is not null )
                retorno = tempera1.marca == tempera2.marca && tempera1.color == tempera2.color;

            return retorno;
        } 

        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }

        public static implicit operator int(Tempera tempera)
        {
            return tempera.cantidad;
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            //Tempera aux = new Tempera();

            if (tempera1 == tempera2)
                tempera1.cantidad += tempera2.cantidad;

            return tempera1;
        }

        public static Tempera operator +(Tempera tempera1, int cantidad)
        {
            Tempera aux = new Tempera(tempera1.color,tempera1.marca,cantidad);

            /*aux.cantidad = tempera1.cantidad + cantidad;

            return aux; */

            /*aux = tempera1;
            aux.cantidad = cantidad;*/

            return tempera1 += aux;

        }

        #endregion

    }
}
