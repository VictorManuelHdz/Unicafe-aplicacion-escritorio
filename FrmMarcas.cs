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
    public partial class FrmMarcas : Form
    {
        clsMarcas marcas;
        int idMarca;
        public FrmMarcas()
        {

            InitializeComponent();
            marcas = new clsMarcas();
            dvgMarcas.DataSource = null;
            dvgMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dvgMarcas.DataSource = marcas.CargarDataGrid();
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
                marcas = new clsMarcas();

                marcas.Marca = txtMarcas.Text;

                MessageBox.Show(marcas.Guardar());

                // Vuelve a cargar el DataGridView
                dvgMarcas.DataSource = null;
                dvgMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgMarcas.DataSource = marcas.CargarDataGrid();

                // Limpia cajas de texto
                marcas.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dvgMarcas_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.N)
            {
                marcas.LimpiarCajas(this);
                btnAgregar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                marcas = new clsMarcas();

                // Se envia el dato de referencia
                marcas.IdMarca = idMarca;

                // Se envian los datos modificados
                marcas.Marca = txtMarcas.Text;

                var resp = MessageBox.Show("Estas seguro de actualizar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = marcas.Actualizar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Vuelve a cargar el DataGridView
                dvgMarcas.DataSource = null;
                dvgMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgMarcas.DataSource = marcas.CargarDataGrid();

                // Limpia cajas de texto
                marcas.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dvgMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dvgMarcas.CurrentRow;
            idMarca = Convert.ToInt32(fila.Cells[0].Value);
            txtMarcas.Text = fila.Cells[1].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                marcas = new clsMarcas();
                
                // Se envia el dato de referencia
                marcas.IdMarca = idMarca;
                
                var resp = MessageBox.Show("Estas seguro de eliminar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes)
                {
                    string salida = marcas.Eliminar();
                    MessageBox.Show(salida, "Operación exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                // Vuelve a cargar el DataGridView
                dvgMarcas.DataSource = null;
                dvgMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgMarcas.DataSource = marcas.CargarDataGrid();
                
                // Limpia cajas de texto
                marcas.LimpiarCajas(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
