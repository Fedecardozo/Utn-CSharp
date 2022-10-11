using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Moto : Vehiculo
    {
        private float cilindrada;

        public Moto(string patente, Byte cantRuedas, Emarcas marca, float cilindrada) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");

            return sb.ToString();

        }
    }
}
