using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion,string genero,
            string pais,string[] cursos, int edad)
        {
            this.cursos = cursos;
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.pais = pais;
            this.genero = genero;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Curso/s: ");

            foreach (string item in this.cursos)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();

        }
    }
}
