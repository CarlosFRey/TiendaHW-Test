namespace UI
{
    partial class Clientes
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
            label1 = new Label();
            dgvClientes = new DataGridView();
            groupBox1 = new GroupBox();
            btnAltaCliente = new Button();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtCUILCUIT = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(420, 45);
            label1.TabIndex = 0;
            label1.Text = "Administración de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(173, 77);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(617, 361);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAltaCliente);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCUILCUIT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(4, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 361);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Nuevo Cliente";
            // 
            // btnAltaCliente
            // 
            btnAltaCliente.Location = new Point(5, 320);
            btnAltaCliente.Name = "btnAltaCliente";
            btnAltaCliente.Size = new Size(154, 35);
            btnAltaCliente.TabIndex = 12;
            btnAltaCliente.Text = "Registrar Cliente";
            btnAltaCliente.UseVisualStyleBackColor = true;
            btnAltaCliente.Click += btnAltaCliente_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(8, 257);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(151, 23);
            txtDireccion.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 239);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 10;
            label7.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(8, 213);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 23);
            txtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 195);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(8, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 23);
            txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 151);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // txtCUILCUIT
            // 
            txtCUILCUIT.Location = new Point(6, 125);
            txtCUILCUIT.Name = "txtCUILCUIT";
            txtCUILCUIT.Size = new Size(151, 23);
            txtCUILCUIT.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 4;
            label4.Text = "CUIL / CUIT:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(6, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(151, 23);
            txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 59);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            Controls.Add(dgvClientes);
            Controls.Add(label1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvClientes;
        private GroupBox groupBox1;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtCUILCUIT;
        private Label label4;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDireccion;
        private Label label7;
        private Button btnSalir;
        private Button btnAltaCliente;
    }
}