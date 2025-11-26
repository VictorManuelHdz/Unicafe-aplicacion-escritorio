using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteriaUTHH
{
    internal class clsSucursal : clsCafeteriaBase
    {
        // Atributos
        private string sucursal;

        // Atributo para Eliminar o Actualizar
        private int idSucursal;

        // Propiedades
        public string Sucursal 
        { 
            get => sucursal; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("La sucursal no puede estar vacía.");
                }
                sucursal = value;
            } 

        }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }

        // Metodos o funciones
        public override DataTable CargarDataGrid()
        {
            try
            {
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdSucursal as 'Id sucursal', vchNombre as Nombre FROM tblsucursal";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }// Libera la incersion
                }// Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return tabla;
        }
        public override string Guardar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "INSERT INTO tblsucursal(vchNombre) VALUES(@sucursal)";
                    using (insertar = new MySqlCommand(sql, conexion))
                    {
                        insertar.Parameters.AddWithValue("@sucursal", sucursal);
                        int filasAfectadas = insertar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            salida = "Los datos se guardarón correctamente";
                        }
                        else
                        {
                            salida = "Error, no se guardarón los datos";
                        }
                    }// Libera la incersion
                } // Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return salida;
        }

        public override string Actualizar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "UPDATE tblsucursal SET vchNombre = @sucursal WHERE intIdSucursal = @idSucursal";
                    using (actualizar = new MySqlCommand(sql, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@sucursal", sucursal);
                        actualizar.Parameters.AddWithValue("@idSucursal", idSucursal);
                        int filasAfectadas = actualizar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Los datos se actualizarón correctamente";
                        }
                        else
                        {
                            salida = "Error, no se actualizarón los datos";
                        }
                    }// Libera la incersion
                } // Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return salida;
        }
        public override string Eliminar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tblSucursal WHERE intidSucursal = @idSucursal";

                    using (eliminar = new MySqlCommand(sql, conexion))
                    {
                        eliminar.Parameters.AddWithValue("@idCategoria", IdSucursal);

                        int filasAfectadas = eliminar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            salida = "Los datos se eliminarón correctamente";
                        }
                        else
                        {
                            salida = "Error, no se eliminarón los datos";
                        }
                    }// Libera la incersion
                } // Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return salida;
        }
    }
}
