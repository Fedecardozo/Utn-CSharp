using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito <T>
    {
        #region Atributos

        private int capacidadMaxima;
        private List<T> lista;

        #endregion

        #region Constructor

        public Deposito(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this.lista = new List<T>();
        }

        #endregion

        #region Sobrecarga operadores

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;

            if(d.lista.Count < d.capacidadMaxima)
            {
                d.lista.Add(a);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);

            if (indice >= 0)
            {
                d.lista.RemoveAt(indice);
                retorno = true;
            }

            return retorno;
        }

        #endregion


        #region Metodos

        private int GetIndice(T a)
        {
            int indice = -1;

            for (int i = 0; i < this.lista.Count; i++)
            {
                if(this.lista[i].Equals(a))
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad maxima deposito: " + this.capacidadMaxima);
            sb.AppendLine($"Listado deposito {typeof(T).Name}: ");

            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #endregion

    }
}
