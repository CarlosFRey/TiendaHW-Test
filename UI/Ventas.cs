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
            btnRegistrarCliente.BackColor = Color.LightSteelBlue;
            btnRegistrarCliente.Cursor = Cursors.Hand;
            btnRegistrarCliente.ForeColor = Color.Black;
            btnRegistrarCliente.Location = new Point(267, 13);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(81, 41);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnGestorCarritos
            // 
            btnGestorCarritos.BackColor = Color.LightSteelBlue;
            btnGestorCarritos.Cursor = Cursors.Hand;
            btnGestorCarritos.ForeColor = Color.Black;
            btnGestorCarritos.Location = new Point(180, 14);
            btnGestorCarritos.Name = "btnGestorCarritos";
            btnGestorCarritos.Size = new Size(81, 41);
            btnGestorCarritos.TabIndex = 1;
            btnGestorCarritos.Text = "Gestor Carritos";
            btnGestorCarritos.UseVisualStyleBackColor = false;
            btnGestorCarritos.Click += btnGestorCarritos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(269, 39);
            label1.TabIndex = 2;
            label1.Text = "Gestión de Ventas";
            // 
            // btnCobrarVenta
            // 
            btnCobrarVenta.BackColor = Color.LightSteelBlue;
            btnCobrarVenta.Cursor = Cursors.Hand;
            btnCobrarVenta.ForeColor = Color.Black;
            btnCobrarVenta.Location = new Point(93, 14);
            btnCobrarVenta.Name = "btnCobrarVenta";
            btnCobrarVenta.Size = new Size(81, 41);
            btnCobrarVenta.TabIndex = 3;
            btnCobrarVenta.Text = "Facturar Venta";
            btnCobrarVenta.UseVisualStyleBackColor = false;
            // 
            // btnGenerarRemito
            // 
            btnGenerarRemito.BackColor = Color.LightSteelBlue;
            btnGenerarRemito.Cursor = Cursors.Hand;
            btnGenerarRemito.ForeColor = Color.Black;
            btnGenerarRemito.Location = new Point(6, 14);
            btnGenerarRemito.Name = "btnGenerarRemito";
            btnGenerarRemito.Size = new Size(81, 41);
            btnGenerarRemito.TabIndex = 4;
            btnGenerarRemito.Text = "Generar Remito";
            btnGenerarRemito.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnGenerarRemito);
            groupBox1.Controls.Add(btnCobrarVenta);
            groupBox1.Controls.Add(btnRegistrarCliente);
            groupBox1.Controls.Add(btnGestorCarritos);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(823, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 67);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu de Casos de Uso";
            // 
            // PanelVentas
            // 
            PanelVentas.Location = new Point(-1, 76);
            PanelVentas.Name = "PanelVentas";
            PanelVentas.Size = new Size(1187, 564);
            PanelVentas.TabIndex = 6;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(2, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 10);
            panel1.TabIndex = 7;
            // 
            // Ventas
            // 
            BackColor = Color.Black;
            ClientSize = new Size(1189, 639);
            Controls.Add(PanelVentas);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
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
