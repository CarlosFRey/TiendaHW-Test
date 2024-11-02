namespace UI
{
    partial class Compras
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
            gb_AltaProductos = new GroupBox();
            btnAltaProducto = new Button();
            label5 = new Label();
            label2 = new Label();
            txt_Categoria = new TextBox();
            txt_Precio = new TextBox();
            txt_Stock = new TextBox();
            label4 = new Label();
            txt_Marca = new TextBox();
            label3 = new Label();
            txt_Modelo = new TextBox();
            Modelo = new Label();
            dgv_Productos = new DataGridView();
            groupBox1 = new GroupBox();
            label11 = new Label();
            txtModificarId = new TextBox();
            btnModificarProducto = new Button();
            label1 = new Label();
            label6 = new Label();
            txtModificarCategoria = new TextBox();
            txtModificarPrecio = new TextBox();
            txtModificarStock = new TextBox();
            label7 = new Label();
            txtModificarMarca = new TextBox();
            label8 = new Label();
            txtModificarModelo = new TextBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            txtEliminarMarca = new TextBox();
            label14 = new Label();
            txtEliminarID = new TextBox();
            label13 = new Label();
            btnEliminarProducto = new Button();
            txtEliminarModelo = new TextBox();
            label10 = new Label();
            radioSinStock = new RadioButton();
            groupBox3 = new GroupBox();
            label12 = new Label();
            radioTodos = new RadioButton();
            cbCategorias = new ComboBox();
            radioConStock = new RadioButton();
            gb_AltaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // gb_AltaProductos
            // 
            gb_AltaProductos.BackColor = Color.MediumAquamarine;
            gb_AltaProductos.Controls.Add(btnAltaProducto);
            gb_AltaProductos.Controls.Add(label5);
            gb_AltaProductos.Controls.Add(label2);
            gb_AltaProductos.Controls.Add(txt_Categoria);
            gb_AltaProductos.Controls.Add(txt_Precio);
            gb_AltaProductos.Controls.Add(txt_Stock);
            gb_AltaProductos.Controls.Add(label4);
            gb_AltaProductos.Controls.Add(txt_Marca);
            gb_AltaProductos.Controls.Add(label3);
            gb_AltaProductos.Controls.Add(txt_Modelo);
            gb_AltaProductos.Controls.Add(Modelo);
            gb_AltaProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_AltaProductos.Location = new Point(12, 12);
            gb_AltaProductos.Name = "gb_AltaProductos";
            gb_AltaProductos.Size = new Size(256, 208);
            gb_AltaProductos.TabIndex = 2;
            gb_AltaProductos.TabStop = false;
            gb_AltaProductos.Text = "Alta Productos";
            // 
            // btnAltaProducto
            // 
            btnAltaProducto.Location = new Point(6, 167);
            btnAltaProducto.Name = "btnAltaProducto";
            btnAltaProducto.Size = new Size(236, 23);
            btnAltaProducto.TabIndex = 12;
            btnAltaProducto.Text = "Dar de Alta Producto";
            btnAltaProducto.UseVisualStyleBackColor = true;
            btnAltaProducto.Click += btnAltaProducto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 146);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 11;
            label5.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 117);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 10;
            label2.Text = "Precio:";
            // 
            // txt_Categoria
            // 
            txt_Categoria.Location = new Point(84, 138);
            txt_Categoria.Name = "txt_Categoria";
            txt_Categoria.Size = new Size(162, 23);
            txt_Categoria.TabIndex = 9;
            // 
            // txt_Precio
            // 
            txt_Precio.Location = new Point(84, 109);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(162, 23);
            txt_Precio.TabIndex = 8;
            // 
            // txt_Stock
            // 
            txt_Stock.Location = new Point(84, 80);
            txt_Stock.Name = "txt_Stock";
            txt_Stock.Size = new Size(162, 23);
            txt_Stock.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 88);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Stock:";
            // 
            // txt_Marca
            // 
            txt_Marca.Location = new Point(84, 51);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(162, 23);
            txt_Marca.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 59);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Marca:";
            // 
            // txt_Modelo
            // 
            txt_Modelo.Location = new Point(84, 22);
            txt_Modelo.Name = "txt_Modelo";
            txt_Modelo.Size = new Size(162, 23);
            txt_Modelo.TabIndex = 3;
            // 
            // Modelo
            // 
            Modelo.AutoSize = true;
            Modelo.Location = new Point(8, 30);
            Modelo.Name = "Modelo";
            Modelo.Size = new Size(52, 15);
            Modelo.TabIndex = 2;
            Modelo.Text = "Modelo:";
            // 
            // dgv_Productos
            // 
            dgv_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Productos.Location = new Point(274, 64);
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.ReadOnly = true;
            dgv_Productos.Size = new Size(892, 546);
            dgv_Productos.TabIndex = 3;
            dgv_Productos.CellContentClick += dgv_Productos_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Khaki;
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtModificarId);
            groupBox1.Controls.Add(btnModificarProducto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtModificarCategoria);
            groupBox1.Controls.Add(txtModificarPrecio);
            groupBox1.Controls.Add(txtModificarStock);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtModificarMarca);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtModificarModelo);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 229);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modificar Productos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 25);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 14;
            label11.Text = "Id Producto:";
            // 
            // txtModificarId
            // 
            txtModificarId.Enabled = false;
            txtModificarId.Location = new Point(82, 22);
            txtModificarId.Name = "txtModificarId";
            txtModificarId.Size = new Size(162, 23);
            txtModificarId.TabIndex = 13;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(6, 196);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(238, 23);
            btnModificarProducto.TabIndex = 12;
            btnModificarProducto.Text = "Modificar Datos Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 170);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 11;
            label1.Text = "Tipo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 141);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Precio:";
            // 
            // txtModificarCategoria
            // 
            txtModificarCategoria.Location = new Point(82, 167);
            txtModificarCategoria.Name = "txtModificarCategoria";
            txtModificarCategoria.Size = new Size(162, 23);
            txtModificarCategoria.TabIndex = 9;
            // 
            // txtModificarPrecio
            // 
            txtModificarPrecio.Location = new Point(82, 138);
            txtModificarPrecio.Name = "txtModificarPrecio";
            txtModificarPrecio.Size = new Size(162, 23);
            txtModificarPrecio.TabIndex = 8;
            // 
            // txtModificarStock
            // 
            txtModificarStock.Location = new Point(82, 109);
            txtModificarStock.Name = "txtModificarStock";
            txtModificarStock.Size = new Size(162, 23);
            txtModificarStock.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 112);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Stock:";
            // 
            // txtModificarMarca
            // 
            txtModificarMarca.Location = new Point(82, 80);
            txtModificarMarca.Name = "txtModificarMarca";
            txtModificarMarca.Size = new Size(162, 23);
            txtModificarMarca.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 83);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 4;
            label8.Text = "Marca:";
            // 
            // txtModificarModelo
            // 
            txtModificarModelo.Location = new Point(82, 51);
            txtModificarModelo.Name = "txtModificarModelo";
            txtModificarModelo.Size = new Size(162, 23);
            txtModificarModelo.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 54);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 2;
            label9.Text = "Modelo:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Tomato;
            groupBox2.Controls.Add(txtEliminarMarca);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtEliminarID);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(btnEliminarProducto);
            groupBox2.Controls.Add(txtEliminarModelo);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(12, 461);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 151);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Producto";
            // 
            // txtEliminarMarca
            // 
            txtEliminarMarca.Enabled = false;
            txtEliminarMarca.Location = new Point(80, 80);
            txtEliminarMarca.Name = "txtEliminarMarca";
            txtEliminarMarca.Size = new Size(162, 23);
            txtEliminarMarca.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 83);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 16;
            label14.Text = "Marca:";
            // 
            // txtEliminarID
            // 
            txtEliminarID.Enabled = false;
            txtEliminarID.Location = new Point(80, 22);
            txtEliminarID.Name = "txtEliminarID";
            txtEliminarID.Size = new Size(162, 23);
            txtEliminarID.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 25);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 14;
            label13.Text = "Id Producto:";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(6, 109);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(238, 23);
            btnEliminarProducto.TabIndex = 13;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // txtEliminarModelo
            // 
            txtEliminarModelo.Enabled = false;
            txtEliminarModelo.Location = new Point(80, 51);
            txtEliminarModelo.Name = "txtEliminarModelo";
            txtEliminarModelo.Size = new Size(162, 23);
            txtEliminarModelo.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 54);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 13;
            label10.Text = "Modelo:";
            // 
            // radioSinStock
            // 
            radioSinStock.AutoSize = true;
            radioSinStock.Location = new Point(105, 18);
            radioSinStock.Name = "radioSinStock";
            radioSinStock.Size = new Size(73, 19);
            radioSinStock.TabIndex = 15;
            radioSinStock.Text = "Sin Stock";
            radioSinStock.UseVisualStyleBackColor = true;
            radioSinStock.CheckedChanged += radioSinStock_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(radioTodos);
            groupBox3.Controls.Add(cbCategorias);
            groupBox3.Controls.Add(radioConStock);
            groupBox3.Controls.Add(radioSinStock);
            groupBox3.Location = new Point(274, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(890, 46);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtros de Productos Mostrados";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(599, 22);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 13;
            label12.Text = "Categoría:";
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Checked = true;
            radioTodos.Location = new Point(6, 18);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(56, 19);
            radioTodos.TabIndex = 17;
            radioTodos.TabStop = true;
            radioTodos.Text = "Todos";
            radioTodos.UseVisualStyleBackColor = true;
            radioTodos.CheckedChanged += radioTodos_CheckedChanged;
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(666, 17);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(205, 23);
            cbCategorias.TabIndex = 0;
            cbCategorias.SelectedIndexChanged += cbCategorias_SelectedIndexChanged;
            // 
            // radioConStock
            // 
            radioConStock.AutoSize = true;
            radioConStock.Location = new Point(228, 18);
            radioConStock.Name = "radioConStock";
            radioConStock.Size = new Size(79, 19);
            radioConStock.TabIndex = 16;
            radioConStock.Text = "Con Stock";
            radioConStock.UseVisualStyleBackColor = true;
            radioConStock.CheckedChanged += radioConStock_CheckedChanged;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1176, 619);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Productos);
            Controls.Add(gb_AltaProductos);
            Name = "Compras";
            Text = "Compras";
            Load += Compras_Load;
            gb_AltaProductos.ResumeLayout(false);
            gb_AltaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gb_AltaProductos;
        private TextBox txt_Marca;
        private Label label3;
        private TextBox txt_Modelo;
        private Label Modelo;
        private TextBox txt_Precio;
        private TextBox txt_Stock;
        private Label label4;
        private TextBox txt_Categoria;
        private Button btnAltaProducto;
        private Label label5;
        private Label label2;
        private DataGridView dgv_Productos;
        private GroupBox groupBox1;
        private Button btnModificarProducto;
        private Label label1;
        private Label label6;
        private TextBox txtModificarCategoria;
        private TextBox txtModificarPrecio;
        private TextBox txtModificarStock;
        private Label label7;
        private TextBox txtModificarMarca;
        private Label label8;
        private TextBox txtModificarModelo;
        private Label label9;
        private GroupBox groupBox2;
        private Button btnEliminarProducto;
        private TextBox txtEliminarModelo;
        private Label label10;
        private Label label11;
        private TextBox txtModificarId;
        private RadioButton radioSinStock;
        private GroupBox groupBox3;
        private RadioButton radioConStock;
        private RadioButton radioTodos;
        private Label label12;
        private ComboBox cbCategorias;
        private TextBox txtEliminarMarca;
        private Label label14;
        private TextBox txtEliminarID;
        private Label label13;
    }
}