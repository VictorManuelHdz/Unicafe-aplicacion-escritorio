namespace pryCafeteriaUTHH
{
    partial class FrmMarcas
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dvgMarcas = new DataGridView();
            label1 = new Label();
            txtMarcas = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgMarcas).BeginInit();
            SuspendLayout();
            // 
            // dvgMarcas
            // 
            dvgMarcas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dvgMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgMarcas.BackgroundColor = Color.FromArgb(239, 228, 210);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvgMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dvgMarcas.DefaultCellStyle = dataGridViewCellStyle3;
            dvgMarcas.Location = new Point(690, 307);
            dvgMarcas.Name = "dvgMarcas";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dvgMarcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dvgMarcas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dvgMarcas.Size = new Size(541, 392);
            dvgMarcas.TabIndex = 7;
            dvgMarcas.CellClick += dvgMarcas_CellClick;
            dvgMarcas.KeyDown += dvgMarcas_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(723, 110);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 6;
            label1.Text = "Marcas";
            // 
            // txtMarcas
            // 
            txtMarcas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarcas.Location = new Point(828, 107);
            txtMarcas.Name = "txtMarcas";
            txtMarcas.Size = new Size(235, 33);
            txtMarcas.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.badge_plus__1_1;
            btnAgregar.Location = new Point(568, 207);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(235, 50);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "  Añadir Marca";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(828, 207);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(235, 50);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar Marca";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1088, 207);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 50);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar Marca";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1135, 119);
            label2.Name = "label2";
            label2.Size = new Size(343, 21);
            label2.TabIndex = 9;
            label2.Text = "Control + N para agregar una nueva categoría";
            // 
            // FrmMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1904, 728);
            Controls.Add(label2);
            Controls.Add(dvgMarcas);
            Controls.Add(label1);
            Controls.Add(txtMarcas);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            KeyPreview = true;
            Name = "FrmMarcas";
            Text = "FrmMarcas";
            ((System.ComponentModel.ISupportInitialize)dvgMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgMarcas;
        private Label label1;
        private TextBox txtMarcas;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label2;
    }
}