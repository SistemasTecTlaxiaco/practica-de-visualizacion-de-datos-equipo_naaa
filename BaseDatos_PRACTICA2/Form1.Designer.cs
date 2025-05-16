namespace BaseDatos_PRACTICA2
{
    partial class Form1
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
            textoUsuario = new TextBox();
            textoContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Acceder = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textoUsuario
            // 
            textoUsuario.Location = new Point(277, 144);
            textoUsuario.Name = "textoUsuario";
            textoUsuario.Size = new Size(316, 27);
            textoUsuario.TabIndex = 0;
            // 
            // textoContrasena
            // 
            textoContrasena.Location = new Point(277, 241);
            textoContrasena.Name = "textoContrasena";
            textoContrasena.Size = new Size(316, 27);
            textoContrasena.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 151);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 248);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // Acceder
            // 
            Acceder.BackColor = Color.PaleGreen;
            Acceder.Location = new Point(623, 435);
            Acceder.Name = "Acceder";
            Acceder.Size = new Size(94, 29);
            Acceder.TabIndex = 4;
            Acceder.Text = "ACEPTAR";
            Acceder.UseVisualStyleBackColor = false;
            Acceder.Click += Acceder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 330);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(781, 578);
            Controls.Add(label3);
            Controls.Add(Acceder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textoContrasena);
            Controls.Add(textoUsuario);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textoUsuario;
        private TextBox textoContrasena;
        private Label label1;
        private Label label2;
        private Button Acceder;
        private Label label3;
    }
}
