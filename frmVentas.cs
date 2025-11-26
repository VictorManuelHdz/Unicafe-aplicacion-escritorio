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
    public partial class frmVentas : Form
    {
        clsVentas clsVentas;
        public frmVentas()
        {
            InitializeComponent();
            clsVentas = new clsVentas();
            dgvVentas.DataSource = null;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.DataSource = clsVentas.CargarDataGrid();

        }
    }
}