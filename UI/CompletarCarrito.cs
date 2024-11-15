using Business;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI
{
    public partial class CompletarCarrito : Form
    {
        ClientesBLL clientesBLL = new ClientesBLL();
        List<Cliente> lstClientes = new List<Cliente>();
        CarritoBLL carritoBLL = new CarritoBLL();
        List<Carrito> lstCarritos = new List<Carrito>();
        List<Producto> lstProductos = new List<Producto>();
        ProductosBLL productosBLL = new ProductosBLL();
        CarritoProductoBLL CarritoProductoBLL = new CarritoProductoBLL();
        List<DetalleCarrito> lstCarritoProducto = new List<DetalleCarrito>();
        int actualProd = 0;

        public CompletarCarrito()
        {
            InitializeComponent();
            dgv_Productos.SelectionChanged += dgv_Productos_SelectionChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CompletarCarrito_Load(object sender, EventArgs e)
        {
            //chkStock.Checked = false;
            dgv_Carrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateGral();
        }
        public void UpdateGral()
        {
            completarListadoClientes();
            llenarCB();
        }
        private void completarListadoClientes()
        {
            cbClientes.DataSource = null;
            lstClientes = clientesBLL.GetClientes();
            cbClientes.DataSource = lstClientes;
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.ValueMember = "CLIENTEID";

        }

        private void btnNuevoCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbClientes.SelectedValue != null)
                {
                    lstClientes = clientesBLL.GetClientes();
                    foreach (var cliente in lstClientes)
                    {
                        if (cliente.ClienteID == ((Cliente)cbClientes.SelectedItem).ClienteID)
                        {
                            string mensaje = carritoBLL.AgregarCarrito(cliente.ClienteID);
                            MessageBox.Show(mensaje);
                            UpdateGral();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbClientes.SelectedValue != null)
                {
                    btnNuevoCarrito.Enabled = true;
                    /*lstClientes = clientesBLL.GetClientes();
                    foreach (Cliente cliente in lstClientes)
                    {
                        if (cliente.ClienteID == ((Cliente)cbClientes.SelectedItem).ClienteID)
                        {
                            lstCarritos = clientesBLL.getCarritosCliente(cliente.ClienteID);
                            if (lstCarritos.Count <= 0)
                            {
                                cbCarritosCliente.Enabled = false;
                                cbCarritosCliente.DataSource = null;
                                throw new Exception("El Cliente no posee carritos");
                            }
                            else
                            {
                                cbCarritosCliente.DataSource = null;
                                cbCarritosCliente.DataSource = lstCarritos;
                                cbCarritosCliente.DisplayMember = "CARRITOID";
                                cbCarritosCliente.ValueMember = "CARRITOID";
                                //lblCarritoID.Text = ((Carrito)cbCarritosCliente.SelectedItem).CarritoID.ToString();
                                cbCarritosCliente.Enabled = true;
                            }
                        }
                    }*/
                    lstCarritos.Clear();
                    lstCarritos = clientesBLL.getCarritosCliente(((Cliente)cbClientes.SelectedItem).ClienteID);
                    if (lstCarritos.Count <= 0)
                    {
                        cbCarritosCliente.Enabled = false;
                        cbCarritosCliente.DataSource = null;
                        throw new Exception("El Cliente no posee carritos");
                    }
                    else
                    {
                        cbCarritosCliente.DataSource = null;
                        cbCarritosCliente.DataSource = lstCarritos;
                        cbCarritosCliente.DisplayMember = "CARRITOID";
                        cbCarritosCliente.ValueMember = "CARRITOID";
                        //lblCarritoID.Text = ((Carrito)cbCarritosCliente.SelectedItem).CarritoID.ToString();
                        cbCarritosCliente.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " ¡¡Verificar cb Clientes!!"); }
        }

        private void cbCarritosCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCarritosCliente.DataSource == null) { btnAgregarProductos.Enabled = false; } else { btnAgregarProductos.Enabled = true; }
            completarCarritoProductos();
        }
        public void completarCarritoProductos()
        {
            try
            {
                if (cbCarritosCliente.SelectedItem != null)
                {
                    dgv_Carrito.DataSource = null;
                    //lstCarritoProducto = CarritoProductoBLL.getCarritoProductos(((Carrito)cbCarritosCliente.SelectedItem).CarritoID);
                    lstCarritoProducto = CarritoProductoBLL.getDetalleCarritoProducto(((Carrito)cbCarritosCliente.SelectedItem).CarritoID);
                    dgv_Carrito.DataSource = lstCarritoProducto;
                    lblEstadoCarrito.Text = carritoBLL.getEstadoCarrito(((Carrito)cbCarritosCliente.SelectedItem).CarritoID).ToString();
                    updateCarritoDGV();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void updateCarritoDGV()
        {
            int cant = 0; double monto = 0;
            foreach (var item in lstCarritoProducto)
            {
                cant += item.Cantidad;
                monto += item.Cantidad * item.PrecioUnitario;
            }
            txtCantProd.Text = cant.ToString();
            txtMontoTotal.Text = string.Format("{0:C2}", (monto));
            //txtFinalPesos.Text = (monto*Convert.ToDouble(txtValorDolar.Text)).ToString();
            txtFinalPesos.Text = string.Format("{0:C2}", (monto * Convert.ToDouble(txtValorDolar.Text)));
            
            dgv_Carrito.DataSource = null;
            lstCarritoProducto = CarritoProductoBLL.getDetalleCarritoProducto(((Carrito)cbCarritosCliente.SelectedItem).CarritoID);
            dgv_Carrito.DataSource = lstCarritoProducto;
            lblEstadoCarrito.Text = carritoBLL.getEstadoCarrito(((Carrito)cbCarritosCliente.SelectedItem).CarritoID).ToString();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                int idCarrito = ((Carrito)cbCarritosCliente.SelectedItem).CarritoID;
                int idProducto = actualProd;
                int stock = Convert.ToInt32(txtCantidadVenta.Text);
                double precioVenta = Convert.ToDouble(txtAgregarPrecio.Text);
                CarritoProductoBLL.AgregarProductosCarrito(idCarrito, idProducto, stock, precioVenta);
                updateCarritoDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ActualizarDGVProductos();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void llenarCB()
        {
            cbCategorias.DataSource = null;
            cbCategorias.DataSource = productosBLL.getCategorias();
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDGVProductos();
        }

        private void ActualizarDGVProductos()
        {
            dgv_Productos.DataSource = null;
            if (radioTodos.Checked == true) { dgv_Productos.DataSource = productosBLL.getProductos(0, cbCategorias.Text); }
            if (radioConStock.Checked == true) { dgv_Productos.DataSource = productosBLL.getProductos(1, cbCategorias.Text); }
            if (radioSinStock.Checked == true) { dgv_Productos.DataSource = productosBLL.getProductos(-1, cbCategorias.Text); }
            dgv_Productos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dgv_Productos.Columns["ProductoID"].Visible = false;

        }

        private void radioSinStock_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDGVProductos();
        }

        private void radioConStock_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDGVProductos();
        }

        private void dgv_Productos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_Productos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Productos.SelectedRows[0];
                actualProd = Convert.ToInt32(filaSeleccionada.Cells["ProductoID"].Value);
                txtAgregarModelo.Text = filaSeleccionada.Cells["Modelo"].Value.ToString();
                txtAgregarMarca.Text = filaSeleccionada.Cells["Marca"].Value.ToString();
                txtAgregarStock.Text = filaSeleccionada.Cells["Stock"].Value.ToString();
                txtAgregarPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                txtAgregarCategoria.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
            }
        }

        private void txtValorDolar_TextChanged(object sender, EventArgs e)
        {
            updateCarritoDGV();
        }

        private void dgv_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
