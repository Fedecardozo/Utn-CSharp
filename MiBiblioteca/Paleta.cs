using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Paleta
    {
        //Lista/colleccion de la clase Tempera
        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        #region Constructores

        //Constructor que instancia la lista
        private Paleta()
        {
            this.temperas = new List<Tempera>();
        }

        //Constructor que llama al otro constructor y asigna cantidad maxima de colores
        private Paleta(int cantidadMaximaColores) : this()
        {
            this.cantidadMaximaColores = cantidadMaximaColores;
        }

        #endregion

        //implicitamente se crea una instancia del objeto Paleta
        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        //Muestra todas las temperas que contiene la lista de Temperas de la clase Paleta
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad maxima de colores: {this.cantidadMaximaColores}");
            sb.AppendLine("");
            
            foreach (Tempera item in this.temperas)
            {
                sb.AppendLine($"{Tempera.Mostrar(item)}");
            }


            return sb.ToString();
        }

        //De la lista de temperas obtengo indice de la lista al ver que son la misma tempera(Color y marca)
        private int obtenerIndice(Tempera tempera)
        {
            int retorno = -1;

            for (int i = 0; i < this.temperas.Count; i++)
            {
                if (this.temperas[i] == tempera)
                {
                    retorno = i;
                    break;
                }
            }

            return retorno;

        }

        //Explicitamente (osea a traves del casteo) imprime de la clase paleta las temperas
        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        //Si dentro de paleta esta la tempera devuelve true sino false
        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;

            if (paleta.obtenerIndice(tempera) >= 0)
                retorno = true;

            return retorno;

            //Se hace todo en una sola linea
            //return paleta.obtenerIndice(tempera) >= 0;

        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        //Si dentro de paleta esta la misma tempera se la acumula a la tempera dentro de la paleta la cantidad de la tempera pasada por parametro
        //Sino la agrega sino esta y es menor a la cantidad maxima de la paleta
        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.obtenerIndice(tempera);

            if (indice >= 0)
            {
                //Aca no suma a la tempera que esta dentro de la paleta. Esta sumando la paleta pasada por parametro
                //tempera += 1;

                //Aca busca el indice de la tempera, que ya se sabe que esta por el ==
                paleta.temperas[indice] += tempera;
            }
            else if(paleta.temperas.Count < paleta.cantidadMaximaColores)
            {
                paleta.temperas.Add(tempera);
            }

            return paleta;

        }

        //Si dentro de paleta esta la misma tempera se le resta a la tempera dentro de la paleta la cantidad de la tempera pasada por parametro
        //Sino la elimina si es menor a 1 la lista de las Temperas dentro de la Paleta
        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.obtenerIndice(tempera);

            if (indice >= 0)
            {
                paleta.temperas[indice] += tempera*-1;

                if (paleta.temperas[indice] <= 0)
                {
                    paleta.temperas.RemoveAt(indice);
                }
            }

            return paleta;
        }

        //Une las dos Paletas y devuelve una Nueva Paleta con una nueva cantidad maxima y acumulando o agregando las temperas de ambas
        public static Paleta operator +(Paleta paleta, Paleta paleta2)
        {
            //Nueva Paleta con las cantidades maximas de ambas
            Paleta aux = new Paleta(paleta.cantidadMaximaColores + paleta2.cantidadMaximaColores);

            aux.temperas = paleta.temperas;

            foreach (Tempera item in paleta2.temperas)
            {
                aux += item;
            }

            return aux;

        }


        public Tempera this[int index]
        {
            get
            {
                if (index >= 0 && index < this.temperas.Count)
                    return temperas[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < this.temperas.Count)
                {
                    if (value > 0)
                        temperas[index] = value;
                    else
                        temperas.RemoveAt(index);
                }
               
            }
        }

        public int CantidadTemperas 
        {
            get
            {
                return this.temperas.Count;
            }
        }
    }
}
