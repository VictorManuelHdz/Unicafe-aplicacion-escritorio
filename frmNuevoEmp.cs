using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pryCafeteriaUTHH
{
    public partial class frmNuevoEmp : Form
    {
        clsNuevoEmp usuario;
        int idUsuario;
        public frmNuevoEmp()
        {
            InitializeComponent();
            usuario = new clsNuevoEmp();
            try
            {
                cmbRoles.DataSource = null;
                cmbRoles.DataSource = usuario.CargarCombo();
                cmbRoles.DisplayMember = "vchRol";
                cmbRoles.ValueMember = "intIdRol";

                // dataGrid
                dgvUsuarios.DataSource = null;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsuarios.DataSource = usuario.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new clsNuevoEmp();
                usuario.Nombres = txtNombre.Text;
                usuario.APaterno = txtApaterno.Text;
                usuario.AMaterno = txtAmaterno.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Direccion = txtDireccion.Text;
                usuario.Password = txtPassword.Text;
                usuario.IdRol = int.Parse(cmbRoles.SelectedValue.ToString());

                string resultado = usuario.Guardar();
                MessageBox.Show(resultado);

                // Cargar el DataGridView nuevamente
                dgvUsuarios.DataSource = null;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsuarios.DataSource = usuario.CargarDataGrid();

                // Limpiar las cajas de texto
                usuario.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvUsuarios.CurrentRow;
            idUsuario = int.Parse(fila.Cells[0].Value.ToString());
            txtNombre.Text = fila.Cells[1].Value.ToString();
            txtApaterno.Text = fila.Cells[2].Value.ToString();
            txtAmaterno.Text = fila.Cells[3].Value.ToString();
            txtTelefono.Text = fila.Cells[4].Value.ToString();
            txtCorreo.Text = fila.Cells[5].Value.ToString();
            txtDireccion.Text = fila.Cells[6].Value.ToString();
            cmbRoles.SelectedValue = fila.Cells[7].Value.ToString();
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            txtPassword.ReadOnly = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new clsNuevoEmp();

                // Se envia el dato de referencia
                usuario.IdUsuario = idUsuario;

                // Se envian los datos a actualizar
                usuario.Nombres = txtNombre.Text;
                usuario.APaterno = txtApaterno.Text;
                usuario.AMaterno = txtAmaterno.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Direccion = txtDireccion.Text;
                usuario.IdRol = int.Parse(cmbRoles.SelectedValue.ToString());

                var resp = MessageBox.Show("Estas seguro de actualizar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string resultado = usuario.Actualizar();
                    MessageBox.Show(resultado, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Cargar el DataGridView nuevamente
                dgvUsuarios.DataSource = null;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsuarios.DataSource = usuario.CargarDataGrid();
                // Limpiar las cajas de texto
                usuario.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new clsNuevoEmp();
                // Se envia el dato de referencia
                usuario.IdUsuario = idUsuario;

                var resp = MessageBox.Show("Estas seguro de eliminar el registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string resultado = usuario.Eliminar();
                    MessageBox.Show(resultado, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cargar el DataGridView nuevamente
                dgvUsuarios.DataSource = null;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsuarios.DataSource = usuario.CargarDataGrid();

                // Limpiar las cajas de texto
                usuario.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                usuario.LimpiarCajas(this);
                btnGuardar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                txtPassword.ReadOnly = false;
            }
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            usuario.Nombres = txtConsultar.Text;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvUsuarios.DataSource = usuario.Consulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
