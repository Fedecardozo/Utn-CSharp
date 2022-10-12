using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionPropia
{
    public class MiPropiaExeption : Exception
    {
        /*Crear una clase que derive de Exception con una propiedad llamada Mensaje que concatene el mensaje que tiene como parámetro de entrada 
           en el constructor con el ya existente.
           Realizar un burbujeo partiendo de un método, capturando y re lanzando esta misma excepción como mínimo 3 (tres) veces, 
           creando los métodos que sean necesarios y colocando un nuevo mensaje por cada nuevo Throw que se realice.
       */

        private string mensaje;

        public MiPropiaExeption() : this("Esta es mi exepcion ") { }

        public MiPropiaExeption(string message)
        { 
            this.mensaje = message; 
        }

        //public MiPropiaExeption(string message, MiPropiaExeption inner)
        public MiPropiaExeption(string message , Exception inner)
        {
            //this.mensaje += inner.Mensaje;
            this.mensaje += message + ((MiPropiaExeption)inner).mensaje;
        }

        public string Mensaje 
        { 
            get 
            {
                return this.mensaje;
            }
    
        }

        public void MetodoExepcion()
        {
            try
            {
                MiPropiaExeption.MetodoExepcionStatic();
            }
            catch (MiPropiaExeption e)
            {
                throw new MiPropiaExeption("Metodo instancia ", e);
            }
        }

        public static void MetodoExepcionStatic()
        {
            try
            {
                int[] num = new int[2];
                num[0] = 1; num[1] = 2; num[3] = 3;
            }
            catch(Exception)
            {
                throw new MiPropiaExeption("Metodo estatico ");
            }
        }
    }
}
