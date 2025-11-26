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
    public partial class frmProveedores : Form
    {
        clsProveedores proveedores;
        string rfc;
        public frmProveedores()
        {
            InitializeComponent();
            txtNombre.Focus();
            proveedores = new clsProveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvProveedores.DataSource = proveedores.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                proveedores = new clsProveedores();

                // Se envian los datos a las propiedades
                proveedores.Rfc = txtRFC.Text;
                proveedores.Nombres = txtNombre.Text;
                proveedores.APaterno = txtApaterno.Text;
                proveedores.AMaterno = txtAmaterno.Text;
                proveedores.Telefono = txtTelefono.Text;
                proveedores.Direccion = txtDireccion.Text;
                proveedores.Correo = txtCorreo.Text;
                proveedores.Empresa = txtCompania.Text;

                MessageBox.Show(proveedores.Guardar());

                // Vuelve a cargar el DataGridView
                dgvProveedores.DataSource = null;
                dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProveedores.DataSource = proveedores.CargarDataGrid();

                // Limpia cajas de texto
                proveedores.LimpiarCajas(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvProveedores.CurrentRow;

            rfc = fila.Cells[0].Value.ToString();

            txtNombre.Text = fila.Cells[1].Value.ToString();
            txtApaterno.Text = fila.Cells[2].Value.ToString();
            txtAmaterno.Text = fila.Cells[3].Value.ToString();
            txtTelefono.Text = fila.Cells[4].Value.ToString();
            txtCorreo.Text = fila.Cells[5].Value.ToString();
            txtDireccion.Text = fila.Cells[6].Value.ToString();
            txtCompania.Text = fila.Cells[7].Value.ToString();

            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                proveedores = new clsProveedores();

                // Se envia el dato de referencia
                proveedores.Rfc = rfc;

                // Se envian los datos modificados
                proveedores.Nombres = txtNombre.Text;
                proveedores.APaterno = txtApaterno.Text;
                proveedores.AMaterno = txtAmaterno.Text;
                proveedores.Telefono = txtTelefono.Text;
                proveedores.Direccion = txtDireccion.Text;
                proveedores.Correo = txtCorreo.Text;
                proveedores.Empresa = txtCompania.Text;

                // Se llama al metodo de actualizar
                var resp = MessageBox.Show("Estas seguro de actualizar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = proveedores.Actualizar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Se muestra el DataGridView actualizado
                dgvProveedores.DataSource = null;
                dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProveedores.DataSource = proveedores.CargarDataGrid();

                // Se limpian las cajas de texto
                proveedores.LimpiarCajas(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProveedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                proveedores.LimpiarCajas(this);
                btnGuardar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                proveedores = new clsProveedores();

                // Se envia el dato de referencia
                proveedores.Rfc = rfc;

                var resp = MessageBox.Show("Estas seguro de eliminar el proveedor seleccionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = proveedores.Eliminar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Vuelve a cargar el DataGridView
                dgvProveedores.DataSource = null;
                dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProveedores.DataSource = proveedores.CargarDataGrid();

                // Limpia cajas de texto
                proveedores.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            proveedores.Nombres = txtConsultar.Text;
            dgvProveedores.DataSource = null;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvProveedores.DataSource = proveedores.Consulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
