using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace UI
{
    public partial class UI_Administrador : Form
    {
        public UI_Administrador()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTextoPlano.Text) || txtTextoPlano.Text.Length >64) { throw new Exception("Verifique el campo Texto a encriptar, no puede ser nulo y debe ser menor a 64 caracteres"); }
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(txtTextoPlano.Text);

                // Calcular el hash SHA256
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convertir el arreglo de bytes a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // "x2" para formato hexadecimal de dos dígitos
                }
                txtTextoEncriptado.Text = sb.ToString();
            }
        }
    }
}
