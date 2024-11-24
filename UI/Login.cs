using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;
using Entidades;

namespace UI
{
    public partial class Login : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Image logo = Image.FromFile("LogoChico.png");
            pbLogo.BackgroundImage = logo;
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsuario.Text)) { MessageBox.Show("Los campos usuario y contraseña deben tener valores");}
            else 
            {
                //método linq
                //usuario = new UsuarioBLL().getUsuarios().Where(u => u.DNI == Convert.ToInt32(txtUsuario.Text) && u.Clave == txtPassword.Text).FirstOrDefault(); 
                //si fuera manual
                usuario = usuarioBLL.validarLogin(Convert.ToInt32(txtUsuario.Text), txtPassword.Text);
            }
            
            if (usuario.Clave != null)
            {
                UI formUI = new UI();
                formUI.Show();
                this.Hide();
                formUI.FormClosing += UI_closing;
            }
            else
            {
                MessageBox.Show("Los datos no corresponden a un usuario válido");
            }

        }
        private void UI_closing(object sender, FormClosingEventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            this.Show();
        }
    }
}
