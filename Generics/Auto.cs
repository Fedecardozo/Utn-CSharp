using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {

        #region Atributos

        private string color;
        private string marca;

        #endregion

        #region Propiedades

        public string Color { get { return this.color; } }

        public string Marca { get { return this.marca ; } }

        #endregion

        #region Constructor

        public Auto(string color, string marca)
        {
            this.marca = marca;
            this.color = color;
        }

        #endregion

        #region Sobrecarga Operadores
        
        public static bool operator ==(Auto a, Auto b)
        {
            return a.color == b.color && a.marca == b.marca;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a==b);
        }

        #endregion

        #region Sobreescritura

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is not null && obj is Auto)
            {
                retorno = ((Auto)obj) == this;
            }

            return retorno;
        }

        public override string ToString()
        {
            return $"Marca: {this.marca} - Color: {this.color}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion




    }
}
