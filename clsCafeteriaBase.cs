using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteriaUTHH
{
    internal abstract class clsCafeteriaBase
    {
        // Adaptador de datos
        protected MySqlDataAdapter consulta;

        // Tabla virtual
        protected DataTable tabla;

        // Objeto para insertar, actualizar o eliminar
        protected MySqlCommand insertar;
        protected MySqlCommand actualizar;
        protected MySqlCommand eliminar;

        // Metodos o funciones abstractas
        public abstract DataTable CargarDataGrid();
        public abstract string Guardar();
        public void LimpiarCajas(Control cajasDeTexto)
        {
            foreach (Control caja in cajasDeTexto.Controls)
            {
                if (caja is TextBox datos)
                {
                    datos.Clear();
                }
            }
        }
        public abstract string Actualizar();
        public abstract string Eliminar();
    }
}
