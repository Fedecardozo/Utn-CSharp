using System;
using MiBiblioteca;

namespace Clase03_EjemploUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            Mostrar los datos de todos los alumnos.*/

            //1)
            Estudiante alumno1 = new Estudiante("Federico","Cardozo","123456");
            Estudiante alumno2 = new Estudiante("Leandro", "Cardozo", "12121");
            Estudiante alumno3 = new Estudiante("Marcos", "Paez", "102321");

            //2)
            alumno1.SetNotaPrimerParcial(4);
            alumno1.SetNotaSegundoParcial(5);
            alumno2.SetNotaPrimerParcial(3);
            alumno2.SetNotaSegundoParcial(1);
            alumno3.SetNotaPrimerParcial(8);
            alumno3.SetNotaSegundoParcial(9);

            //3)
            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

        }
    }
}
