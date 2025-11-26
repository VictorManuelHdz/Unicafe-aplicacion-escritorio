using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pryCafeteriaUTHH
{
    internal class clsMarcas : clsCafeteriaBase
    {
        // Atributos
        private string marca;

        // Atributo para Eliminar o Actualizar
        private int idMarca;

        // Propiedades
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string Marca { get => marca; set => marca = value; }

        // Metodos o funciones
        public override DataTable CargarDataGrid()
        {
            try
            {
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdMarca as 'Id marca', tblmarcas FROM marcas";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    } // Libera la incersion
                } // Libera la conexion
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
                    string sql = "INSERT INTO marcas (Marca) VALUES (@marca)";
                    using (insertar = new MySqlCommand(sql, conexion))
                    {
                        insertar.Parameters.AddWithValue("@marca", marca);
                        int filasAfectadas = insertar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            salida = "Los datos se guardarón correctamente";
                        }
                        else
                        {
                            salida = "Error, no se guardarón los datos";
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
        
        public override string Actualizar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "UPDATE marcas SET Marca = @marca WHERE Id_Marca = @idMarca";
                    using (actualizar = new MySqlCommand(sql, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@marca", marca);
                        actualizar.Parameters.AddWithValue("@idMarca", idMarca);
                        int filasAfectadas = actualizar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Los datos se actualizarón correctamente";
                        }
                        else
                        {
                            salida = "Error, no se actualizarón los datos";
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
        public override string Eliminar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM marcas WHERE Id_Marca = @idMarca";
                    using (eliminar = new MySqlCommand(sql, conexion))
                    {
                        eliminar.Parameters.AddWithValue("@idMarca", idMarca);
                        int filasAfectadas = eliminar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Los datos se eliminarón correctamente";
                        }
                        else
                        {
                            salida = "Error, no se eliminarón los datos";
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
    }
}
