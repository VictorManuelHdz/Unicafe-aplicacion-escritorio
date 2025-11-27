namespace pryCafeteriaUTHH
{
    partial class frmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dvgInventario = new DataGridView();
            txtNombreProducto = new TextBox();
            label6 = new Label();
            btnAgregar = new Button();
            cmbCategorias = new ComboBox();
            label8 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            cmbProveedores = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgInventario).BeginInit();
            SuspendLayout();
            // 
            // dvgInventario
            // 
            dvgInventario.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14F);
            dvgInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dvgInventario.BackgroundColor = Color.FromArgb(239, 228, 210);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dvgInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dvgInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInventario.Location = new Point(329, 273);
            dvgInventario.Name = "dvgInventario";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dvgInventario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dvgInventario.Size = new Size(1333, 443);
            dvgInventario.TabIndex = 8;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = Color.White;
            txtNombreProducto.Font = new Font("Segoe UI", 14F);
            txtNombreProducto.Location = new Point(645, 32);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(235, 32);
            txtNombreProducto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(438, 40);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 10;
            label6.Text = "Nombre Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(1020, 186);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 48);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.Font = new Font("Segoe UI", 14F);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(1069, 31);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(235, 33);
            cmbCategorias.TabIndex = 22;
            cmbCategorias.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(931, 39);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 21;
            label8.Text = "Categoría";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(490, 90);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 10;
            label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Font = new Font("Segoe UI", 14F);
            txtDescripcion.Location = new Point(645, 83);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(235, 32);
            txtDescripcion.TabIndex = 9;
            // 
            // cmbProveedores
            // 
            cmbProveedores.Font = new Font("Segoe UI", 14F);
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.IntegralHeight = false;
            cmbProveedores.ItemHeight = 25;
            cmbProveedores.Location = new Point(1069, 87);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(235, 33);
            cmbProveedores.TabIndex = 24;
            cmbProveedores.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(931, 95);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 23;
            label2.Text = "Proveedores";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1904, 728);
            Controls.Add(cmbProveedores);
            Controls.Add(label2);
            Controls.Add(cmbCategorias);
            Controls.Add(label8);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(txtNombreProducto);
            Controls.Add(label6);
            Controls.Add(dvgInventario);
            Name = "frmProductos";
            Text = "frmInventario";
            ((System.ComponentModel.ISupportInitialize)dvgInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgInventario;
        private TextBox txtNombreProducto;
        private Label label6;
        private Button btnAgregar;
        private ComboBox cmbCategorias;
        private Label label8;
        private Label label1;
        private TextBox txtDescripcion;
        private ComboBox cmbProveedores;
        private Label label2;
    }
}