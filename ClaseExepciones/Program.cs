using System;
using ExeptionPropia;

namespace ClaseExepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TryParse
            /*int num;

            Console.WriteLine("Ingrese un numero: ");
            bool flag = ParseExeption.TryParse( Console.ReadLine(), out num);

            if(!flag)
            {
                Console.WriteLine("No es un numero!");
            }
            else
            {
                Console.WriteLine("El numero es: " + num);
            }*/
            #endregion

            #region Ejercicio 1

            /*try
            {
                Program.Metodo1();
            }
            catch (MiPropiaExeption ex)
            {
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine("----------------------");
                Console.WriteLine(ex.Mensaje);
                Console.WriteLine("----------------------");
                //Console.WriteLine(ex.InnerException);


            }*/

            #endregion

            #region Ejercicio 2

            MiPropiaExeption miPropiaExeption = new MiPropiaExeption();

            try
            {
                /*Siguiendo con la misma lógica del ejercicio anterior, se pide: 
                Realizar el burbujeo de una excepción propia, comenzando en un método de instancia,
                pasando por un método de estático y capturando por última vez en el “main”.*/

                miPropiaExeption.MetodoExepcion();

            }
            catch (MiPropiaExeption ex)
            {
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine("----------------------");
                Console.WriteLine(ex.Mensaje);
                Console.WriteLine("----------------------");
                //Console.WriteLine(ex.InnerException);


                #endregion
            }

            #region Metodos Ejercicios 1
            /*public static void Metodo1()
            {
                try
                {
                    Program.Metodo2();
                }
                catch (MiPropiaExeption e)
                {
                    throw new MiPropiaExeption("Exepcion metodo 1", e); ;
                }
            }
            public static void Metodo2()
            {
                try
                {
                    Program.Metodo3();
                }
                catch (MiPropiaExeption e)
                {
                    throw new MiPropiaExeption("Exepcion metodo 2", e); ;
                }
            }
            public static void Metodo3()
            {
                int num=0;
                int resultado;
                try
                {
                    resultado = 10 / num;
                }
                catch (Exception)
                {
                    throw new MiPropiaExeption("Exepcion metodo 3");
                }
            }*/

            #endregion

        }

    }

}
