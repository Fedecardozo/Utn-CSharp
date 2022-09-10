using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06_Ejer02
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            //Inicia el formulario, es parecido al constructor
            InitializeComponent();

            //Centra el formulario
            this.StartPosition = FormStartPosition.CenterScreen;
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Tabla";

            //this.Text = "Cambia nombre del titulo del formulario";

            //Limpia el list box
            //this.listBox1.ClearSelected();

            //Agrega  un item
            //this.listBox1.Items.Add("Item ");

            //Cambia color de fondo
            //this.BackColor = Color.Red;

            //Cambia color de la letra de todo el form
            //this.ForeColor = Color.BlueViolet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para mostrar mensajes en modo alerta, modificar iconos y muchas cosas mas
            //MessageBox.Show("Hola mundo","Hola",MessageBoxButtons.OK,MessageBoxIcon.Stop);

            this.lstTabla.Items.Clear();
            //this.textNumero.Text = "";
            this.textNumero.Clear();

        }

        private void textNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Muestra la tecla presionada
            //MessageBox.Show(e.KeyChar.ToString());

            if(e.KeyChar == (char)Keys.Enter)
            {
                //Limpio antes de ingresar
                this.lstTabla.Items.Clear();

                //Agrega  un item y metodo para que haga la tabla de multiplicar
                this.multiplicar(this.textNumero.Text);
            }
        }

        private void multiplicar(string numero)
        {
            for(int i=1; i<11; i++)
            {
                this.lstTabla.Items.Add($"{numero} x {i} = {i*int.Parse(numero)}");
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(MessageBox.Show("¿Realmente desea cerrar el formulario?","Exit",MessageBoxButtons.YesNo)==DialogResult.No)
            if (MessageBox.Show("¿Realmente desea cerrar el formulario?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
