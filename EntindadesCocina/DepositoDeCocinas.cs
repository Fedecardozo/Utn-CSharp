using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntindadesCocina
{
    public class DepositoDeCocinas
    {
        #region Atributos

        private int capacidadMaxima;
        private List<Cocina> lista;

        #endregion

        #region Constructor

        public DepositoDeCocinas(int capacidadMaxima)
        {
            this.capacidadMaxima = capacidadMaxima;
            this.lista = new List<Cocina>();
        }

        #endregion

        #region Sobrecarga operadores

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;

            if(c is not null && d.capacidadMaxima > d.lista.Count)
            {
                d.lista.Add(c);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            int indice = d.GetIndice(c);
            
            if(indice >= 0)
            {
                d.lista.RemoveAt(indice);
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region Metodos

        private int GetIndice(Cocina c)
        {
            int indice = -1;

            for (int i = 0; i < this.lista.Count; i++)
            {
                if(c == this.lista[i])
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad maxima deposito: " + this.capacidadMaxima);
            sb.AppendLine("Lista de cocinas: ");

            foreach (Cocina item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();

        }

        #endregion
    }
}
