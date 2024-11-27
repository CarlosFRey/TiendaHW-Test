namespace UI
{
    partial class CompletarCarrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletarCarrito));
            label1 = new Label();
            label2 = new Label();
            cbClientes = new ComboBox();
            label3 = new Label();
            cbCarritosCliente = new ComboBox();
            btnNuevoCarrito = new Button();
            gpProductos = new GroupBox();
            txtAgregarCategoria = new TextBox();
            label10 = new Label();
            txtAgregarMarca = new TextBox();
            label9 = new Label();
            txtAgregarModelo = new TextBox();
            label4 = new Label();
            btnAgregarProductos = new Button();
            txtAgregarPrecio = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtCantidadVenta = new TextBox();
            txtAgregarStock = new TextBox();
            label6 = new Label();
            dgv_Productos = new DataGridView();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            radioTodos = new RadioButton();
            cbCategorias = new ComboBox();
            radioConStock = new RadioButton();
            radioSinStock = new RadioButton();
            dgv_Carrito = new DataGridView();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            groupBox2 = new GroupBox();
            txtFinalPesos = new TextBox();
            label15 = new Label();
            label14 = new Label();
            txtValorDolar = new TextBox();
            txtMontoTotal = new TextBox();
            label13 = new Label();
            txtCantProd = new TextBox();
            groupBox4 = new GroupBox();
            lblEstadoCarrito = new Label();
            groupBox5 = new GroupBox();
            btnEliminar = new Button();
            lblProductoaEliminar = new Label();
            gpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Carrito).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 3);
            label1.Name = "label1";
            label1.Size = new Size(267, 30);
            label1.TabIndex = 0;
            label1.Text = "Administrador de Carritos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Seleccione el Cliente:";
            // 
            // cbClientes
            // 
            cbClientes.Cursor = Cursors.Hand;
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(6, 40);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(166, 23);
            cbClientes.TabIndex = 2;
            cbClientes.SelectedIndexChanged += cbClientes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 73);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Nro Carrito:";
            // 
            // cbCarritosCliente
            // 
            cbCarritosCliente.BackColor = Color.White;
            cbCarritosCliente.Cursor = Cursors.Hand;
            cbCarritosCliente.FormattingEnabled = true;
            cbCarritosCliente.Location = new Point(5, 91);
            cbCarritosCliente.Name = "cbCarritosCliente";
            cbCarritosCliente.Size = new Size(72, 23);
            cbCarritosCliente.TabIndex = 4;
            cbCarritosCliente.SelectedIndexChanged += cbCarritosCliente_SelectedIndexChanged;
            // 
            // btnNuevoCarrito
            // 
            btnNuevoCarrito.Enabled = false;
            btnNuevoCarrito.Location = new Point(83, 73);
            btnNuevoCarrito.Name = "btnNuevoCarrito";
            btnNuevoCarrito.Size = new Size(89, 41);
            btnNuevoCarrito.TabIndex = 5;
            btnNuevoCarrito.Text = "Generar Nuevo Carrito";
            btnNuevoCarrito.UseVisualStyleBackColor = true;
            btnNuevoCarrito.Click += btnNuevoCarrito_Click;
            // 
            // gpProductos
            // 
            gpProductos.Controls.Add(txtAgregarCategoria);
            gpProductos.Controls.Add(label10);
            gpProductos.Controls.Add(txtAgregarMarca);
            gpProductos.Controls.Add(label9);
            gpProductos.Controls.Add(txtAgregarModelo);
            gpProductos.Controls.Add(label4);
            gpProductos.Controls.Add(btnAgregarProductos);
            gpProductos.Controls.Add(txtAgregarPrecio);
            gpProductos.Controls.Add(label7);
            gpProductos.Controls.Add(label5);
            gpProductos.Controls.Add(txtCantidadVenta);
            gpProductos.Controls.Add(txtAgregarStock);
            gpProductos.Controls.Add(label6);
            gpProductos.Location = new Point(4, 170);
            gpProductos.Name = "gpProductos";
            gpProductos.Size = new Size(183, 252);
            gpProductos.TabIndex = 6;
            gpProductos.TabStop = false;
            gpProductos.Text = "Producto Seleccionado";
            // 
            // txtAgregarCategoria
            // 
            txtAgregarCategoria.BackColor = Color.LightGray;
            txtAgregarCategoria.Enabled = false;
            txtAgregarCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAgregarCategoria.Location = new Point(72, 80);
            txtAgregarCategoria.Name = "txtAgregarCategoria";
            txtAgregarCategoria.Size = new Size(100, 23);
            txtAgregarCategoria.TabIndex = 20;
            txtAgregarCategoria.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 83);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 19;
            label10.Text = "Categoria:";
            // 
            // txtAgregarMarca
            // 
            txtAgregarMarca.BackColor = Color.LightGray;
            txtAgregarMarca.Location = new Point(72, 51);
            txtAgregarMarca.Name = "txtAgregarMarca";
            txtAgregarMarca.Size = new Size(100, 23);
            txtAgregarMarca.TabIndex = 18;
            txtAgregarMarca.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 54);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 17;
            label9.Text = "Marca:";
            // 
            // txtAgregarModelo
            // 
            txtAgregarModelo.BackColor = Color.LightGray;
            txtAgregarModelo.Location = new Point(72, 22);
            txtAgregarModelo.Name = "txtAgregarModelo";
            txtAgregarModelo.Size = new Size(100, 23);
            txtAgregarModelo.TabIndex = 16;
            txtAgregarModelo.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 25);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 15;
            label4.Text = "Modelo:";
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Cursor = Cursors.Hand;
            btnAgregarProductos.Enabled = false;
            btnAgregarProductos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProductos.Location = new Point(8, 198);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(163, 48);
            btnAgregarProductos.TabIndex = 14;
            btnAgregarProductos.Text = "Agregar al Carrito";
            btnAgregarProductos.UseVisualStyleBackColor = true;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // txtAgregarPrecio
            // 
            txtAgregarPrecio.BackColor = Color.White;
            txtAgregarPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAgregarPrecio.Location = new Point(99, 140);
            txtAgregarPrecio.Name = "txtAgregarPrecio";
            txtAgregarPrecio.Size = new Size(72, 23);
            txtAgregarPrecio.TabIndex = 13;
            txtAgregarPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 143);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 12;
            label7.Text = "Precio Venta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 112);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Stock actual:";
            // 
            // txtCantidadVenta
            // 
            txtCantidadVenta.Location = new Point(99, 169);
            txtCantidadVenta.Name = "txtCantidadVenta";
            txtCantidadVenta.Size = new Size(72, 23);
            txtCantidadVenta.TabIndex = 10;
            txtCantidadVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAgregarStock
            // 
            txtAgregarStock.BackColor = Color.LightGray;
            txtAgregarStock.Enabled = false;
            txtAgregarStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAgregarStock.Location = new Point(98, 109);
            txtAgregarStock.Name = "txtAgregarStock";
            txtAgregarStock.Size = new Size(73, 23);
            txtAgregarStock.TabIndex = 9;
            txtAgregarStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 169);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 11;
            label6.Text = "Agregar:";
            // 
            // dgv_Productos
            // 
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.AllowUserToDeleteRows = false;
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Productos.Location = new Point(644, 118);
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.ReadOnly = true;
            dgv_Productos.Size = new Size(550, 487);
            dgv_Productos.TabIndex = 16;
            dgv_Productos.CellContentClick += dgv_Productos_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(radioTodos);
            groupBox3.Controls.Add(cbCategorias);
            groupBox3.Controls.Add(radioConStock);
            groupBox3.Controls.Add(radioSinStock);
            groupBox3.Location = new Point(644, 36);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(550, 76);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtros de Productos Mostrados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(105, 50);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 13;
            label12.Text = "Categoría:";
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Checked = true;
            radioTodos.Location = new Point(110, 22);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(57, 19);
            radioTodos.TabIndex = 17;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            radioTodos.CheckedChanged += radioTodos_CheckedChanged;
            // 
            // cbCategorias
            // 
            cbCategorias.Cursor = Cursors.Hand;
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(172, 47);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(227, 23);
            cbCategorias.TabIndex = 0;
            cbCategorias.SelectedIndexChanged += cbCategorias_SelectedIndexChanged;
            // 
            // radioConStock
            // 
            radioConStock.AutoSize = true;
            radioConStock.Location = new Point(320, 22);
            radioConStock.Name = "radioConStock";
            radioConStock.Size = new Size(79, 19);
            radioConStock.TabIndex = 16;
            radioConStock.Text = "Con Stock";
            radioConStock.UseVisualStyleBackColor = true;
            radioConStock.CheckedChanged += radioConStock_CheckedChanged;
            // 
            // radioSinStock
            // 
            radioSinStock.AutoSize = true;
            radioSinStock.Location = new Point(204, 22);
            radioSinStock.Name = "radioSinStock";
            radioSinStock.Size = new Size(73, 19);
            radioSinStock.TabIndex = 15;
            radioSinStock.Text = "Sin Stock";
            radioSinStock.UseVisualStyleBackColor = true;
            radioSinStock.CheckedChanged += radioSinStock_CheckedChanged;
            // 
            // dgv_Carrito
            // 
            dgv_Carrito.AllowUserToAddRows = false;
            dgv_Carrito.AllowUserToDeleteRows = false;
            dgv_Carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Carrito.Location = new Point(193, 118);
            dgv_Carrito.Name = "dgv_Carrito";
            dgv_Carrito.ReadOnly = true;
            dgv_Carrito.Size = new Size(445, 487);
            dgv_Carrito.TabIndex = 18;
            dgv_Carrito.CellContentClick += dgv_Carrito_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNuevoCarrito);
            groupBox1.Controls.Add(cbCarritosCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbClientes);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(4, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 128);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente-Carrito";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(72, 22);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 20;
            label11.Text = "Cant. Prod:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtFinalPesos);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtValorDolar);
            groupBox2.Controls.Add(txtMontoTotal);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtCantProd);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(193, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 76);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Carrito";
            // 
            // txtFinalPesos
            // 
            txtFinalPesos.Location = new Point(304, 42);
            txtFinalPesos.Name = "txtFinalPesos";
            txtFinalPesos.Size = new Size(92, 23);
            txtFinalPesos.TabIndex = 27;
            txtFinalPesos.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(230, 45);
            label15.Name = "label15";
            label15.Size = new Size(68, 15);
            label15.TabIndex = 26;
            label15.Text = "Final Pesos:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(231, 19);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 25;
            label14.Text = "Valor Dolar:";
            // 
            // txtValorDolar
            // 
            txtValorDolar.Location = new Point(304, 15);
            txtValorDolar.Name = "txtValorDolar";
            txtValorDolar.Size = new Size(92, 23);
            txtValorDolar.TabIndex = 24;
            txtValorDolar.Text = "1000";
            txtValorDolar.TextAlign = HorizontalAlignment.Right;
            txtValorDolar.TextChanged += txtValorDolar_TextChanged;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(144, 42);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(72, 23);
            txtMontoTotal.TabIndex = 23;
            txtMontoTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(65, 45);
            label13.Name = "label13";
            label13.Size = new Size(73, 15);
            label13.TabIndex = 22;
            label13.Text = "Monto total:";
            // 
            // txtCantProd
            // 
            txtCantProd.Location = new Point(144, 16);
            txtCantProd.Name = "txtCantProd";
            txtCantProd.Size = new Size(72, 23);
            txtCantProd.TabIndex = 21;
            txtCantProd.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblEstadoCarrito);
            groupBox4.Location = new Point(4, 428);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(183, 50);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Estado del Carrito:";
            // 
            // lblEstadoCarrito
            // 
            lblEstadoCarrito.AutoSize = true;
            lblEstadoCarrito.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoCarrito.Location = new Point(8, 19);
            lblEstadoCarrito.Name = "lblEstadoCarrito";
            lblEstadoCarrito.Size = new Size(118, 21);
            lblEstadoCarrito.TabIndex = 0;
            lblEstadoCarrito.Text = "------------------";
            lblEstadoCarrito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnEliminar);
            groupBox5.Controls.Add(lblProductoaEliminar);
            groupBox5.Location = new Point(4, 550);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(183, 55);
            groupBox5.TabIndex = 23;
            groupBox5.TabStop = false;
            groupBox5.Text = "Eliminar Producto del Carrito";
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnEliminar.Location = new Point(152, 20);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(25, 25);
            btnEliminar.TabIndex = 1;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // lblProductoaEliminar
            // 
            lblProductoaEliminar.AutoSize = true;
            lblProductoaEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoaEliminar.Location = new Point(8, 19);
            lblProductoaEliminar.Name = "lblProductoaEliminar";
            lblProductoaEliminar.Size = new Size(118, 21);
            lblProductoaEliminar.TabIndex = 0;
            lblProductoaEliminar.Text = "------------------";
            lblProductoaEliminar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CompletarCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1198, 617);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Carrito);
            Controls.Add(groupBox3);
            Controls.Add(dgv_Productos);
            Controls.Add(gpProductos);
            Controls.Add(label1);
            Name = "CompletarCarrito";
            Text = "CompletarCarrito";
            Load += CompletarCarrito_Load;
            gpProductos.ResumeLayout(false);
            gpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Carrito).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbClientes;
        private Label label3;
        private ComboBox cbCarritosCliente;
        private Button btnNuevoCarrito;
        private GroupBox gpProductos;
        private TextBox txtAgregarPrecio;
        private Label label7;
        private TextBox txtAgregarStock;
        private Label label5;
        private TextBox txtCantidadVenta;
        private Label label6;
        private Button btnAgregarProductos;
        private DataGridView dgv_Productos;
        private GroupBox groupBox3;
        private Label label12;
        private RadioButton radioTodos;
        private ComboBox cbCategorias;
        private RadioButton radioConStock;
        private RadioButton radioSinStock;
        private DataGridView dgv_Carrito;
        private GroupBox groupBox1;
        private TextBox txtAgregarMarca;
        private Label label9;
        private TextBox txtAgregarModelo;
        private Label label4;
        private TextBox txtAgregarCategoria;
        private Label label10;
        private PictureBox pictureBox2;
        private Label label11;
        private GroupBox groupBox2;
        private TextBox txtCantProd;
        private TextBox txtMontoTotal;
        private Label label13;
        private TextBox txtFinalPesos;
        private Label label15;
        private Label label14;
        private TextBox txtValorDolar;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private Label lblEstadoCarrito;
        private GroupBox groupBox5;
        private Button btnEliminar;
        private Label lblProductoaEliminar;
    }
}