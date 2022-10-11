using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIntegrador2020
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;


        public Perro(string nombre, string raza,int edad, bool esAlfa)
            : base(nombre,raza)
        {
            this.esAlfa = esAlfa;
            this.edad = edad;
        }

        public Perro(string nombre, string raza): this(nombre,raza,0,false){  }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Perro");
            sb.Append(base.DatosCompletos());
           
            if(this.esAlfa)
            {
                sb.Append(", alfa de la manada");
            }

            sb.Append($", edad {this.edad}");

            return sb.ToString();
        }

        public static explicit operator int (Perro p)
        {
            return p.edad;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return (Mascota)p1 == (Mascota)p2 && p1.edad == p2.edad;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            
            if(obj is not null && obj is Perro)
            {
                retorno = ((Perro)obj) == this;
            }

            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
