using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace pryCafeteriaUTHH
{
    internal class clsLogin
    {
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        public static string rol;

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion DBconexion = new clsConexion();
                using (var conexion = DBconexion.AbrirConexion())
                {
                    string sql = "SELECT vchRol FROM tblusuario,tblroles WHERE vchCorreo = @usuario AND vchPassword = MD5(@password) AND tblusuario.intIdRol = tblroles.intIdRol";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);
                        // Si existe el usuario obtenemos el rol
                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                rol = resultado.GetString("vchRol");
                                return true; 
                            }
                            else
                            {
                                throw new Exception("Error en credenciales");
                            }
                        }// Libera la lectura de datos
                    }// Libera la consulta
                }// Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
