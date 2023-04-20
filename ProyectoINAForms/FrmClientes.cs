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
using Utilities;

namespace ProyectoINAForms
{
    public partial class FrmClientes : Form
    {
        public tbClientes cliente { get; set; }

        TipoClientesBL tipoCliIns = new TipoClientesBL();

        ClientesBL cliIns = new ClientesBL();

        private bool isCreated;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //El manejo de exepciones se hacen siempre de donde nacen los procesos o donde los necesite.
            try
            {
                if (guardar())
                {
                    MessageBox.Show("El cliente se guardo correctamante.");
                    this.Close();
                }
            }
            catch (EntityExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cargarCombos();

            isCreated = cliente == null ? true : false;

            if (isCreated)
            {
                lbTitulo.Text = "Crear Cliente";
            }
        }

        public void cargarCombos()
        {
            var lista = tipoCliIns.obtenerTodos();
            cboTipoCli.DataSource = lista;
            cboTipoCli.DisplayMember = "nombre";
            cboTipoCli.ValueMember = "id";
        }

        private bool guardar()
        {
            if (validar())
            {
                tbClientes cliente = new tbClientes();
                cliente.cedula = mskCedula.Text;
                cliente.descMax = (int)numDesc.Value;
                cliente.tipoCliente = (int)cboTipoCli.SelectedValue;
                cliente.foto = null;

                tbPersona persona = new tbPersona();
                persona.cedula = mskCedula.Text;
                persona.nombre = txtNombre.Text;
                persona.apellido1 = txtApe1.Text;
                persona.apellido2 = txtApe2.Text;
                persona.genero = cboGenero.Text.ToUpper() == "MASCULINO" ? 1 : cboGenero.Text.ToUpper() == "FEMENINO" ? 2 : 3;
                persona.fechaNac = dtFechaNac.Value;

                cliente.tbPersona = persona;

                cliIns.guardar(cliente);

                return true;
            }
            else
            {
                MessageBox.Show("No se guardo, verifique los datos.");
                return false;
            }
        }

        private bool validar()
        {

            if(mskCedula.Text == String.Empty)
                {
                MessageBox.Show("Falta la cedula.");
                return false;
            }
            else if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Falta el nombre.");
                return false;
            }
            else if (txtApe1.Text == String.Empty)
            {
                MessageBox.Show("Falta el primer apellido.");
                return false;
            }
            else if (txtApe2.Text == String.Empty)
            {
                MessageBox.Show("Falta el segundo apellido.");
                return false;
            }
            else if (cboGenero.Text == String.Empty)
            {
                MessageBox.Show("Falta el genero.");
                return false;
            }
            else if (cboTipoCli.Text == String.Empty)
            {
                MessageBox.Show("Falta el tipo de cliente.");
                return false;
            }
            else if (numDesc.Text == String.Empty)
            {
                MessageBox.Show("Falta el descuento.");
                return false;
            }

            //todas las validaciones estan bien
            return true;
        }

        private void gbxCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
