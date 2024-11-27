namespace UI
{
    partial class UI_Administrador
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
            groupBox1 = new GroupBox();
            btnEncriptar = new Button();
            txtTextoEncriptado = new TextBox();
            txtTextoPlano = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEncriptar);
            groupBox1.Controls.Add(txtTextoEncriptado);
            groupBox1.Controls.Add(txtTextoPlano);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encriptador";
            // 
            // btnEncriptar
            // 
            btnEncriptar.Location = new Point(340, 15);
            btnEncriptar.Name = "btnEncriptar";
            btnEncriptar.Size = new Size(75, 23);
            btnEncriptar.TabIndex = 4;
            btnEncriptar.Text = "Encriptar";
            btnEncriptar.UseVisualStyleBackColor = true;
            btnEncriptar.Click += btnEncriptar_Click;
            // 
            // txtTextoEncriptado
            // 
            txtTextoEncriptado.Location = new Point(110, 45);
            txtTextoEncriptado.Name = "txtTextoEncriptado";
            txtTextoEncriptado.Size = new Size(309, 23);
            txtTextoEncriptado.TabIndex = 3;
            // 
            // txtTextoPlano
            // 
            txtTextoPlano.Location = new Point(109, 16);
            txtTextoPlano.Name = "txtTextoPlano";
            txtTextoPlano.Size = new Size(225, 23);
            txtTextoPlano.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Texto Encriptado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto a Encriptar:";
            // 
            // UI_Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 618);
            Controls.Add(groupBox1);
            Name = "UI_Administrador";
            Text = "UI_Administrador";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEncriptar;
        private TextBox txtTextoEncriptado;
        private TextBox txtTextoPlano;
        private Label label2;
        private Label label1;
    }
}