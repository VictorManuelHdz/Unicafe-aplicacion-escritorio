using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pryCafeteriaUTHH
{
    internal class clsEntradas 
    {
        // Atributos
        private string nombreProducto;
        private float precioCompra;
        private int cantidad;
        private float precioVenta;
        private string rfcProveedor;
        private int idCategoria;

        // Propiedad de referencia para modificar o eliminar la informacion
        private int idProducto;

        // Crear tabla virtual para almacenar los datos
        DataTable tabla;
        MySqlDataAdapter consulta;
        MySqlCommand actualizar;

        // Propiedades
        public string NombreProducto { get => nombreProducto;}
        public float PrecioCompra 
        {
            get => precioCompra; 
            set
            {
                if (value>0)
                {
                    precioCompra = value;
                }
                else
                { 
                    throw new ArgumentException("El valor ingresado debe ser de tipo numérico y mayor a cero");
                }
            }
        }
        public int Cantidad 
        { 
            get => cantidad;
            set
            {
                if (value > 0)
                {
                    cantidad = value;
                }
                else
                {
                    throw new ArgumentException("El valor ingresado debe ser de tipo numérico o mayor a cero");

                }
            }
        }
        public float PrecioVenta 
        {
            get => precioVenta;
            set
            {
                if (value>0)
                {
                    precioVenta = value;
                }
                else
                { throw new ArgumentException("El valor ingresado debe ser de tipo numérico o mayor a cero"); }
            }
        }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string RfcProveedor { get => rfcProveedor; set => rfcProveedor = value; }

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
        public string Actualizar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "UPDATE tblproductos SET intStock = @cantidad, vchRFCProveedor = @rfcProveedor, decPrecioCompra = @precioCompra, decPrecioVenta = @precioVenta WHERE intIdProducto = @idProducto;";
                    using (actualizar = new MySqlCommand(sql, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@cantidad", cantidad);
                        actualizar.Parameters.AddWithValue("@rfcProveedor", rfcProveedor);
                        actualizar.Parameters.AddWithValue("@precioCompra", precioCompra);
                        actualizar.Parameters.AddWithValue("@precioVenta", precioVenta);
                        actualizar.Parameters.AddWithValue("@idProducto", idProducto);
                        int filasAfectadas = actualizar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Producto actualizado correctamente.";
                        }
                        else
                        {
                            salida = "Error al actualizar el producto.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return salida;
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
                    using (consulta = new MySqlDataAdapter(sql, conexion))
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
        public DataTable CargarComboProveedores()
        {
            DataTable tablaProveedores = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT vchRFC, vchNombres FROM tblproveedores";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
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
        public DataTable CargarComboSucursal()
        {
            DataTable tablaSucursales = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIducursal, vchNombre FROM tblsucursales";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tablaSucursales);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return tablaSucursales;
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
