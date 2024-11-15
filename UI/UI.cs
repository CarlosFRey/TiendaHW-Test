namespace UI
{
    public partial class UI : Form
    {
        private static Form FormularioActivo = null;
        public UI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnGestionCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Compras());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Ventas());
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }
    }
}
