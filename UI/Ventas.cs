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
    public partial class Ventas : Form
    {
        private static Form FormularioActivo = null;
        public Ventas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnRegistrarCliente = new Button();
            btnGestorCarritos = new Button();
            label1 = new Label();
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker2 = new BackgroundWorker();
            btnCobrarVenta = new Button();
            btnGenerarRemito = new Button();
            groupBox1 = new GroupBox();
            PanelVentas = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(267, 13);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(81, 41);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnGestorCarritos
            // 
            btnGestorCarritos.Location = new Point(180, 14);
            btnGestorCarritos.Name = "btnGestorCarritos";
            btnGestorCarritos.Size = new Size(81, 41);
            btnGestorCarritos.TabIndex = 1;
            btnGestorCarritos.Text = "Gestor Carritos";
            btnGestorCarritos.UseVisualStyleBackColor = true;
            btnGestorCarritos.Click += btnGestorCarritos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(298, 42);
            label1.TabIndex = 2;
            label1.Text = "Gestión de Ventas";
            // 
            // btnCobrarVenta
            // 
            btnCobrarVenta.Location = new Point(93, 14);
            btnCobrarVenta.Name = "btnCobrarVenta";
            btnCobrarVenta.Size = new Size(81, 41);
            btnCobrarVenta.TabIndex = 3;
            btnCobrarVenta.Text = "Facturar Venta";
            btnCobrarVenta.UseVisualStyleBackColor = true;
            // 
            // btnGenerarRemito
            // 
            btnGenerarRemito.Location = new Point(6, 14);
            btnGenerarRemito.Name = "btnGenerarRemito";
            btnGenerarRemito.Size = new Size(81, 41);
            btnGenerarRemito.TabIndex = 4;
            btnGenerarRemito.Text = "Generar Remito";
            btnGenerarRemito.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(btnGenerarRemito);
            groupBox1.Controls.Add(btnCobrarVenta);
            groupBox1.Controls.Add(btnRegistrarCliente);
            groupBox1.Controls.Add(btnGestorCarritos);
            groupBox1.Location = new Point(806, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 55);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu de Casos de Uso";
            // 
            // PanelVentas
            // 
            PanelVentas.Location = new Point(-1, 85);
            PanelVentas.Name = "PanelVentas";
            PanelVentas.Size = new Size(1176, 555);
            PanelVentas.TabIndex = 6;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-1, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 10);
            panel1.TabIndex = 7;
            // 
            // Ventas
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(1179, 639);
            Controls.Add(panel1);
            Controls.Add(PanelVentas);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Ventas";
            Load += Ventas_Load;
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnRegistrarCliente;
        private Button btnGestorCarritos;
        private BackgroundWorker backgroundWorker1;
        private BackgroundWorker backgroundWorker2;
        private Button btnCobrarVenta;
        private Button btnGenerarRemito;
        private GroupBox groupBox1;
        private Panel PanelVentas;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel1;
        private Label label1;

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Clientes formClientes = new Clientes();
            formClientes.Show();
        }

        private void btnGestorCarritos_Click(object sender, EventArgs e)
        {
            CompletarCarrito gestorCarritos = new CompletarCarrito();
            AbrirFormulario(gestorCarritos);
        }

        private void AbrirFormulario(Form formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.White;

            PanelVentas.Controls.Add(formulario);
            formulario.Show();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }
    }
}
