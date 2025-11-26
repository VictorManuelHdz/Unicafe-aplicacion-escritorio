namespace pryCafeteriaUTHH
{
    partial class frmSucursal
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
            dgvSucursal = new DataGridView();
            label2 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            txtSucursal = new TextBox();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSucursal).BeginInit();
            SuspendLayout();
            // 
            // dgvSucursal
            // 
            dgvSucursal.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvSucursal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSucursal.BackgroundColor = Color.FromArgb(239, 228, 210);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursal.GridColor = Color.FromArgb(233, 237, 201);
            dgvSucursal.Location = new Point(690, 307);
            dgvSucursal.Name = "dgvSucursal";
            dgvSucursal.ReadOnly = true;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvSucursal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSucursal.Size = new Size(541, 392);
            dgvSucursal.TabIndex = 15;
            dgvSucursal.CellClick += dgvSucursal_CellClick;
            dgvSucursal.KeyDown += dgvSucursal_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1134, 119);
            label2.Name = "label2";
            label2.Size = new Size(343, 21);
            label2.TabIndex = 14;
            label2.Text = "Control + N para agregar una nueva categoría";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1088, 207);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 50);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar Categoría";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(828, 207);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(235, 50);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar Categoría";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(701, 110);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 10;
            label1.Text = "Sucursal";
            // 
            // txtSucursal
            // 
            txtSucursal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSucursal.Location = new Point(828, 107);
            txtSucursal.Name = "txtSucursal";
            txtSucursal.Size = new Size(235, 33);
            txtSucursal.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.badge_plus__1_1;
            btnAgregar.Location = new Point(568, 207);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(235, 50);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "  Añadir Categoría";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1904, 728);
            Controls.Add(dgvSucursal);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(txtSucursal);
            Controls.Add(btnAgregar);
            KeyPreview = true;
            Name = "frmSucursal";
            Text = "frmSucursal";
            ((System.ComponentModel.ISupportInitialize)dgvSucursal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSucursal;
        private Label label2;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label label1;
        private TextBox txtSucursal;
        private Button btnAgregar;
    }
}