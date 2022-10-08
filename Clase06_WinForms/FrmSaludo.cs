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
    public partial class FrmSaludo : Form
    {

        private FrmSaludo()
        {
            InitializeComponent();
        }

        public FrmSaludo(string titulo, string mensaje) : this()
        {
            this.labelHola.Text = titulo;
            this.labelNombreApellido.Text = mensaje;

        }
    }
}
