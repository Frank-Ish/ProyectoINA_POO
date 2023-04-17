using BL;
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
    public partial class FrmListaClientes : Form
    {
        ClientesBL cli = new ClientesBL();
        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            var lista = cli.obtenerTodos();
        }

        private void lstVClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
