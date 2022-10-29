using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        #region Atributos

        private int capacidadMaxima;
        private List<Auto> lista;

        #endregion

        #region Constructor

        public DepositoDeAutos(int capacidadMaxima)
        {
            this.lista = new List<Auto>();
            this.capacidadMaxima = capacidadMaxima;
        }

        #endregion

        #region Sobrecarga operadores

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            if (a is not null && d.lista.Count < d.capacidadMaxima)
            {
                d.lista.Add(a);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);

            if (indice >= 0 )
            {
                d.lista.RemoveAt(indice);
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region Metodos

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        private int GetIndice(Auto a)
        {
            int indice = -1;
            int i = 0;

            foreach (Auto item in this.lista)
            {
                if (item == a)
                {
                    indice = i;
                    break;
                }

                i++;
            }

            return indice;
        }

        #endregion

        #region Sobreescritura

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad maxima de autos " + this.capacidadMaxima);
            sb.AppendLine("Lista de autos:");

            foreach (Auto item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #endregion

    }
}
