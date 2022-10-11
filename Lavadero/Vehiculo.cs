using System;

namespace Lavadero
{
    public abstract class Vehiculo
    {
        protected string patente;
        protected Byte cantRuedas;
        protected Emarcas marca;

        public Vehiculo(string patente, Byte cantRuedas, Emarcas marca)
        {
            this.marca = marca;
            this.patente = patente;
            this.cantRuedas = cantRuedas;
        }

        public string Patente { get { return this.patente; } }

        public Emarcas Marca { get { return this.marca; } }

        protected string Mostrar()
        {
            return $"Pante: {this.patente} \nCantidad Ruedas {this.cantRuedas} \nMarca {this.marca}";
        }


        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.marca == v2.marca && v1.patente == v2.patente;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is not null && obj is Vehiculo)
            {
                retorno = ((Vehiculo)obj) == this;
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
