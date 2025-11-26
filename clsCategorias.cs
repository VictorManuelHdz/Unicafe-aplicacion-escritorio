using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;  

namespace pryCafeteriaUTHH
{
    internal class clsCategorias : clsCafeteriaBase
    {
        // Atributos
        private string categoria;

        // Atributo para Eliminar o Actualizar
        private int idCategoria;

        // Propiedades

        public string Categoria 
        { 
          get => categoria; 
          set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("La categoría no puede estar vacía");
                }
                categoria = value;
            }  
        }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }

        // Metodos o funciones
        public override DataTable CargarDataGrid()
        {
            try
            { 
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdCategoria as 'Id categoria', vchCategoria as Categoria FROM tblcategorias";
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
                    string sql = "INSERT INTO tblcategorias (vchCategoria) VALUES (@categoria)";
                    using (insertar = new MySqlCommand(sql, conexion))
                    {
                        insertar.Parameters.AddWithValue("@categoria", Categoria);
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
                    string sql = "UPDATE tblcategorias SET vchCategoria = @categoria WHERE intIdCategoria = @idCategoria";
                    using (actualizar = new MySqlCommand(sql, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@categoria", categoria);
                        actualizar.Parameters.AddWithValue("@idCategoria", idCategoria);
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
                    string sql = "DELETE FROM tblcategorias WHERE intIdCategoria = @idCategoria";
                    
                    using (eliminar = new MySqlCommand(sql, conexion))
                    {
                        eliminar.Parameters.AddWithValue("@idCategoria", IdCategoria);

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
