﻿using Business;
using DTO;
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
        CarritoProductoBLL carritoProductoBLL = new CarritoProductoBLL();
        List<DetalleCarrito> lstDetalleCarritoProducto = new List<DetalleCarrito>();
        int actualProd = 0;

        public CompletarCarrito()
        {
            InitializeComponent();
            dgv_Productos.SelectionChanged += dgv_Productos_SelectionChanged;
            dgv_Carrito.SelectionChanged += dgv_Carrito_SelectionChanged;
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
            Image imgTacho = Image.FromFile("delete.png");
            btnEliminar.BackgroundImage = imgTacho;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void UpdateGral()
        {
            completarListadoClientes(); //ok!
            llenarCB(); //ok!
        }
        private void completarListadoClientes() //ok!
        {
            cbClientes.DataSource = null;
            lstClientes = clientesBLL.GetClientes(); //ok!
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
                    lstClientes = clientesBLL.GetClientes(); //ok!
                    foreach (var cliente in lstClientes)
                    {
                        if (cliente.ClienteID == ((Cliente)cbClientes.SelectedItem).ClienteID)
                        {
                            string mensaje = carritoBLL.AgregarCarrito(cliente.ClienteID); //ok!
                            MessageBox.Show(mensaje);
                            completarListadoClientes();
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
                    //lstCarritos.Clear();
                    //lstCarritos = clientesBLL.getCarritosCliente(((Cliente)cbClientes.SelectedItem).ClienteID);
                    lstCarritos = ((Cliente)cbClientes.SelectedItem).lstCarritos;
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
                    //lstCarritoProducto = CarritoProductoBLL.getDetalleCarritoProducto(((Carrito)cbCarritosCliente.SelectedItem).CarritoID);
                    //dgv_Carrito.DataSource = lstCarritoProducto;
                    //lblEstadoCarrito.Text = carritoBLL.getEstadoCarrito(((Carrito)cbCarritosCliente.SelectedItem).CarritoID).ToString();
                    updateCarritoDGV();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void updateCarritoDGV()
        {
            dgv_Carrito.DataSource = null;
            List<CarritoProducto> lstCP = carritoProductoBLL.getCarritoProductos(((Carrito)cbCarritosCliente.SelectedItem).CarritoID);
            //lstCarritoProducto = CarritoProductoBLL.getDetalleCarritoProducto(((Carrito)cbCarritosCliente.SelectedItem).CarritoID);
            lstDetalleCarritoProducto = DGVDetalleCarritoDTO.DTO(lstCP);
            dgv_Carrito.DataSource = lstDetalleCarritoProducto;
            lblEstadoCarrito.Text = carritoBLL.getEstadoCarrito(((Carrito)cbCarritosCliente.SelectedItem).CarritoID).ToString();
            updateTXTs();
        }
        public void updateTXTs()
        {

            int cant = 0; double monto = 0;
            foreach (var item in lstDetalleCarritoProducto)
            {
                cant += item.Cantidad;
                monto += item.Cantidad * item.PrecioUnitario;
            }
            txtCantProd.Text = cant.ToString();
            txtMontoTotal.Text = string.Format("{0:C2}", (monto));
            //txtFinalPesos.Text = (monto*Convert.ToDouble(txtValorDolar.Text)).ToString();
            txtFinalPesos.Text = string.Format("{0:C2}", (monto * Convert.ToDouble(txtValorDolar.Text)));
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                int idCarrito = ((Carrito)cbCarritosCliente.SelectedItem).CarritoID;
                int idProducto = actualProd;
                int stock = Convert.ToInt32(txtCantidadVenta.Text);
                double precioVenta = Convert.ToDouble(txtAgregarPrecio.Text);
                carritoProductoBLL.AgregarProductosCarrito(idCarrito, idProducto, stock, precioVenta);
                updateCarritoDGV();
                ActualizarDGVProductos();
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
        private void llenarCB() //ok!
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

        private void dgv_Carrito_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_Carrito.SelectedRows.Count > 0)
            {
                DataGridViewRow filaProducto = dgv_Carrito.SelectedRows[0];
                lblProductoaEliminar.Text = filaProducto.Cells["Modelo"].Value.ToString(); 
            }
        }

        private void txtValorDolar_TextChanged(object sender, EventArgs e)
        {
            updateCarritoDGV();
        }

        private void dgv_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Carrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgv_Carrito.SelectedCells.Count > 0)
            {
                int rowIndex = dgv_Carrito.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = dgv_Carrito.Rows[rowIndex];
                //var valor = filaSeleccionada.Cells["Modelo"].Value;
                //MessageBox.Show($"Valor de la celda seleccionada: {valor}; Fila seleccionada: {rowIndex+1}");
                DialogResult eliminar = MessageBox.Show($"Se eliminaran del carrito y serán devueltas a stock {filaSeleccionada.Cells["Cantidad"].Value} unidades del producto {filaSeleccionada.Cells["Modelo"].Value} \n ¿Confirma la eliminación?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes) 
                {
                    int IdABorrar = carritoProductoBLL.getIDproductoDesdeDetalleCarrito(rowIndex + 1);
                    int idCarrito = ((Carrito)cbCarritosCliente.SelectedItem).CarritoID;
                    carritoProductoBLL.eliminarProductoDeCarritoProducto(idCarrito, IdABorrar);
                    //MessageBox.Show($"ID del producto a eliminar: {IdABorrar}");
                    updateCarritoDGV();
                    ActualizarDGVProductos();
                }
                else { MessageBox.Show("Los productos no fueron eliminados"); }
                    
            }
            else
            {
                MessageBox.Show("No hay ninguna celda seleccionada.");
            }
        }
    }
}
