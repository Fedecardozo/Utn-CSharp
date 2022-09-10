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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Inicia el formulario, es parecido al constructor
            InitializeComponent();

            //Centra el formulario
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para mostrar mensajes en modo alerta, modificar iconos y muchas cosas mas
           //MessageBox.Show("Hola mundo","Hola",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }
    }
}
