namespace pryCafeteriaUTHH
{
    partial class frmNuevoEmp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtConsultar = new TextBox();
            dgvUsuarios = new DataGridView();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            txtAmaterno = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtApaterno = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            cmbRoles = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtConsultar
            // 
            txtConsultar.Font = new Font("Segoe UI", 14F);
            txtConsultar.Location = new Point(1432, 310);
            txtConsultar.Name = "txtConsultar";
            txtConsultar.PlaceholderText = "Ingresa el proveedor a buscar";
            txtConsultar.Size = new Size(269, 32);
            txtConsultar.TabIndex = 25;
            txtConsultar.TabStop = false;
            txtConsultar.TextChanged += txtConsultar_TextChanged;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.BackgroundColor = Color.FromArgb(239, 228, 210);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.GridColor = Color.FromArgb(239, 228, 210);
            dgvUsuarios.Location = new Point(203, 367);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.Size = new Size(1498, 337);
            dgvUsuarios.TabIndex = 23;
            dgvUsuarios.TabStop = false;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.KeyDown += dgvUsuarios_KeyDown;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1071, 210);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 50);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(811, 210);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(235, 50);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(551, 210);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(235, 50);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtAmaterno
            // 
            txtAmaterno.Font = new Font("Segoe UI", 14F);
            txtAmaterno.Location = new Point(443, 139);
            txtAmaterno.Name = "txtAmaterno";
            txtAmaterno.Size = new Size(235, 32);
            txtAmaterno.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14F);
            txtCorreo.Location = new Point(819, 139);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(235, 32);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14F);
            txtTelefono.Location = new Point(819, 25);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(235, 32);
            txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14F);
            txtDireccion.Location = new Point(819, 82);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(235, 32);
            txtDireccion.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(443, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 32);
            txtNombre.TabIndex = 1;
            // 
            // txtApaterno
            // 
            txtApaterno.Font = new Font("Segoe UI", 14F);
            txtApaterno.Location = new Point(443, 82);
            txtApaterno.Name = "txtApaterno";
            txtApaterno.Size = new Size(235, 32);
            txtApaterno.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(713, 82);
            label7.Name = "label7";
            label7.Size = new Size(100, 30);
            label7.TabIndex = 17;
            label7.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(713, 139);
            label6.Name = "label6";
            label6.Size = new Size(75, 30);
            label6.TabIndex = 16;
            label6.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(713, 25);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 15;
            label5.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 141);
            label4.Name = "label4";
            label4.Size = new Size(173, 30);
            label4.TabIndex = 14;
            label4.Text = "Apellido materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 84);
            label3.Name = "label3";
            label3.Size = new Size(167, 30);
            label3.TabIndex = 19;
            label3.Text = "Apellido paterno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(311, 27);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 13;
            label2.Text = "Nombre(s)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1073, 23);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 16;
            label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(1197, 23);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(235, 32);
            txtPassword.TabIndex = 7;
            // 
            // cmbRoles
            // 
            cmbRoles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.ItemHeight = 25;
            cmbRoles.Location = new Point(1197, 80);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(235, 33);
            cmbRoles.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1071, 85);
            label8.Name = "label8";
            label8.Size = new Size(42, 30);
            label8.TabIndex = 16;
            label8.Text = "Rol";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1465, 25);
            label9.Name = "label9";
            label9.Size = new Size(197, 42);
            label9.TabIndex = 28;
            label9.Text = "Control + N para agregar \r\nun nuevo usuario";
            // 
            // frmNuevoEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1904, 728);
            Controls.Add(label9);
            Controls.Add(cmbRoles);
            Controls.Add(txtConsultar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtAmaterno);
            Controls.Add(txtPassword);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtApaterno);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            KeyPreview = true;
            Name = "frmNuevoEmp";
            Text = "frmNuevoEmp";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConsultar;
        private DataGridView dgvUsuarios;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private TextBox txtAmaterno;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtApaterno;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private ComboBox cmbRoles;
        private Label label8;
        private Label label9;
    }
}