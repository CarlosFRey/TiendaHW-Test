using Entidades;

namespace UI
{
    public partial class UI : Form
    {
        private static Form FormularioActivo = null;
        private static Usuario usuarioActivo;
        public UI(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            usuarioActivo = usuarioLogueado;
        }

        public static object Properties { get; internal set; }
        private void UI_Load(object sender, EventArgs e)
        {
            Image imgTacho = Image.FromFile("logo.png");
            pblogo.BackgroundImage = imgTacho;
            pblogo.BackgroundImageLayout = ImageLayout.Stretch;
            lblNombreUsuario.Text = usuarioActivo.NombreCompleto.ToString();
            lblRolUsuario.Text = usuarioActivo.Rol.Descripcion;
            switch (Convert.ToInt32(usuarioActivo.Rol.IdRol))
            {
                case 1:
                    AbrirFormulario(new UI_Administrador());
                    break;
                case 2:
                    AbrirFormulario(new CompletarCarrito());
                    break;
                case 3: // Corregir la sintaxis del case
                    AbrirFormulario(new Compras());
                    break; // Agregar break para evitar que pase al default
                case 4:
                    AbrirFormulario(new UIxContable());
                    break;
                default:
                    this.Close(); // Cerrar el formulario actual si no es el rol esperado
                    break;
            }


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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
