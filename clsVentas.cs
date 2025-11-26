using MySqlConnector;
using System.Data;

namespace pryCafeteriaUTHH
{
    internal class clsVentas
    {
        private DataTable tabla;

        private MySqlDataAdapter consulta;

        public DataTable CargarDataGrid()
        {
            clsConexion DBconexion = new clsConexion();
            tabla = new DataTable();
            using (var conexion = DBconexion.AbrirConexion())
            {
                string sql = "SELECT intIdDetalleVenta as 'Id Detalle', intIdProducto as 'Id Producto', decPrecioUnitario as 'Precio Unnitario', intCantidad as Cantidad, decSubtotal as Subtotal FROM tbldetalleventa;";
                using (consulta = new MySqlDataAdapter(sql, conexion))
                {
                    consulta.Fill(tabla);
                }
            }
            return tabla;
        }

        public static List<clsVentas> ListaVentas = new List<clsVentas>();


    }
}
