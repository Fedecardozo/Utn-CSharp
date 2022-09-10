using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short total;

            total = (short)(this.tinta + tinta);

            if (total >= 0 && total <= cantidadTintaMaxima)
                this.tinta = total;
      
        }

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.color = new ConsoleColor();

            this.tinta = tinta;
            this.color = color;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = true;
            string auxDibujo = "";
            short totalTinta = (short)(this.tinta - gasto);

            if(totalTinta >= 0)
            {
                for(int i=0; i<gasto; i++)
                {
                    auxDibujo += "*";
                }
                retorno = false;
                this.SetTinta((short)(gasto * -1));
            }
            else if(this.tinta > 0)
            {
                for (int i = 0; i < this.tinta; i++)
                {
                    auxDibujo += "*";
                }
                retorno = false;
            }

            dibujo = auxDibujo;

            return retorno;
            

        }
    }
}
