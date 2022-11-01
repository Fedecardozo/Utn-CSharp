using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();
            this.frmTestDelegados = new FrmTestDelegados(this.frmMostrar.ActualizarNombre);

            this.frmMostrar.MdiParent = this;
            this.frmTestDelegados.MdiParent = this;
        }

        private void textDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
    }
}
