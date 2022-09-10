using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta()
        {
            color = ConsoleColor.Black;
        }

        public Tinta(ETipoTinta tipo) : this()
        {
            this.tipo = tipo;
        }

        public Tinta(ETipoTinta tipo, ConsoleColor color) : this(tipo)
        {
            this.color = color;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Tipo: {this.tipo}");

            return sb.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator == (Tinta tinta1, Tinta tinta2)
        {
            return tinta1.tipo == tinta2.tipo && tinta1.color == tinta2.color;
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }
        
        public static implicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }


    }
}
