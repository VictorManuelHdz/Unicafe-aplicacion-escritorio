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
    public partial class frmRoles : Form
    {
        clsRoles roles;
        int idRol;
        public frmRoles()
        {
            InitializeComponent();
            roles = new clsRoles();
            dgvRoles.DataSource = null;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvRoles.DataSource = roles.CargarDataGrid();
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
                roles = new clsRoles();
                roles.Rol = txtRoles.Text;

                MessageBox.Show(roles.Guardar());

                // Vuelve a cargar el DataGridView
                dgvRoles.DataSource = null;
                dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRoles.DataSource = roles.CargarDataGrid();

                // Limpia cajas de texto
                roles.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvRoles.CurrentRow;
            idRol = Convert.ToInt32(fila.Cells[0].Value.ToString());
            txtRoles.Text = fila.Cells[1].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                roles = new clsRoles();

                // Se envia el dato de referencia
                roles.IdRol = idRol;

                // Se envian los datos modificados
                roles.Rol = txtRoles.Text;

                var resp = MessageBox.Show("Estas seguro de actualizar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = roles.Actualizar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Vuelve a cargar el DataGridView
                dgvRoles.DataSource = null;
                dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRoles.DataSource = roles.CargarDataGrid();
                
                // Limpia cajas de texto
                roles.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRoles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                roles.LimpiarCajas(this);
                btnAgregar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                roles = new clsRoles();
                
                // Se envia el dato de referencia
                roles.IdRol = idRol;
                
                var resp = MessageBox.Show("Estas seguro de eliminar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = roles.Eliminar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                // Vuelve a cargar el DataGridView
                dgvRoles.DataSource = null;
                dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRoles.DataSource = roles.CargarDataGrid();
                
                // Limpia cajas de texto
                roles.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
