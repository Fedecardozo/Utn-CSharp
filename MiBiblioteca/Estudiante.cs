using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Estudiante
    {
        #region atributos
        private string apellido;
        private string leagajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static Random random;
        #endregion

        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >=4)
                return Estudiante.random.Next(6,11);
            else
                return -1;
         
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante (string nombre, string apellido, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.leagajo = legajo;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            double notaFinal = this.CalcularNotaFinal();

            mostrar.AppendLine($"Nombre: {this.nombre}");
            mostrar.AppendLine($"Apellido: {this.apellido}");
            mostrar.AppendLine($"Legajo: {this.leagajo}");
            mostrar.AppendLine($"Nota primer parcial: {this.notaPrimerParcial}");
            mostrar.AppendLine($"Nota segundo parcial: {this.notaSegundoParcial}");
            mostrar.AppendLine($"Promedio: {this.CalcularPromedio()}");

            if (notaFinal != -1)
            {
                mostrar.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                mostrar.AppendLine($"Alumno Desaprobado");
            }

            return mostrar.ToString();
        }

    }
}
