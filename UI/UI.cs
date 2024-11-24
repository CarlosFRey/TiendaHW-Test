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

        public static object Properties { get; internal set; }

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
            Image imgTacho = Image.FromFile("logo.png");
            pblogo.BackgroundImage = imgTacho;
            pblogo.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
