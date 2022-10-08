using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        #region Constructores
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) {}

        #endregion

        #region Sobrecarga de operadores

        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        #endregion

        #region Sobrecarga de metodos

        private void  Sumar()
        {
            this.cantidadSumas++;
        }

        public long Sumar(long a, long b)
        {
            this.Sumar();
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.Sumar();
            return a + b;
        }
        #endregion
    }
}
