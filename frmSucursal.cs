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
    public partial class frmSucursal : Form
    {
        clsSucursal sucursal;
        int idSucursal;
        public frmSucursal()
        {
            InitializeComponent();
            dgvSucursal.DataSource = null;
            dgvSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                sucursal = new clsSucursal();
                dgvSucursal.DataSource = sucursal.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                sucursal = new clsSucursal();

                sucursal.Sucursal = txtSucursal.Text;

                MessageBox.Show(sucursal.Guardar());

                // carga el DataGridView
                dgvSucursal.DataSource = null;
                dgvSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSucursal.DataSource = sucursal.CargarDataGrid();

                // Limpia el TextBox
                sucursal.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSucursal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvSucursal.CurrentRow;
            idSucursal = Convert.ToInt32(fila.Cells[0].Value);
            txtSucursal.Text = fila.Cells[1].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                sucursal = new clsSucursal();

                // Se envia el dato de referencia 
                sucursal.IdSucursal = idSucursal;

                // Se envian los datos modificados
                sucursal.Sucursal = txtSucursal.Text;

                // se llama al metodo de actualizar
                var resp = MessageBox.Show("Estas seguro de actualizar la informacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = sucursal.Actualizar();
                    MessageBox.Show(salida, "Operacion exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Se muestra el DataGridView actualizado
                dgvSucursal.DataSource = null;
                dgvSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSucursal.DataSource = sucursal.CargarDataGrid();

                // Se limpian las cajas de texto
                sucursal.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSucursal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                sucursal.LimpiarCajas(this);
                btnAgregar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                sucursal = new clsSucursal();

                // Se envia el dato de referencia
                sucursal.IdSucursal = idSucursal;
                var resp = MessageBox.Show("Estas seguro de eliminar la informacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = sucursal.Eliminar();
                    MessageBox.Show(salida, "Operacion exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Se muestra el DataGridView actualizado
                dgvSucursal.DataSource = null;
                dgvSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSucursal.DataSource = sucursal.CargarDataGrid();

                // Se limpian las cajas de texto
                sucursal.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
