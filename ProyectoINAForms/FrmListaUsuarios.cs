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
    public partial class FrmListaUsuarios : Form
    {
        UsuariosBL userInst = new UsuariosBL();
        List<tbUsuarios> lista;

        public FrmListaUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            try
            {
                lista = userInst.obtenerTodos();
                cargarLista(lista);
            }
            catch (Exception)
            {
                MessageBox.Show("Se genero un error al cargar la lista de clientes.");
            }
        }

        private void cargarLista(List<tbUsuarios> lista)
        {
            //Limpiar el lstView
            lstVUsuarios.Items.Clear();

            foreach (var usuario in lista)
            {
                ListViewItem item = new ListViewItem();

                item.Text = usuario.cedula.Trim().ToUpper();
                item.SubItems.Add(usuario.tbUsuarios.idRol.Trim().ToUpper());
                item.SubItems.Add(usuario.tbUsuarios.nombre.Trim().ToUpper());               
                item.SubItems.Add(usuario.tbUsuarios.idRol.Trim().ToUpper());
                item.SubItems.Add(usuario.tbUsuarios.Estado.Trim().ToUpper());

                lstVUsuarios.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
            //Cargar la lista nuevamente
            obtenerDatos();
        }


        private void lstVClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cedula = ((ListView)sender).SelectedItems[0].Text;

            var usuario = lista.Where(x => x.cedula.Trim() == cedula.Trim()).SingleOrDefault();

            FrmUsuarios formUsuarios = new FrmUsuarios();
            formUsuarios.usuario = usuario;
            formUsuarios.ShowDialog();
        }
    }
}
