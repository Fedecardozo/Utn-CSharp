using System;

namespace LibreriaIntegrador2020
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public string Nombre { get { return this.nombre; } }

        public string Raza { get { return this.raza; } }

        protected virtual string DatosCompletos()
        {
            return $"{this.nombre} - {this.raza}";
        }

        protected abstract string Ficha();

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            return m1.nombre == m2.nombre && m1.raza == m2.raza;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is not null && obj is Mascota)
            {
                retorno = ((Mascota)obj) == this;
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
