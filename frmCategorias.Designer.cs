namespace pryCafeteriaUTHH
{
    partial class frmCategorias
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
            txtCategoria = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(828, 107);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(235, 33);
            txtCategoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(701, 110);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 2;
            label1.Text = "Categoría";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.badge_plus__1_1;
            btnAgregar.Location = new Point(568, 207);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(235, 50);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "  Añadir Categoría";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(828, 207);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(235, 50);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar Categoría";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1088, 207);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 50);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Categoría";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1134, 119);
            label2.Name = "label2";
            label2.Size = new Size(343, 21);
            label2.TabIndex = 7;
            label2.Text = "Control + N para agregar una nueva categoría";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.BackgroundColor = Color.FromArgb(239, 228, 210);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.GridColor = Color.FromArgb(233, 237, 201);
            dgvCategorias.Location = new Point(690, 307);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.Size = new Size(541, 392);
            dgvCategorias.TabIndex = 8;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            dgvCategorias.DataBindingComplete += dgvCategorias_DataBindingComplete;
            dgvCategorias.KeyDown += dgvCategorias_KeyDown;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1904, 728);
            Controls.Add(dgvCategorias);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(txtCategoria);
            Controls.Add(btnAgregar);
            KeyPreview = true;
            Name = "frmCategorias";
            Text = " Categoías";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCategoria;
        private Label label1;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label2;
        private DataGridView dgvCategorias;
    }
}