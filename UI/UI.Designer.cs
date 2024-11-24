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
            btnGestionCompras = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pblogo = new PictureBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.Transparent;
            Contenedor.Location = new Point(-2, 96);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1187, 619);
            Contenedor.TabIndex = 0;
            // 
            // btnGestionCompras
            // 
            btnGestionCompras.BackColor = Color.LightSteelBlue;
            btnGestionCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionCompras.Location = new Point(1069, 16);
            btnGestionCompras.Name = "btnGestionCompras";
            btnGestionCompras.Size = new Size(105, 64);
            btnGestionCompras.TabIndex = 1;
            btnGestionCompras.Text = "Gestión de Compras";
            btnGestionCompras.UseVisualStyleBackColor = false;
            btnGestionCompras.Click += btnGestionCompras_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pblogo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnGestionCompras);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 90);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(333, 7);
            label1.Name = "label1";
            label1.Size = new Size(534, 80);
            label1.TabIndex = 5;
            label1.Text = "Gestión Comercial";
            label1.Click += label1_Click;
            // 
            // pblogo
            // 
            pblogo.BackgroundImageLayout = ImageLayout.Stretch;
            pblogo.Location = new Point(3, 3);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(254, 84);
            pblogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pblogo.TabIndex = 4;
            pblogo.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(958, 16);
            button1.Name = "button1";
            button1.Size = new Size(105, 64);
            button1.TabIndex = 3;
            button1.Text = "Gestión de Ventas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(-2, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1190, 10);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 711);
            Controls.Add(Contenedor);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUG+MDS2 - Test";
            Load += UI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Contenedor;
        private Button btnGestionCompras;
        private Panel panel1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pblogo;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
