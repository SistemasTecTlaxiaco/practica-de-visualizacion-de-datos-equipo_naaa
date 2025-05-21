namespace BaseDatos_PRACTICA2
{
    partial class Form2
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
            labelNombre = new Label();
            labelApP = new Label();
            labelApM = new Label();
            labelEdad = new Label();
            labelDep = new Label();
            labelPuesto = new Label();
            labelEmail = new Label();
            labelTel = new Label();
            textBoxAp1 = new TextBox();
            textBoxAp2 = new TextBox();
            textBoxEdad = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDep = new TextBox();
            textBoxPuesto = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTel = new TextBox();
            dataGridView1 = new DataGridView();
            id_Trabajador = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido_P = new DataGridViewTextBoxColumn();
            Apellido_M = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            buttonBuscar = new Button();
            btnInsetar = new Button();
            Eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(35, 45);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(83, 19);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "NOMBRE: ";
            labelNombre.Click += label1_Click;
            // 
            // labelApP
            // 
            labelApP.AutoSize = true;
            labelApP.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApP.Location = new Point(35, 117);
            labelApP.Name = "labelApP";
            labelApP.Size = new Size(166, 19);
            labelApP.TabIndex = 1;
            labelApP.Text = "APELLIDO PATERNO: ";
            // 
            // labelApM
            // 
            labelApM.AutoSize = true;
            labelApM.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApM.Location = new Point(35, 185);
            labelApM.Name = "labelApM";
            labelApM.Size = new Size(168, 19);
            labelApM.TabIndex = 2;
            labelApM.Text = "APELLIDO MATERNO: ";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdad.Location = new Point(35, 265);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(54, 19);
            labelEdad.TabIndex = 3;
            labelEdad.Text = "EDAD:";
            labelEdad.Click += label3_Click;
            // 
            // labelDep
            // 
            labelDep.AutoSize = true;
            labelDep.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDep.Location = new Point(750, 45);
            labelDep.Name = "labelDep";
            labelDep.Size = new Size(133, 19);
            labelDep.TabIndex = 4;
            labelDep.Text = "DEPARTAMENTO:";
            // 
            // labelPuesto
            // 
            labelPuesto.AutoSize = true;
            labelPuesto.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPuesto.Location = new Point(750, 117);
            labelPuesto.Name = "labelPuesto";
            labelPuesto.Size = new Size(77, 19);
            labelPuesto.TabIndex = 5;
            labelPuesto.Text = "PUESTO: ";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(750, 185);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 19);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "EMAIL:";
            // 
            // labelTel;
            // 
            labelTel.AutoSize = true;
            labelTel.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTel.Location = new Point(750, 265);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(90, 19);
            labelTel.TabIndex = 7;
            labelTel.Text = "TELEFONO:";
            // 
            // textBoxAp1
            // 
            textBoxAp1.BackColor = SystemColors.InactiveCaption;
            textBoxAp1.Location = new Point(233, 109);
            textBoxAp1.Name = "textBoxAp1";
            textBoxAp1.Size = new Size(401, 25);
            textBoxAp1.TabIndex = 9;
            textBoxAp1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxAp2
            // 
            textBoxAp2.BackColor = SystemColors.InactiveCaption;
            textBoxAp2.Location = new Point(233, 185);
            textBoxAp2.Name = "textBoxAp2";
            textBoxAp2.Size = new Size(401, 25);
            textBoxAp2.TabIndex = 10;
            // 
            // textBoxEdad
            // 
            textBoxEdad.BackColor = SystemColors.InactiveCaption;
            textBoxEdad.Location = new Point(233, 257);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(401, 25);
            textBoxEdad.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.InactiveCaption;
            textBoxNombre.Location = new Point(233, 40);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(401, 25);
            textBoxNombre.TabIndex = 12;
            textBoxNombre.TextChanged += textBox4_TextChanged;
            // 
            // textBoxDep
            // 
            textBoxDep.BackColor = SystemColors.InactiveCaption;
            textBoxDep.Location = new Point(935, 40);
            textBoxDep.Name = "textBoxDep";
            textBoxDep.Size = new Size(401, 25);
            textBoxDep.TabIndex = 13;
            // 
            // textBoxPuesto
            // 
            textBoxPuesto.BackColor = SystemColors.InactiveCaption;
            textBoxPuesto.Location = new Point(935, 112);
            textBoxPuesto.Name = "textBoxPuesto";
            textBoxPuesto.Size = new Size(401, 25);
            textBoxPuesto.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.InactiveCaption;
            textBoxEmail.Location = new Point(935, 180);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(401, 25);
            textBoxEmail.TabIndex = 15;
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = SystemColors.InactiveCaption;
            textBoxTel.Location = new Point(935, 257);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(401, 25);
            textBoxTel.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_Trabajador, Nombre, Apellido_P, Apellido_M, Edad, Departamento, Email, Tel });
            dataGridView1.Location = new Point(61, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1265, 207);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // 
            // id_Trabajador
            // 
            id_Trabajador.HeaderText = "Id";
            id_Trabajador.MinimumWidth = 8;
            id_Trabajador.Name = "id_Trabajador";
            id_Trabajador.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "NOMBRE";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido_P
            // 
            Apellido_P.HeaderText = "APELLIDO PATERNO";
            Apellido_P.MinimumWidth = 8;
            Apellido_P.Name = "Apellido_P";
            Apellido_P.Width = 150;
            // 
            // Apellido_M
            // 
            Apellido_M.HeaderText = "APELLIDO MATERNO";
            Apellido_M.MinimumWidth = 8;
            Apellido_M.Name = "Apellido_M";
            Apellido_M.Width = 150;
            // 
            // Edad
            // 
            Edad.HeaderText = "EDAD";
            Edad.MinimumWidth = 8;
            Edad.Name = "Edad";
            Edad.Width = 150;
            // 
            // Departamento
            // 
            Departamento.HeaderText = "DEPARTAMENTO";
            Departamento.MinimumWidth = 8;
            Departamento.Name = "Departamento";
            Departamento.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "EMAIL";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Tel
            // 
            Tel.HeaderText = "TELEFONO";
            Tel.MinimumWidth = 8;
            Tel.Name = "Tel";
            Tel.Width = 150;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.GradientInactiveCaption;
            buttonBuscar.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.Location = new Point(61, 663);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(149, 58);
            buttonBuscar.TabIndex = 18;
            buttonBuscar.Text = "BUSCAR";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // btnInsetar
            // 
            btnInsetar.BackColor = SystemColors.GradientInactiveCaption;
            btnInsetar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsetar.Location = new Point(302, 663);
            btnInsetar.Name = "btnInsetar";
            btnInsetar.Size = new Size(149, 58);
            btnInsetar.TabIndex = 19;
            btnInsetar.Text = "INSERTAR";
            btnInsetar.UseVisualStyleBackColor = false;
            btnInsetar.Click += btnInsetar_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = SystemColors.GradientInactiveCaption;
            Eliminar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Eliminar.Location = new Point(521, 663);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(149, 58);
            Eliminar.TabIndex = 20;
            Eliminar.Text = "ELIMINAR";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1370, 749);
            Controls.Add(Eliminar);
            Controls.Add(btnInsetar);
            Controls.Add(buttonBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxTel);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPuesto);
            Controls.Add(textBoxDep);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxAp2);
            Controls.Add(textBoxAp1);
            Controls.Add(labelTel);
            Controls.Add(labelEmail);
            Controls.Add(labelPuesto);
            Controls.Add(labelDep);
            Controls.Add(labelEdad);
            Controls.Add(labelApM);
            Controls.Add(labelApP);
            Controls.Add(labelNombre);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelApP;
        private Label labelApM;
        private Label labelEdad;
        private Label labelDep;
        private Label labelPuesto;
        private Label labelEmail;
        private Label labelTel;
        private TextBox textBoxAp1;
        private TextBox textBoxAp2;
        private TextBox textBoxEdad;
        private TextBox textBoxNombre;
        private TextBox textBoxDep;
        private TextBox textBoxPuesto;
        private TextBox textBoxEmail;
        private TextBox textBoxTel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_Trabajador;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido_P;
        private DataGridViewTextBoxColumn Apellido_M;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Tel;
        private Button buttonBuscar;
        private Button btnInsetar;
        private Button Eliminar;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}