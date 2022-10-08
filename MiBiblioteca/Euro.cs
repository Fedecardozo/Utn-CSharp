using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Euro
    {
        private double cantidad;
        private static double contzRespectodolar;

        private Euro()
        {
            this.cantidad = 0;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad,double contizacion) : this(cantidad)
        {
            Euro.contzRespectodolar = contizacion;
        }

        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad);
        }

        public static explicit operator Peso(Euro euro)
        {
            return new Peso(euro.cantidad);
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.contzRespectodolar;
        }
    }
}
