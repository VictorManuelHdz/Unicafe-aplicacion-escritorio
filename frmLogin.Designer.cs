namespace pryCafeteriaUTHH
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnEntrar = new Button();
            chkMostrar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(140, 104, 68);
            pictureBox1.Location = new Point(-7, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 163);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(140, 104, 68);
            label1.Font = new Font("Segoe UI", 69.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(576, 9);
            label1.Name = "label1";
            label1.Size = new Size(769, 124);
            label1.TabIndex = 1;
            label1.Text = "CAFETERÍA UTHH";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(590, 170);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(740, 741);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 18F);
            txtUsuario.Location = new Point(840, 509);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese el usuario";
            txtUsuario.Size = new Size(235, 39);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.Location = new Point(840, 561);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese la contraseña";
            txtPassword.Size = new Size(235, 39);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(840, 641);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(235, 50);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Font = new Font("Segoe UI", 14F);
            chkMostrar.Location = new Point(908, 606);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(97, 29);
            chkMostrar.TabIndex = 6;
            chkMostrar.Text = "Mostrar";
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 228, 210);
            ClientSize = new Size(1904, 1041);
            Controls.Add(chkMostrar);
            Controls.Add(btnEntrar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "UNICAFE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnEntrar;
        private CheckBox chkMostrar;
    }
}
