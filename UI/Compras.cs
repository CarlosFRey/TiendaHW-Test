using Business;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Compras : Form
    {
        ProductosBLL productoBLL = new ProductosBLL();
        public Compras()
        {
            InitializeComponent();
            dgv_Productos.SelectionChanged += dgv_Productos_SelectionChanged;
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            dgv_Productos.SelectionChanged += dgv_Productos_SelectionChanged;
            llenarDGV();
            llenarCB();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Modelo.Text) || string.IsNullOrEmpty(txt_Marca.Text) || string.IsNullOrEmpty(txt_Categoria.Text) || string.IsNullOrEmpty(txt_Stock.Text) || string.IsNullOrEmpty(txt_Stock.Text))
                {
                    throw new Exception("Todos los campos deben tener valores para realizar el alta");
                }
                else
                {
                    Producto productoAlta = new Producto()
                    {
                        Modelo = txt_Modelo.Text,
                        Marca = txt_Marca.Text,
                        Stock = Convert.ToInt32(txt_Stock.Text),
                        Precio = Convert.ToDouble(txt_Precio.Text),
                        Categoria = txt_Categoria.Text
                    };
                    productoBLL.GuardarProducto(productoAlta);
                }
                llenarDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void llenarDGV()
        {
            dgv_Productos.DataSource = null;
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Productos.DataSource = productoBLL.getProductos(0);
            dgv_Productos.Columns["Precio"].DefaultCellStyle.Format = "C2";

        }

        private void dgv_Productos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_Productos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Productos.SelectedRows[0];
                txtModificarId.Text = filaSeleccionada.Cells["PRODUCTOID"].Value.ToString();
                txtModificarModelo.Text = filaSeleccionada.Cells["Modelo"].Value.ToString();
                txtModificarMarca.Text = filaSeleccionada.Cells["Marca"].Value.ToString();
                txtModificarStock.Text = filaSeleccionada.Cells["Stock"].Value.ToString();
                txtModificarPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                txtModificarCategoria.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
                txtEliminarID.Text = filaSeleccionada.Cells["PRODUCTOID"].Value.ToString();
                txtEliminarModelo.Text = filaSeleccionada.Cells["Modelo"].Value.ToString();
                txtEliminarMarca.Text = filaSeleccionada.Cells["Marca"].Value.ToString();
            }
        }

        private void dgv_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto modificarProducto = new Producto();
                modificarProducto.Marca = txtModificarMarca.Text;
                modificarProducto.Modelo = txtModificarModelo.Text;
                modificarProducto.ProductoID = Convert.ToInt32(txtModificarId.Text);
                modificarProducto.Stock = Convert.ToInt32(txtModificarStock.Text);
                modificarProducto.Precio = Convert.ToDouble(txtModificarPrecio.Text);
                modificarProducto.Categoria = txtModificarCategoria.Text;
                MessageBox.Show(productoBLL.modificarProducto(modificarProducto));
                llenarDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ActualizarDGV()
        {
            
            if (radioTodos.Checked == true) { dgv_Productos.DataSource = productoBLL.getProductos(0, cbCategorias.Text); }
            if (radioConStock.Checked == true) { dgv_Productos.DataSource = productoBLL.getProductos(1, cbCategorias.Text); }
            if (radioSinStock.Checked == true) { dgv_Productos.DataSource = productoBLL.getProductos(-1, cbCategorias.Text); }
            dgv_Productos.Columns["Precio"].DefaultCellStyle.Format = "C2";
        }

        private void radioConStock_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void radioSinStock_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto eliminarProducto = new Producto();
                eliminarProducto.Marca = txtEliminarMarca.Text;
                eliminarProducto.Modelo = txtEliminarModelo.Text;
                eliminarProducto.ProductoID = Convert.ToInt32(txtEliminarID.Text);
                eliminarProducto.Stock = 0;
                eliminarProducto.Precio = 0;
                eliminarProducto.Categoria = " ";
                MessageBox.Show(productoBLL.eliminarProducto(eliminarProducto));
                llenarDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_Productos.DataSource = null;
                if (radioTodos.Checked == true) { dgv_Productos.DataSource = productoBLL.getProductos(0, cbCategorias.Text); }
                if (radioConStock.Checked == true) { dgv_Productos.DataSource = productoBLL.getProductos(1, cbCategorias.Text); }
                if (radioSinStock.Checked == true) { dgv_Productos.DataSource = productoBLL.getProductos(-1, cbCategorias.Text); }
                dgv_Productos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void llenarCB()
        {
            cbCategorias.DataSource = null;
            cbCategorias.DataSource = productoBLL.getCategorias();
        }
    }
}
