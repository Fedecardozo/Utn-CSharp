using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Peso
    {
        private double cantidad;
        private static double contzRespectodolar;

        private Peso()
        {
            this.cantidad = 0;
        }

        public Peso(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double contizacion) : this(cantidad)
        {
            Peso.contzRespectodolar = contizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Peso.contzRespectodolar;
        }
    }
}
