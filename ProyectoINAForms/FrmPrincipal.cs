using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoINAForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mnCerrar_Click(object sender, EventArgs e)
        {
            //Cierra todo el aplicativo
            Application.Exit();
        }

        private void mnClientes_Click(object sender, EventArgs e)
        {
            FrmListaClientes form = new FrmListaClientes();
            form.ShowDialog();
        }

        private void mnUsuarios_Click(object sender, EventArgs e)
        {
            FrmListaUsuarios form = new FrmListaUsuarios();
            form.ShowDialog();
        }
    }
}
