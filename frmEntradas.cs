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
    public partial class frmEntradas : Form
    {
        clsEntradas inventario;
        int idProducto;
        int cantidad;
        public frmEntradas()
        {
            InitializeComponent();
            inventario = new clsEntradas();
            cmbProveedores.DataSource = null;
            cmbCategorias.DataSource = null;
            dgvEntradas.DataSource = null;
            try
            {
                cmbProveedores.DataSource = inventario.CargarComboProveedores();
                cmbProveedores.DisplayMember = "vchNombres";
                cmbProveedores.ValueMember = "vchRFC";

                cmbCategorias.DataSource = inventario.CargarComboCategorias();
                cmbCategorias.DisplayMember = "vchCategoria";
                cmbCategorias.ValueMember = "intIdCategoria";

                // Carga el GridView
                dgvEntradas.DataSource = inventario.CargarDataGrid();
                dgvEntradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            btnActualizar.Enabled = false;
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                inventario = new clsEntradas();

                inventario.IdProducto = idProducto;

                inventario.PrecioCompra = float.Parse(txtPrecioCompra.Text);
                inventario.Cantidad = cantidad + int.Parse(txtCantidad.Text);
                inventario.PrecioVenta = float.Parse(txtPrecioVenta.Text);
                inventario.RfcProveedor = cmbProveedores.SelectedValue.ToString();
                inventario.IdCategoria = int.Parse(cmbCategorias.SelectedValue.ToString());


                var resp = MessageBox.Show("Estas seguro de actualizar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = inventario.Actualizar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Vuelve a cargar el DataGridView
                dgvEntradas.DataSource = null;
                dgvEntradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEntradas.DataSource = inventario.CargarDataGrid();

                // Limpia cajas de texto
                inventario.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvEntradas.CurrentRow;
            idProducto = Convert.ToInt32(fila.Cells[0].Value.ToString());
            txtNombreProducto.Text = fila.Cells[1].Value.ToString();
            cantidad = int.Parse(fila.Cells[3].Value.ToString());
            txtCantidad.Text = 0.ToString();
            cmbCategorias.SelectedValue = int.Parse(fila.Cells[4].Value.ToString());
            cmbProveedores.SelectedValue = fila.Cells[5].Value.ToString();
            txtPrecioCompra.Text = fila.Cells[6].Value.ToString();
            txtPrecioVenta.Text = fila.Cells[7].Value.ToString();
            btnActualizar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inventario = new clsEntradas();
            // hola
            inventario.LimpiarCajas(this);
            btnActualizar.Enabled = false;
        }
    }
}
