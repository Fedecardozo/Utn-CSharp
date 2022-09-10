using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }
        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }
        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Tinta: {(string)tinta}");
            sb.AppendLine($"Cantidad: {this.cantidad}");

            return sb.ToString();
        }

        public static bool operator==(Pluma pluma, Tinta tinta)
        {
            return pluma.tinta == tinta;
        }
        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return pluma.tinta != tinta;
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
                
                pluma.cantidad++;
                
            return pluma;
        }
        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)

                pluma.cantidad--;

            return pluma;
            
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

    }
}
