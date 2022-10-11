using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Camion : Vehiculo
    {
        private float tara;

        public Camion(string patente, Byte cantRuedas, Emarcas marca, float tara) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Tara: {this.tara}");

            return sb.ToString();

        }
    }
}
