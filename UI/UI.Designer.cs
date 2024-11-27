namespace UI
{
    partial class UI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Contenedor = new Panel();
            panel1 = new Panel();
            btnLogout = new Button();
            lblRolUsuario = new Label();
            lblNombreUsuario = new Label();
            label2 = new Label();
            label1 = new Label();
            pblogo = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            SuspendLayout();
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.Transparent;
            Contenedor.Location = new Point(-2, 96);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1200, 619);
            Contenedor.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblRolUsuario);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pblogo);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 90);
            panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.CornflowerBlue;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1106, 45);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 31);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.BackColor = Color.Transparent;
            lblRolUsuario.Font = new Font("Imprint MT Shadow", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRolUsuario.ForeColor = Color.CornflowerBlue;
            lblRolUsuario.Location = new Point(563, 53);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(23, 34);
            lblRolUsuario.TabIndex = 8;
            lblRolUsuario.Text = ".";
            lblRolUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Imprint MT Shadow", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNombreUsuario.ForeColor = Color.DodgerBlue;
            lblNombreUsuario.Location = new Point(563, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(23, 34);
            lblNombreUsuario.TabIndex = 7;
            lblNombreUsuario.Text = ".";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Imprint MT Shadow", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(460, 53);
            label2.Name = "label2";
            label2.Size = new Size(97, 34);
            label2.TabIndex = 6;
            label2.Text = "Perfil:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Imprint MT Shadow", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(382, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 34);
            label1.TabIndex = 5;
            label1.Text = "Bienvenido:";
            label1.Click += label1_Click;
            // 
            // pblogo
            // 
            pblogo.BackgroundImageLayout = ImageLayout.Stretch;
            pblogo.Location = new Point(3, 3);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(215, 84);
            pblogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pblogo.TabIndex = 4;
            pblogo.TabStop = false;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1194, 711);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Name = "UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUG+MDS2 - Test";
            Load += UI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Contenedor;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pblogo;
        private Label label1;
        private Label lblRolUsuario;
        private Label lblNombreUsuario;
        private Label label2;
        private Button btnLogout;
    }
}
