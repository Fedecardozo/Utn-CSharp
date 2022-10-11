using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIntegrador2020
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;

        static Grupo()
        {
            Grupo.tipo = EtipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }


        public EtipoManada Tipo { set { Grupo.tipo = value; } }


        public static bool operator  ==(Grupo g, Mascota m)
        {
            /*bool retorno = false;

            foreach (Mascota item in g.manada)
            {
                if(item == m)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;*/

            return g.manada.Contains(m);
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            
            if(g == m)
            {
                g.manada.Remove(m);
            }

            return g;   
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g != m)
            {
                g.manada.Add(m);
            }

            return g;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Grupo: {g.nombre} - tipo: {Grupo.tipo}");
            sb.AppendLine($"Integrantes ({g.manada.Count + 1}): ");

            foreach (Mascota item in g.manada)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Mascota)
            {
                retorno = this == ((Mascota)obj);
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
