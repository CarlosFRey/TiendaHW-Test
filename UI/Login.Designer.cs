namespace UI
{
    partial class Login
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
            lblLogo = new Label();
            pbLogo = new PictureBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.Black;
            lblLogo.Dock = DockStyle.Left;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(198, 194);
            lblLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Black;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(175, 169);
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(224, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(224, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(173, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(224, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuario:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(224, 79);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(224, 137);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(322, 137);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(425, 194);
            Controls.Add(btnCancelar);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtPassword);
            Controls.Add(pbLogo);
            Controls.Add(lblLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
        private PictureBox pbLogo;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button btnCancelar;
    }
}