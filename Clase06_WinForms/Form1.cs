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
            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            string materia = (string) this.comboBoxMateria.SelectedItem;        
            StringBuilder sb = new StringBuilder();
            bool flag = false;

            sb.AppendLine("Le falto completar los siguientes campos:");
        
            if(string.IsNullOrWhiteSpace(nombre))
            {
                sb.AppendLine("Nombre");
                flag = true;
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                sb.AppendLine("Apellido");
                flag = true;
            }

            if(flag)
            {
                MessageBox.Show(sb.ToString(),"Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string mensaje = $"Soy {nombre} " +
                    $"{apellido} y mi materia favorita es" +
                    $" {materia}";

                FrmSaludo frmSaludo = new FrmSaludo("¡Hola, Windows Forms!",mensaje);

                frmSaludo.ShowDialog();

            }


            //this.Hide();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.comboBoxMateria.SelectedIndex = 0;
        }
    }
}
