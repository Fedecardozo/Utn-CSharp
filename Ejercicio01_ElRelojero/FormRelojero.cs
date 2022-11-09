using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01_ElRelojero
{
    public partial class FormRelojero : Form
    {
        public Action actualizarHora;

        public FormRelojero()
        {
            InitializeComponent();
        }

        private void FormRelojero_Load(object sender, EventArgs e)
        {
            Task task = Task.Run(this.CambiarHora);
        }

        private void CambiarHora()
        {
            while (true)
            {
                Thread.Sleep(1000);
                this.AsignarHora();
            }
        }

        private void AsignarHora()
        {
            if(this.lblHora.InvokeRequired)
            {
                this.actualizarHora = this.AsignarHora;
                this.lblHora.Invoke(this.actualizarHora);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

    }
}
