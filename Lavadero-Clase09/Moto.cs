using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero_Clase09
{
    class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(float cilindrada, string patente, Byte cantRuedas, EMarcas marca) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            return $"{base.Mostrar()} - Cilindrada: {this.cilindrada} ";
        }

    }
}
