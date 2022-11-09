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
                this.AsignarHora();
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Esto es un metodo recursivo
        /// </summary>
        private void AsignarHora()
        {
            //Si esta en el mismo hilo del form va a decir true Sino false
            if(this.InvokeRequired)
            {
                //A mi delegador le paso el mismo metodo
                this.actualizarHora = this.AsignarHora;
                
                //Invoca al delegado desde el hilo del formulario
                this.Invoke(this.actualizarHora);
            }
            else
            {
                //Si no esta en el mismo hilo del form, cambia el texto del label
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

    }
}
