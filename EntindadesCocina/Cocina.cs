using System;

namespace EntindadesCocina
{
    public class Cocina
    {
        #region Atributos

        private int codigo;
        private bool esIndustrial;
        private double precio;

        #endregion

        #region Propiedades

        public int Codigo { get { return this.codigo; } }

        public bool EsIndustrial { get { return this.esIndustrial; } }

        public double Precio { get { return this.precio; } }

        #endregion

        #region Sobrecarga operadores

        public static bool operator ==(Cocina a, Cocina b)
        {
            return a.codigo == b.codigo;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        #endregion

        #region Constructor
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this.codigo = codigo;
            this.precio = precio;
            this.esIndustrial = esIndustrial;
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            return $"Codigo: {this.codigo} - Es industrial: {this.esIndustrial} - Precio: {this.precio}";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is not null && obj is Cocina)
            {
                retorno = ((Cocina)obj) == this;
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
}
