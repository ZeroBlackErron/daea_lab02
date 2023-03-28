namespace WinFormsApp1
{
    partial class manUsuario
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
            panel1 = new Panel();
            dtFechaNacimiento = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            btnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            this.dgvUsuarios2 = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvUsuarios2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtFechaNacimiento);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtDni);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 144);
            panel1.TabIndex = 0;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtFechaNacimiento.Location = new Point(342, 10);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(84, 23);
            dtFechaNacimiento.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(300, 74);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 12;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 42);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 13);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 10;
            label5.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 108);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 79);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 50);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 19);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 6;
            label1.Text = "DNI";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(342, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(342, 39);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(186, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(74, 105);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(454, 23);
            txtDireccion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(74, 71);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(159, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(74, 13);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(234, 162);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 162);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(396, 162);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(477, 162);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios2
            // 
            this.dgvUsuarios2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios2.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, apellido, telefono, email, fechaNacimiento, direccion });
            this.dgvUsuarios2.Location = new Point(12, 191);
            this.dgvUsuarios2.Name = "dgvUsuarios";
            this.dgvUsuarios2.RowTemplate.Height = 25;
            this.dgvUsuarios2.Size = new Size(540, 182);
            this.dgvUsuarios2.TabIndex = 6;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.HeaderText = "Fecha Nacimiento";
            fechaNacimiento.Name = "fechaNacimiento";
            // 
            // direccion
            // 
            direccion.HeaderText = "Dirección";
            direccion.Name = "direccion";
            // 
            // manUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 385);
            Controls.Add(this.dgvUsuarios2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            Name = "manUsuario";
            Text = "manUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvUsuarios2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DateTimePicker dtFechaNacimiento;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtDni;
        private DataGridView dgvUsuarios;
        private Button btnAgregar;
        private DataGridView dgvUsuarios2;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn direccion;
    }
}