using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIntegrador2020
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza) { }

        protected override string Ficha()
        {
            return "Gato - " + base.DatosCompletos();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return (Mascota)g1 == (Mascota)g2; 
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is not null && obj is Gato)
            {
                retorno = ((Gato)obj) == this;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
