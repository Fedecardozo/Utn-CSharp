using System;

namespace Clase13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Try parse
            /*int num;

            Console.WriteLine("Retorno:{0}  \nNumero obtenido: {1} ", NumeroEntero.TryParse("fede",out num), num);*/
            #endregion

            #region Burbujeo
            /*
            try
            {
                Program.Metodo1();
            }
            catch(MiExepcion e)
            {
                //Primera idea
                //Console.WriteLine(e.Mensaje);

                //Segunda idea
                Console.WriteLine(e.Message);

            }
            */
            #endregion

            /*Siguiendo con la misma lógica del ejercicio anterior, se pide: Realizar el burbujeo de una excepción propia, 
              comenzando en un método de instancia, pasando por un método de estático y capturando por última vez en el “main”.*/

            try
            {
                (new Program()).MetodoInstancia();
            }
            catch (MiExepcion e)
            {
                Console.WriteLine(e.Message);
            }


        }

        #region Burbujeo método de instancia, pasando por un método de estático y capturando por última vez en el “main”

        public void MetodoInstancia()
        {
            try
            {
                Program.MetodoEstatico();
            }
            catch (MiExepcion e)
            {
                throw new MiExepcion("Metodo instancia", e);
            }
        }

        public static void MetodoEstatico()
        {
            throw new MiExepcion("Metodo estatico");
        }

        #endregion

        #region Burbujeo metodos
        public static void Metodo1()
        {
            try
            {
                Program.Metodo2();
            }
            catch (Exception e)
            {
                throw new MiExepcion("Metodo 1",e);
            }
        }
        public static void Metodo2()
        {
            try
            {
                Program.Metodo3();
            }
            catch (MiExepcion e)
            {
                //Console.WriteLine("Propiedad: {0} - Message: {1} - Inner: {2}",e.Mensaje,e.Message,e.InnerException.Message);
                throw new MiExepcion("Metodo 2",e);
            }
        }
        public static void Metodo3()
        {
            throw new MiExepcion("Metodo 3");
        }
        #endregion
    }
    public static class NumeroEntero
    {
        #region Ejemplo 1 TryParse
        public static bool TryParse(string cadena, out int num)
        {
            bool retorno = true;
            num = 0;

            try
            {
                num = int.Parse(cadena);
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion

    }

    public class MiExepcion : Exception
    {
        #region Mi primera idea

        /*private string mensaje;
        public MiExepcion(string msj)
        {
            this.mensaje = msj;
        }

        public MiExepcion(string mensaje , MiExepcion inner)
        {
            this.mensaje = inner.mensaje + " " + mensaje;
        }
        public MiExepcion(string mensaje, Exception inner) : this(mensaje, (MiExepcion)inner)
        {
            
        }
            public string Mensaje { get { return this.mensaje; } }
        */
#endregion

            #region Idea mas basica

            public MiExepcion(string msj): base(msj) { }

        public MiExepcion(string msj, Exception inner) : base(msj + " " + inner.Message) { }

        #endregion
    
    }

}
