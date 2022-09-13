using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06_Ejer04
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Ordenamiento";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.listNumeros.Items.Add(this.textNewNumber.Text);
            this.textNewNumber.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if(this.rBtnAscendete.Checked)
            {
                //Metodo ordenar ascedente
                this.OrdenarAscenDesen(true);
                
            }
            else if(this.rBtnDescendente.Checked)
            {
                //Metodo ordenar descendente
                this.OrdenarAscenDesen(false);
            }
        }

        private void OrdenarAscenDesen(bool order)
        {
            int[] aux = new int[listNumeros.Items.Count];

            aux = FrmPrincipal.IntCloneListBox(this.listNumeros);

            for (int i = 0; i < aux.Length - 1; i++)
            {
                for (int j = 0; j < aux.Length - 1; j++)
                {       
                    if (order && aux[j] > aux[j+1])
                    {
                        int auxNum = aux[j];
                        aux[j] = aux[j + 1];
                        aux[j + 1] = auxNum;
                    }
                    else if (!order && aux[j] < aux[j + 1])
                    {
                        int auxNum = aux[j];
                        aux[j] = aux[j + 1];
                        aux[j + 1] = auxNum;
                    }
                }
            }

            this.listNumeros.Items.Clear();

            FrmPrincipal.AgregarItems(this.listNumeros,aux);

        }

        private static int[] IntCloneListBox(ListBox list)
        {
            int[] arrayNumeros = new int[list.Items.Count];

            for (int i = 0; i < list.Items.Count; i++)
            {
                arrayNumeros[i] = int.Parse(list.Items[i].ToString());
            }

            return arrayNumeros;

        }

        private static void AgregarItems(ListBox lista,int[] aux)
        {
            for (int i = 0; i < aux.Length; i++)
            {
                lista.Items.Add(aux[i]);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*this.textNewNumber.Clear();
            this.listNumeros.Items.Clear();
            this.rBtnAscendete.Checked = false;
            this.rBtnDescendente.Checked = false;*/

            foreach (Control controlesGroupBox in this.Controls)
            {
                if(controlesGroupBox is GroupBox)
                {
                    foreach  (Control controles in controlesGroupBox.Controls)
                    {
                        if(controles is TextBox txtBox)
                        {
                            txtBox.Clear();
                            continue;
                        }
                        if (controles is ListBox list)
                        {
                            list.Items.Clear();
                            continue;
                        }
                        if (controles is RadioButton rBtn)
                        {
                            rBtn.Checked = false;
                            continue;
                        }
                    }
                }
            }

        }
    }
}
