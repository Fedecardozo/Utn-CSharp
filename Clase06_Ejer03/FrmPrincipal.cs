using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06_Ejer03
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Descuento";
            this.textDescuento.Enabled = false;
            this.textTotalPagar.Enabled = false;
        }

        /*
        private void textImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                //Metodo para calcular descuento e importe a pagar
                this.textDescuento.Text = $"{this.Descuento(this.textImporte.Text)}";
                this.textTotalPagar.Text = this.TotalPagar(this.textImporte.Text, this.Descuento(this.textImporte.Text));
            }
        }*/

        private float Descuento(string numero)
        {
            float descuento;
            /*Un restaurante ofrece un descuento del 10% para consumos entre $3000 y $5000; un
            descuento del 20% para consumos mayores a $5000; para todos los demás casos no se
            aplica ningún tipo de descuento.*/

            if(float.Parse(numero) >= 3000 && float.Parse(numero) <= 5000)
            {
                descuento = (float.Parse(numero) * 10) / 100;
            }
            else if(float.Parse(numero) >= 5000)
            {
                descuento = (float.Parse(numero) * 20) / 100;
            }
            else
            {
                descuento = 0;
            }

            return descuento;

        }

        private string TotalPagar(string importe, float descuento)
        {
            return $"{float.Parse(importe) - descuento}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Limpio los textboxes antes de mostrar
            /*this.textImporte.Clear();
            this.textDescuento.Clear();
            this.textTotalPagar.Clear();*/

            //Metodo para calcular descuento e importe a pagar
            this.textDescuento.Text = $"{this.Descuento(this.textImporte.Text)}";
            this.textTotalPagar.Text = this.TotalPagar(this.textImporte.Text, this.Descuento(this.textImporte.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textImporte.Clear();
            this.textDescuento.Clear();
            this.textTotalPagar.Clear();
        }
    }
}
