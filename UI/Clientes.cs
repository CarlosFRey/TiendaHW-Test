using Business;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Clientes : Form
    {
        ClientesBLL clienteBLL = new ClientesBLL();
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtCUILCUIT.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text)) { MessageBox.Show("Todos los datos del cliente deben estar completos para darlo de alta"); }
                else
                {
                    Cliente clienteAlta = new Cliente()
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Cuit = Convert.ToDouble(txtCUILCUIT.Text),
                        Email = txtEmail.Text,
                        Telefono = Convert.ToDouble(txtTelefono.Text),
                        Direccion = txtDireccion.Text
                    };
                    clienteBLL.guardarCliente(clienteAlta);
                    LlenarDGV();
                }

            }
            catch (Exception ex) { throw; }


        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            LlenarDGV();
        }

        private void LlenarDGV()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteBLL.GetClientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
