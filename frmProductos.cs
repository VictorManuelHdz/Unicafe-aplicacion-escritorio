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
    public partial class frmProductos : Form
    {
        clsProductos inventario;
        public frmProductos()
        {
            InitializeComponent();
            inventario = new clsProductos();
            cmbCategorias.DataSource = null;
            dvgInventario.DataSource = null;
            try
            {
                cmbCategorias.DataSource = inventario.CargarComboCategorias();
                cmbCategorias.DisplayMember = "vchCategoria";
                cmbCategorias.ValueMember = "intIdCategoria";
                // Carga el GridView
                dvgInventario.DataSource = inventario.CargarDataGrid();
                dvgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                inventario = new clsProductos();
                inventario.NombreProducto = txtNombreProducto.Text;
                inventario.Descripcion = txtDescripcion.Text;
                inventario.IdCategoria = int.Parse(cmbCategorias.SelectedValue.ToString());

                MessageBox.Show(inventario.Agregar(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView
                dvgInventario.DataSource = null;
                dvgInventario.DataSource = inventario.CargarDataGrid();
                dvgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Limpiar las cajas de texto
                inventario.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
