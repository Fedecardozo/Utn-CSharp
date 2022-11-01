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
    public partial class FrmTestDelegados : Form
    {
        //Creo el delegado, de como es su firma 
        public delegate void DelegadoMsj(string msj);

        //El delegado es un atributo que se tiene que cargar con una funcion que cumpla con su firma
        public DelegadoMsj delegado;

        public FrmTestDelegados(DelegadoMsj delegado)
        {
            InitializeComponent();
            //instancio el delegado, osea la cargo con una funcion
            this.delegado = delegado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Uso el delegado como una funcion, es una direccio de memoria que puedo acceder desde cualquier lugar
            this.delegado(this.txtNombre.Text);
        }
    }
}
