namespace pryCafeteriaUTHH
{
    partial class frmRoles
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
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            label2 = new Label();
            dgvRoles = new DataGridView();
            label1 = new Label();
            txtRoles = new TextBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1135, 119);
            label2.Name = "label2";
            label2.Size = new Size(288, 21);
            label2.TabIndex = 16;
            label2.Text = "Control + N para agregar un nuevo rol";
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            dgvRoles.BackgroundColor = Color.FromArgb(239, 228, 210);
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle27.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle27.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Window;
            dataGridViewCellStyle28.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle28.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            dgvRoles.DefaultCellStyle = dataGridViewCellStyle28;
            dgvRoles.Location = new Point(690, 307);
            dgvRoles.Name = "dgvRoles";
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle29.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.BackColor = Color.White;
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle30.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle30.SelectionForeColor = Color.White;
            dgvRoles.RowsDefaultCellStyle = dataGridViewCellStyle30;
            dgvRoles.Size = new Size(541, 392);
            dgvRoles.TabIndex = 12;
            dgvRoles.CellClick += dgvRoles_CellClick;
            dgvRoles.KeyDown += dgvRoles_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(741, 110);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 11;
            label1.Text = "Roles";
            // 
            // txtRoles
            // 
            txtRoles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoles.Location = new Point(828, 107);
            txtRoles.Name = "txtRoles";
            txtRoles.Size = new Size(235, 33);
            txtRoles.TabIndex = 10;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1088, 207);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 50);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar rol";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(828, 207);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(235, 50);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar rol";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.badge_plus__1_1;
            btnAgregar.Location = new Point(568, 207);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(235, 50);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "  Añadir rol";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1904, 728);
            Controls.Add(label2);
            Controls.Add(dgvRoles);
            Controls.Add(label1);
            Controls.Add(txtRoles);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            KeyPreview = true;
            Name = "frmRoles";
            Text = "frmRoles";
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvRoles;
        private Label label1;
        private TextBox txtRoles;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
    }
}