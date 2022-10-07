using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero_Clase09
{
    class Camion : Vehiculo
    {
        protected float tara;
        public Camion(float tara, string patente, Byte cantRuedas, EMarcas marca) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            return $"{base.Mostrar()} - Tara: {this.tara} ";
        }

    }
}
