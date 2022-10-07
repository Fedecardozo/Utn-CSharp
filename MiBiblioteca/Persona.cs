using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimento;
        private int dni;

        public Persona()
        {
            this.nombre = "";
            this.fechaNacimento = new DateTime(1,1,1);
            this.dni = 0;
        }

        public string Nombre 
        {
            get { return this.Nombre; }
            set { this.nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimento; }
            set { this.fechaNacimento = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;

            return fechaActual.AddTicks(-this.fechaNacimento.Ticks).Year - 1;
           
        }

        public string Mostrar()
        {
            return $"Nombre: {this.nombre} \nFecha nacimiento: {this.fechaNacimento}" +
                $"\nEdad: {this.CalcularEdad()} \nDni: {this.dni}";
        }

        public string EsMayorDeEdad()
        {
            if (this.CalcularEdad() > 18)
                return "Es mayor de edad";
            else
                return "Es menor de edad";
        }

    }
}
