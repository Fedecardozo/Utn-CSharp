using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca;

namespace WindowsFormsApp
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = this.textBoxNombre.Text;
            string direccion = this.textBoxDireccion.Text;
            int edad = (int)this.numericUpDownEdad.Value;
            string genero = "";
            string[] cursos = new string[3];
            int i = 0;
            string pais;

            this.listBoxPais.SelectedIndex = 0;
            pais = this.listBoxPais.SelectedItem.ToString();

           // MessageBox.Show(pais);

            foreach (RadioButton item in this.groupBoxGenero.Controls)
            {
                if(item.Checked)
                {
                    genero = item.Text;
                }
            }

            foreach (CheckBox item in this.groupBoxCursos.Controls)
            {
                if (item.Checked)
                {
                    cursos[i] = item.Text;
                    i++;
                }

            }

            Ingresante ingresante = new Ingresante(nombre,direccion,genero,pais,cursos,edad);

            MessageBox.Show(ingresante.Mostrar(),"Ingresado",MessageBoxButtons.OK);


        }
    }
}
