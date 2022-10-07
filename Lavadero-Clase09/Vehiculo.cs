using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero_Clase09
{
    public abstract class Vehiculo
    {
        protected string patente;
        protected Byte cantRuedas;
        protected EMarcas marca;

        //Propiedad de solo lectura
        public string Patente{ get { return this.patente;  } }
        public EMarcas Marca { get { return this.marca; } }

        protected string Mostrar()
        {
            return $"Patente: {this.patente} - Ruedas: {this.cantRuedas} - Marca: {this.marca}";
        }

        public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.patente == v2.patente && v1.marca == v2.marca;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Vehiculo)
            {

                retorno = this == ((Vehiculo)obj);
            }

            return retorno;

        }

    }
}
