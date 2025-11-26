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
    public partial class frmCategorias : Form
    {
        clsCategorias categorias;
        int idCategoria;
        public frmCategorias()
        {
            InitializeComponent();
            txtCategoria.Focus();
            categorias = new clsCategorias();
            dgvCategorias.DataSource = null;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvCategorias.DataSource = categorias.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                categorias = new clsCategorias();

                categorias.Categoria = txtCategoria.Text;

                MessageBox.Show(categorias.Guardar());

                // Vuelve a cargar el DataGridView
                dgvCategorias.DataSource = null;
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategorias.DataSource = categorias.CargarDataGrid();

                // Limpia cajas de texto
                categorias.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                categorias.LimpiarCajas(this);
                btnAgregar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                categorias = new clsCategorias();

                // Se envia el dato de referencia 
                categorias.IdCategoria = idCategoria;

                // Se envian los datos modificados
                categorias.Categoria = txtCategoria.Text;

                // se llama al metodo de actualizar
                var resp = MessageBox.Show("Estas seguro de actualizar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = categorias.Actualizar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Se muestra el DataGridView actualizado
                dgvCategorias.DataSource = null;
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategorias.DataSource = categorias.CargarDataGrid();

                // Se limpian las cajas de texto
                categorias.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvCategorias.CurrentRow;
            idCategoria = Convert.ToInt32(fila.Cells[0].Value.ToString());
            txtCategoria.Text = fila.Cells[1].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                categorias = new clsCategorias();

                // Se envia el dato de referencia
                categorias.IdCategoria = idCategoria;
                var resp = MessageBox.Show("Estas seguro de eliminar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = categorias.Eliminar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Se muestra el DataGridView actualizado
                dgvCategorias.DataSource = null;
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategorias.DataSource = categorias.CargarDataGrid();

                // Se limpian las cajas de texto
                categorias.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategorias_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
