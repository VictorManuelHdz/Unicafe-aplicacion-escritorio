using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pryCafeteriaUTHH
{
    internal class clsRoles : clsCafeteriaBase
    {
        // Atributos
        private string rol;

        // Atributo para Eliminar o Actualizar
        private int idRol;

        // Propiedades
        public string Rol 
        { 
            get => rol; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("El campo rol no puede estar vacío.");
                }
                rol = value;
            } 
        }
        public int IdRol { get => idRol; set => idRol = value; }

        // Metodos o funciones
        public override string Guardar()
        {
            string salida = "";
            try
            {
                tabla = new DataTable();

                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "INSERT INTO tblroles (vchRol) VALUES (@rol)";
                    using (insertar = new MySqlCommand(sql, conexion))
                    {
                        insertar.Parameters.AddWithValue("@rol", Rol);
                        int filasAfectadas = insertar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            salida = "Datos guardados correctamente.";
                        }
                        else
                        {
                            salida = "Error no se guardaron los datos, Revise!!.";
                        }
                    } // Libera la inserción
                } // Libera la conexión

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return salida;
        }
        public override DataTable CargarDataGrid()
        {
            try
            {
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdRol as 'Id Rol', vchRol as Rol FROM tblroles";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                } // Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return tabla;
        }
        public override string Actualizar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "UPDATE tblroles SET vchRol = @rol WHERE intIdRol = @idRol";
                    using (actualizar = new MySqlCommand(sql, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@rol", Rol);
                        actualizar.Parameters.AddWithValue("@idRol", IdRol);
                        int filasAfectadas = actualizar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Datos actualizados correctamente.";
                        }
                        else
                        {
                            salida = "Error no se actualizarón los datos, Revise!!.";
                        }
                    } // Libera la actualización
                } // Libera la conexión
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
                    string sql = "DELETE FROM tblroles WHERE intIdRol = @idRol";
                    using (eliminar = new MySqlCommand(sql, conexion))
                    {
                        eliminar.Parameters.AddWithValue("@idRol", IdRol);
                        int filasAfectadas = eliminar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Datos eliminados correctamente.";
                        }
                        else
                        {
                            salida = "Error no se eliminaron los datos, Revise!!.";
                        }
                    } // Libera la eliminación
                } // Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return salida;
        }
    }
}
