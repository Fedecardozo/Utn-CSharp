using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Auto : Vehiculo
    {
        private int cantidadAsientos;

        public Auto(string patente, Byte cantRuedas, Emarcas marca, int cantidadAsientos) : base(patente,cantRuedas,marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cantidad asientos {this.cantidadAsientos}");

            return sb.ToString();

        }
    }
}
