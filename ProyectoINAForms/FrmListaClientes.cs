using BL;
using DL;
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

        List<tbClientes> lista;

        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            try
            {
                lista = cli.obtenerTodos();
                cargarLista(lista);
            }
            catch (Exception)
            {
                MessageBox.Show("Se genero un error al cargar la lista de clientes.");
            }
        }

        private void cargarLista(List<tbClientes> lista)
        {
            //Limpiar el lstView
            lstVClientes.Items.Clear();

            foreach (var cliente  in lista)
            {
                ListViewItem item = new ListViewItem();

                item.Text = cliente.cedula.Trim().ToUpper();
                item.SubItems.Add(cliente.tbPersona.nombre.Trim().ToUpper());
                item.SubItems.Add(cliente.tbPersona.apellido1.Trim().ToUpper());
                item.SubItems.Add(cliente.tbPersona.apellido2.Trim().ToUpper());

                lstVClientes.Items.Add(item);
            }
        }

        private void lstVClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
            //Cargar la lista nuevamente
            obtenerDatos();
        }

        private void lstVClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cedula = ((ListView)sender).SelectedItems[0].Text;

            var cliente = lista.Where(x => x.cedula.Trim() == cedula.Trim()).SingleOrDefault();

            FrmClientes formClientes = new FrmClientes();
            formClientes.cliente = cliente;
            formClientes.ShowDialog();
        }
    }
}
