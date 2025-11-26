using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCafeteriaUTHH
{
    public partial class frmPrincipal : Form
    {
        clsPrincipal principal;
        public frmPrincipal()
        {
            InitializeComponent();
            principal = new clsPrincipal();
            principal.DeshabilitarOpciones(menuStrip1);
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new clsColoresMenu());
            lblTipousuario.Text = lblTipousuario.Text + "\t\t\tUsuario: " + clsLogin.rol;
        }

        private void tsmVentas_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmVentas(), pnlContenedor);

        }

        private void tsmCategorias_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmCategorias(), pnlContenedor);
        }
        private void tsmProveedores_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmProveedores(), pnlContenedor);
        }
        private void tsmReporte_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmReportes(), pnlContenedor);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.White;
            }

            e.ClickedItem.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void tsmInventario_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmProductos(), pnlContenedor);
        }

        private void tsmEntradas_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmEntradas(), pnlContenedor);
        }

        private void tsmSalidas_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmSalidas(), pnlContenedor);
        }

        private void tsmRoles_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmRoles(), pnlContenedor);
        }

        private void tsmNuevo_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmNuevoEmp(), pnlContenedor);
        }

        private void tsmSucursal_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmSucursal(), pnlContenedor);
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pcbSalir_MouseHover(object sender, EventArgs e)
        {
            pcbSalir.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.BackColor = Color.White;
        }
    }
}
