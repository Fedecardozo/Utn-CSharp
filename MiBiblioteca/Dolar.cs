using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Dolar
    {
        private double cantidad;
        private static double contzRespectodolar;

        private Dolar()
        {
            this.cantidad = 0;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.cantidad,Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso(dolar.cantidad,Peso.GetCotizacion());
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.contzRespectodolar;
        }
    }
}
