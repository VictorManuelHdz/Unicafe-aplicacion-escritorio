namespace pryCafeteriaUTHH
{
    partial class frmSalidas
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
            label5 = new Label();
            button1 = new Button();
            txtProductos = new TextBox();
            dgvSalidas = new DataGridView();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(809, 24);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 17;
            label5.Text = "SALIDAS";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(657, 119);
            button1.Name = "button1";
            button1.Size = new Size(121, 40);
            button1.TabIndex = 18;
            button1.Text = "Productos";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtProductos
            // 
            txtProductos.BackColor = SystemColors.ScrollBar;
            txtProductos.Location = new Point(902, 124);
            txtProductos.Multiline = true;
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(162, 35);
            txtProductos.TabIndex = 19;
            // 
            // dgvSalidas
            // 
            dgvSalidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalidas.Location = new Point(502, 178);
            dgvSalidas.Name = "dgvSalidas";
            dgvSalidas.Size = new Size(721, 351);
            dgvSalidas.TabIndex = 20;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(657, 548);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 40);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(943, 548);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 40);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1370, 628);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvSalidas);
            Controls.Add(txtProductos);
            Controls.Add(button1);
            Controls.Add(label5);
            Name = "frmSalidas";
            Text = "Salidas";
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button1;
        private TextBox txtProductos;
        private DataGridView dgvSalidas;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}