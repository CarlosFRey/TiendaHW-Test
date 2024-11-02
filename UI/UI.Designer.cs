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
            button1 = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.Silver;
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGestionCompras);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 90);
            panel1.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(732, 55);
            label1.TabIndex = 2;
            label1.Text = "Sistema de pruebas LUG + MDS 2";
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 711);
            Controls.Add(panel1);
            Controls.Add(Contenedor);
            Name = "UI";
            Text = "LUG+MDS2 - Test";
            Load += UI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Contenedor;
        private Button btnGestionCompras;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
