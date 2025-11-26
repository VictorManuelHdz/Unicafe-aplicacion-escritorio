using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace pryCafeteriaUTHH
{
    internal class clsConexion
    {
        // Cadena de conexión a la base de datos
        //private readonly string cadenaConexion = "server=localhost;database=bdunicafe;user=root;";
        private readonly string cadenaConexion = "server=146.59.154.144;database=s1510_unicafe;user=u1510_Yw1wzgS1cb;password=s=@Dg^O3SWhynFr1x4q04M+n;";

        // Funcion para conectar a la base de datos
        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message, ex);
            }
        }

    }
}
