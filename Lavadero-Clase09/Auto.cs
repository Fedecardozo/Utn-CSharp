using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero_Clase09
{
    class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(int cantidadAsientos,string patente, Byte cantRuedas, EMarcas marca) :base(patente,cantRuedas,marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            return $"{base.Mostrar()} - Cantidad asientos: {this.cantidadAsientos} ";
        }

    }
}
