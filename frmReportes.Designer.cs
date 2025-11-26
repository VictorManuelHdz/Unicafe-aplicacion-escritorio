namespace pryCafeteriaUTHH
{
    partial class frmReportes
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
            btnDiario = new Button();
            btnQuincenal = new Button();
            dgvReportes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // btnDiario
            // 
            btnDiario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiario.ForeColor = SystemColors.ControlText;
            btnDiario.Location = new Point(1122, 49);
            btnDiario.Name = "btnDiario";
            btnDiario.Size = new Size(235, 50);
            btnDiario.TabIndex = 0;
            btnDiario.Text = "Diario";
            btnDiario.UseVisualStyleBackColor = true;
            // 
            // btnQuincenal
            // 
            btnQuincenal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuincenal.ForeColor = SystemColors.ControlText;
            btnQuincenal.Location = new Point(438, 49);
            btnQuincenal.Name = "btnQuincenal";
            btnQuincenal.Size = new Size(235, 50);
            btnQuincenal.TabIndex = 0;
            btnQuincenal.Text = "Quincenal";
            btnQuincenal.UseVisualStyleBackColor = true;
            // 
            // dgvReportes
            // 
            dgvReportes.BackgroundColor = Color.FromArgb(239, 228, 210);
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(86, 161);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(1694, 543);
            dgvReportes.TabIndex = 1;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1885, 728);
            Controls.Add(dgvReportes);
            Controls.Add(btnQuincenal);
            Controls.Add(btnDiario);
            Cursor = Cursors.Default;
            ForeColor = SystemColors.ControlLight;
            Name = "frmReportes";
            Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDiario;
        private Button btnQuincenal;
        private DataGridView dgvReportes;
    }
}