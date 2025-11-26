namespace pryCafeteriaUTHH
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            tsmVentas = new ToolStripMenuItem();
            tsmProductosmenu = new ToolStripMenuItem();
            tsmCategorias = new ToolStripMenuItem();
            tsmProductos = new ToolStripMenuItem();
            tsmMovimientos = new ToolStripMenuItem();
            tsmEntradas = new ToolStripMenuItem();
            tsmSalidas = new ToolStripMenuItem();
            tsmReporte = new ToolStripMenuItem();
            tsmProveedores = new ToolStripMenuItem();
            tsmEmpleados = new ToolStripMenuItem();
            tsmNuevo = new ToolStripMenuItem();
            tsmRoles = new ToolStripMenuItem();
            tsmSucursal = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            pnlContenedor = new Panel();
            pcbSalir = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            lblTipousuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(140, 104, 68);
            label1.Font = new Font("Segoe UI", 69.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(574, 23);
            label1.Name = "label1";
            label1.Size = new Size(769, 124);
            label1.TabIndex = 4;
            label1.Text = "CAFETERÍA UTHH";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(140, 104, 68);
            pictureBox1.Location = new Point(-7, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 163);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(216, 208, 146);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmVentas, tsmProductosmenu, tsmMovimientos, tsmReporte, tsmProveedores, tsmEmpleados, tsmSucursal });
            menuStrip1.Location = new Point(111, 197);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1793, 46);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tsmVentas
            // 
            tsmVentas.BackColor = Color.White;
            tsmVentas.ForeColor = SystemColors.ControlText;
            tsmVentas.Image = (Image)resources.GetObject("tsmVentas.Image");
            tsmVentas.ImageScaling = ToolStripItemImageScaling.None;
            tsmVentas.ImageTransparentColor = Color.Transparent;
            tsmVentas.Margin = new Padding(25, 0, 25, 0);
            tsmVentas.Name = "tsmVentas";
            tsmVentas.Padding = new Padding(4, 0, 38, 0);
            tsmVentas.Size = new Size(193, 42);
            tsmVentas.Text = "Ventas ";
            tsmVentas.TextImageRelation = TextImageRelation.TextBeforeImage;
            tsmVentas.Click += tsmVentas_Click;
            // 
            // tsmProductosmenu
            // 
            tsmProductosmenu.BackColor = Color.White;
            tsmProductosmenu.DropDownItems.AddRange(new ToolStripItem[] { tsmCategorias, tsmProductos });
            tsmProductosmenu.Image = Properties.Resources.iconoProducto_38x38;
            tsmProductosmenu.ImageScaling = ToolStripItemImageScaling.None;
            tsmProductosmenu.Margin = new Padding(0, 0, 25, 0);
            tsmProductosmenu.Name = "tsmProductosmenu";
            tsmProductosmenu.Padding = new Padding(4, 0, 38, 0);
            tsmProductosmenu.Size = new Size(232, 42);
            tsmProductosmenu.Text = "Productos";
            tsmProductosmenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // tsmCategorias
            // 
            tsmCategorias.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tsmCategorias.Name = "tsmCategorias";
            tsmCategorias.Size = new Size(201, 34);
            tsmCategorias.Text = "Categorías";
            tsmCategorias.Click += tsmCategorias_Click;
            // 
            // tsmProductos
            // 
            tsmProductos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tsmProductos.Name = "tsmProductos";
            tsmProductos.Size = new Size(201, 34);
            tsmProductos.Text = "Productos";
            tsmProductos.Click += tsmInventario_Click;
            // 
            // tsmMovimientos
            // 
            tsmMovimientos.BackColor = Color.White;
            tsmMovimientos.DropDownItems.AddRange(new ToolStripItem[] { tsmEntradas, tsmSalidas });
            tsmMovimientos.Image = Properties.Resources.iconoEntradaSalida_38x38_2;
            tsmMovimientos.ImageScaling = ToolStripItemImageScaling.None;
            tsmMovimientos.Margin = new Padding(0, 0, 25, 0);
            tsmMovimientos.Name = "tsmMovimientos";
            tsmMovimientos.Padding = new Padding(4, 0, 38, 0);
            tsmMovimientos.Size = new Size(271, 42);
            tsmMovimientos.Text = "Movimientos";
            tsmMovimientos.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // tsmEntradas
            // 
            tsmEntradas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tsmEntradas.Name = "tsmEntradas";
            tsmEntradas.Size = new Size(181, 34);
            tsmEntradas.Text = "Entradas";
            tsmEntradas.Click += tsmEntradas_Click;
            // 
            // tsmSalidas
            // 
            tsmSalidas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tsmSalidas.Name = "tsmSalidas";
            tsmSalidas.Size = new Size(181, 34);
            tsmSalidas.Text = "Salidas";
            tsmSalidas.Click += tsmSalidas_Click;
            // 
            // tsmReporte
            // 
            tsmReporte.BackColor = Color.White;
            tsmReporte.Image = Properties.Resources.iconoReporte_38x38;
            tsmReporte.ImageScaling = ToolStripItemImageScaling.None;
            tsmReporte.Margin = new Padding(0, 0, 25, 0);
            tsmReporte.Name = "tsmReporte";
            tsmReporte.Padding = new Padding(4, 0, 38, 0);
            tsmReporte.Size = new Size(205, 42);
            tsmReporte.Text = "Reporte";
            tsmReporte.TextImageRelation = TextImageRelation.TextBeforeImage;
            tsmReporte.Click += tsmReporte_Click;
            // 
            // tsmProveedores
            // 
            tsmProveedores.BackColor = Color.White;
            tsmProveedores.Image = Properties.Resources.iconoProveedor_38x38_2;
            tsmProveedores.ImageScaling = ToolStripItemImageScaling.None;
            tsmProveedores.Margin = new Padding(0, 0, 25, 0);
            tsmProveedores.Name = "tsmProveedores";
            tsmProveedores.Padding = new Padding(4, 0, 38, 0);
            tsmProveedores.Size = new Size(236, 42);
            tsmProveedores.Text = "Proveedor";
            tsmProveedores.TextImageRelation = TextImageRelation.TextBeforeImage;
            tsmProveedores.Click += tsmProveedores_Click;
            // 
            // tsmEmpleados
            // 
            tsmEmpleados.BackColor = Color.White;
            tsmEmpleados.DropDownItems.AddRange(new ToolStripItem[] { tsmNuevo, tsmRoles });
            tsmEmpleados.Image = Properties.Resources.Iconoempleaos_38x38;
            tsmEmpleados.ImageScaling = ToolStripItemImageScaling.None;
            tsmEmpleados.Margin = new Padding(0, 0, 25, 0);
            tsmEmpleados.Name = "tsmEmpleados";
            tsmEmpleados.Padding = new Padding(4, 0, 38, 0);
            tsmEmpleados.Size = new Size(241, 42);
            tsmEmpleados.Text = "Empleados";
            tsmEmpleados.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // tsmNuevo
            // 
            tsmNuevo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tsmNuevo.Name = "tsmNuevo";
            tsmNuevo.Size = new Size(157, 34);
            tsmNuevo.Text = "Nuevo";
            tsmNuevo.Click += tsmNuevo_Click;
            // 
            // tsmRoles
            // 
            tsmRoles.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tsmRoles.Name = "tsmRoles";
            tsmRoles.Size = new Size(157, 34);
            tsmRoles.Text = "Roles";
            tsmRoles.Click += tsmRoles_Click;
            // 
            // tsmSucursal
            // 
            tsmSucursal.BackColor = Color.White;
            tsmSucursal.Image = Properties.Resources.sucur_38x38;
            tsmSucursal.ImageScaling = ToolStripItemImageScaling.None;
            tsmSucursal.Margin = new Padding(0, 0, 25, 0);
            tsmSucursal.Name = "tsmSucursal";
            tsmSucursal.Padding = new Padding(4, 0, 38, 0);
            tsmSucursal.Size = new Size(207, 42);
            tsmSucursal.Text = "Sucursal";
            tsmSucursal.TextImageRelation = TextImageRelation.TextBeforeImage;
            tsmSucursal.Click += tsmSucursal_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(216, 208, 146);
            pictureBox2.Location = new Point(-7, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1920, 117);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(239, 228, 210);
            pnlContenedor.Location = new Point(3, 275);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1901, 767);
            pnlContenedor.TabIndex = 7;
            // 
            // pcbSalir
            // 
            pcbSalir.BackColor = Color.White;
            pcbSalir.Image = Properties.Resources.iconoSalir;
            pcbSalir.Location = new Point(1702, 113);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(38, 42);
            pcbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSalir.TabIndex = 0;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            pcbSalir.MouseLeave += pcbSalir_MouseLeave;
            pcbSalir.MouseHover += pcbSalir_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(140, 104, 68);
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1755, 117);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 0;
            label2.Text = "Cerrar sesión";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(140, 104, 68);
            pictureBox3.Image = Properties.Resources.Usuario1;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(140, 104, 68);
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 0;
            label3.Text = "User 1";
            // 
            // lblTipousuario
            // 
            lblTipousuario.AutoSize = true;
            lblTipousuario.BackColor = Color.FromArgb(140, 104, 68);
            lblTipousuario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipousuario.Location = new Point(101, 12);
            lblTipousuario.Name = "lblTipousuario";
            lblTipousuario.Size = new Size(92, 30);
            lblTipousuario.TabIndex = 0;
            lblTipousuario.Text = "Tipo de ";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblTipousuario);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pcbSalir);
            Controls.Add(pnlContenedor);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "UNICAFE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmVentas;
        private ToolStripMenuItem tsmProductosmenu;
        private ToolStripMenuItem tsmMovimientos;
        private ToolStripMenuItem tsmReporte;
        private ToolStripMenuItem tsmProveedores;
        private PictureBox pictureBox2;
        private Panel pnlContenedor;
        private ToolStripMenuItem tsmCategorias;
        private ToolStripMenuItem tsmProductos;
        private ToolStripMenuItem tsmEntradas;
        private ToolStripMenuItem tsmSalidas;
        private ToolStripMenuItem tsmEmpleados;
        private ToolStripMenuItem tsmNuevo;
        private ToolStripMenuItem tsmRoles;
        private ToolStripMenuItem tsmSucursal;
        private PictureBox pcbSalir;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label lblTipousuario;
    }
}