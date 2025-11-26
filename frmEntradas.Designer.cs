namespace pryCafeteriaUTHH
{
    partial class frmEntradas
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            txtPrecioCompra = new TextBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnActualizar = new Button();
            btnCancelar = new Button();
            txtPrecioVenta = new TextBox();
            dgvEntradas = new DataGridView();
            label5 = new Label();
            txtNombreProducto = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbProveedores = new ComboBox();
            cmbCategorias = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).BeginInit();
            SuspendLayout();
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BackColor = SystemColors.ScrollBar;
            txtPrecioCompra.Font = new Font("Segoe UI", 14F);
            txtPrecioCompra.Location = new Point(753, 159);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(235, 32);
            txtPrecioCompra.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.ScrollBar;
            txtCantidad.Font = new Font("Segoe UI", 14F);
            txtCantidad.Location = new Point(753, 209);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(235, 32);
            txtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(546, 159);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 8;
            label2.Text = "Precio Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(546, 209);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 9;
            label3.Text = "Cantidad ingresada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1016, 111);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 10;
            label4.Text = "Precio Venta";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(872, 294);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(116, 48);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(1051, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 48);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = SystemColors.ScrollBar;
            txtPrecioVenta.Font = new Font("Segoe UI", 14F);
            txtPrecioVenta.Location = new Point(1141, 101);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(235, 32);
            txtPrecioVenta.TabIndex = 4;
            // 
            // dgvEntradas
            // 
            dgvEntradas.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvEntradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvEntradas.BackgroundColor = Color.FromArgb(239, 228, 210);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvEntradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntradas.Location = new Point(286, 392);
            dgvEntradas.Name = "dgvEntradas";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(233, 237, 201);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvEntradas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvEntradas.Size = new Size(1333, 324);
            dgvEntradas.TabIndex = 15;
            dgvEntradas.TabStop = false;
            dgvEntradas.CellClick += dgvEntradas_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(941, 25);
            label5.Name = "label5";
            label5.Size = new Size(124, 30);
            label5.TabIndex = 16;
            label5.Text = "ENTRADAS";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = SystemColors.ScrollBar;
            txtNombreProducto.Font = new Font("Segoe UI", 14F);
            txtNombreProducto.Location = new Point(753, 101);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.ReadOnly = true;
            txtNombreProducto.Size = new Size(235, 32);
            txtNombreProducto.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(546, 111);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 7;
            label6.Text = "Nombre Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1016, 159);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 17;
            label7.Text = "Proveedor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(1016, 212);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 18;
            label8.Text = "Categorias";
            // 
            // cmbProveedores
            // 
            cmbProveedores.Font = new Font("Segoe UI", 14F);
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(1141, 152);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(235, 33);
            cmbProveedores.TabIndex = 19;
            // 
            // cmbCategorias
            // 
            cmbCategorias.Enabled = false;
            cmbCategorias.Font = new Font("Segoe UI", 14F);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(1141, 202);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(235, 33);
            cmbCategorias.TabIndex = 20;
            cmbCategorias.TabStop = false;
            // 
            // frmEntradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1904, 728);
            Controls.Add(cmbCategorias);
            Controls.Add(cmbProveedores);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(dgvEntradas);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtPrecioVenta);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecioCompra);
            KeyPreview = true;
            Name = "frmEntradas";
            Text = "Entradas";
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPrecioCompra;
        private TextBox txtCantidad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnActualizar;
        private Button btnCancelar;
        private TextBox txtPrecioVenta;
        private DataGridView dgvEntradas;
        private Label label5;
        private TextBox txtNombreProducto;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbProveedores;
        private ComboBox cmbCategorias;
    }
}