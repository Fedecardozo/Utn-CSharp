using System;

namespace Ejercicios_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas
            en el mes de N cantidad de empleados de una fábrica.
            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
            hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y 
            el total a cobrar neto de todos los empleados ingresados.*/

            float valorHora;
            string nombre;
            int antiguedad;
            int cantidadHoras;
            bool flag;
            string seguir = "si";
            double totalCobrar;
            double totalCobrarDescuento;
            string mensajeEmpleados = "";

            do
            {
                //VALOR HORA
                Console.WriteLine("Ingrese valor hora: ");
                flag = float.TryParse(Console.ReadLine(), out valorHora);

                while (!flag || valorHora<1)
                {
                    Console.WriteLine("ERROR. Ingrese valor hora nuevamente: ");
                    flag = float.TryParse(Console.ReadLine(), out valorHora);
                }

                //NOMBRE
                Console.WriteLine("Ingrese Nombre: ");
                nombre = Console.ReadLine();

                //ANTIGUEDAD
                Console.WriteLine("Ingrese antiguedad(años): ");
                flag = int.TryParse(Console.ReadLine(), out antiguedad);

                while (!flag || antiguedad < 1)
                {
                    Console.WriteLine("ERROR. Ingrese antiguedad nuevamente: ");
                    flag = int.TryParse(Console.ReadLine(), out antiguedad);
                }

                //HORAS TRABAJADAS
                Console.WriteLine("Ingrese horas trabajadas: ");
                flag = int.TryParse(Console.ReadLine(), out cantidadHoras);

                while (!flag || cantidadHoras < 0)
                {
                    Console.WriteLine("ERROR. Ingrese horas trabajadas nuevamente: ");
                    flag = int.TryParse(Console.ReadLine(), out cantidadHoras);
                }

                totalCobrar = cantidadHoras * valorHora + antiguedad * 150;
                totalCobrarDescuento = totalCobrar - (totalCobrar * 13) / 100;
                
                /*Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y 
                el total a cobrar neto de todos los empleados ingresados.*/
                mensajeEmpleados = mensajeEmpleados + "\nNombre: " + nombre + "\nAntiguedad: " + antiguedad + " \nValor hora: " + valorHora+ 
                    "\nTotal a cobrar bruto:" + totalCobrar + "\nTotal a cobrar neto: " + totalCobrarDescuento + "\n";

                Console.WriteLine("Desea seguir ingresando empleados?: Si - No");
                seguir = Console.ReadLine();

            } while (seguir.Substring(0,1).ToLower() != "n");

            Console.WriteLine(mensajeEmpleados);
        }
    }
}
