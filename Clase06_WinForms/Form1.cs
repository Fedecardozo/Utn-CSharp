using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06_WinForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

            this.comboBoxMateria.SelectedIndex = 0;

            string mensaje = $"Soy {this.textBoxNombre.Text} " +
                $"{this.textBoxApellido.Text} y mi materia favorita es" +
                $" {this.comboBoxMateria.SelectedItem}";

            FrmSaludo frmSaludo = new FrmSaludo("¡Hola, Windows Forms!",mensaje);

            frmSaludo.ShowDialog();

            //this.Hide();

        }
    }
}
