using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteriaUTHH
{
    internal class clsProductos
    {
        // Atributos
        private string nombreProducto;
        private string descripcion;
        private int idCategoria;
        private string rfcProveedor;

        // Crear tabla virtual para almacenar los datos
        DataTable tabla;

        // Crear comando para insertar datos
        MySqlDataAdapter consulta;
        MySqlCommand insertar;

        // Propiedades
        public string NombreProducto 
        { 
            get => nombreProducto; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("El nombre del producto no puede estar vacío.");
                }
                nombreProducto = value;
            }
        }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string RfcProveedor { get => rfcProveedor; set => rfcProveedor = value; }
        public string Descripcion 
        { 
            get => descripcion; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("La descripcion no puede estar vacía.");
                }
                descripcion = value;
            }
        }

        

        // Metodos o funciones
        public DataTable CargarDataGrid()
        {
            try
            {
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdProducto as 'Id Producto', vchNombre as Nombre, vchDescripcion as Descripcion, intStock as Stock, intIdCategoria as 'Id Categoria', vchRFCProveedor as 'RFC Proveedor', decPrecioCompra as 'Precio Compra', decPrecioVenta as 'Precio Venta' FROM tblproductos";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return tabla;
        }
        public DataTable CargarComboCategorias()
        {

            DataTable tablaCategorias = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdCategoria, vchCategoria FROM tblcategorias";
                    using (var consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tablaCategorias);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return tablaCategorias;
        }
        public DataTable CargarcmbProveedores()
        {
            DataTable tablaProveedores = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
              
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT vchRFC, vchNombres FROM tblproveedores";
                    using (var consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tablaProveedores);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return tablaProveedores;

        }
        public string Agregar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();

                tabla = new DataTable();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "INSERT INTO tblproductos (vchNombre, vchDescripcion, intStock, intIdCategoria, vchRFCProveedor, decPrecioCompra, decPrecioVenta) VALUES (@nombreProducto, @descripcion, 0, @idCategoria, @rfcProveedor, 0.00, 0.00);";
                    insertar = new MySqlCommand(sql, conexion);
                    insertar.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                    insertar.Parameters.AddWithValue("@descripcion", descripcion);
                    insertar.Parameters.AddWithValue("@idCategoria", idCategoria);
                    insertar.Parameters.AddWithValue("@rfcProveedor", rfcProveedor);

                    int filasAfectadas = insertar.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        salida = "Producto guardado correctamente.";
                    }
                    else
                    {
                        salida = "Error al guardar el producto.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return salida;
        }
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
    }
}
