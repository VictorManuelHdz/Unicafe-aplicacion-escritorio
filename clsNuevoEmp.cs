using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pryCafeteriaUTHH
{
    internal class clsNuevoEmp : clsCafeteriaBase
    {
        // Atributos
        private string nombres;
        private string aPaterno;
        private string aMaterno;
        private string telefono;
        private string correo;
        private string direccion;
        private string password;
        private int idUsuario;

        // Atributo identificador de rol
        private int idRol;


        public string Nombres 
        { 
            get => nombres;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("El campo nombre no puede estar vacío");
                }
                nombres = value;              
            }
        }

        public string APaterno 
        { 
            get => aPaterno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("El campo apellido paterno no puede estar vacío");
                }
                aPaterno = value;
            }
        }
        public string AMaterno 
        { 
            get => aMaterno; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("El campo apellido materno no puede estar vacío");
                }
                aMaterno = value;   
            }
        }
        public string Telefono 
        { 
            get => telefono; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("El campo número de teléfono no puede estar vacío");
                }
                else if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("El campo número de teléfono debe contener solo números");
                }
                telefono = value;   
            }
        }
        public string Correo 
        { 
            get => correo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("El correo no puede estar vacío");
                }
                correo = value; 
            }
        }
        public string Password 
        { 
            get => password;
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("La contraseña no puede estar vacía");
                }
                password = value;   
                
            }
               
        }
        public int IdRol { get => idRol; set => idRol = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        // Metodos o funciones
        public override string Guardar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "INSERT INTO tblusuario (vchNombres, vchApaterno, vchAmaterno, vchTelefono, vchCorreo, vchDireccion, vchPassword, intIdRol) " +
                             "VALUES (@nombres, @aPaterno, @aMaterno, @telefono, @correo, @direccion, MD5(@password), @idRol);";
                    using (insertar = new MySqlCommand(sql, conexion))
                    {
                        insertar.Parameters.AddWithValue("@nombres", nombres);
                        insertar.Parameters.AddWithValue("@aPaterno", aPaterno);
                        insertar.Parameters.AddWithValue("@aMaterno", aMaterno);
                        insertar.Parameters.AddWithValue("@telefono", telefono);
                        insertar.Parameters.AddWithValue("@correo", correo);
                        insertar.Parameters.AddWithValue("@direccion", direccion);
                        insertar.Parameters.AddWithValue("@password", password);
                        insertar.Parameters.AddWithValue("@idRol", idRol);
                        int filasAfectadas = insertar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Registro guardado correctamente.";
                        }
                        else
                        {
                            salida = "Error al guardar el registro.";
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
        public override DataTable CargarDataGrid()
        {
            try
            {
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdUsuario as 'Id Usuario', vchNombres as Nombres, vchApaterno as 'Apellido Paterno', vchAmaterno as 'Apellido Materno', vchTelefono as Telefono, vchCorreo as Correo, vchDireccion as Direccion, intIdRol as 'Id Rol' FROM tblusuario";
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
        public DataTable CargarCombo()
        {
            try
            {
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdRol, vchRol FROM tblroles";
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
        public override string Actualizar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "update tblusuario set vchNombres = @nombres, vchApaterno = @aPaterno, vchAmaterno = @aMaterno, " +
                        "vchTelefono = @telefono, vchCorreo = @correo, vchDireccion = @direccion, intIdRol = @idRol where intIdUsuario = @idUsuario;";
                    using (actualizar = new MySqlCommand(sql, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@nombres", nombres);
                        actualizar.Parameters.AddWithValue("@aPaterno", aPaterno);
                        actualizar.Parameters.AddWithValue("@aMaterno", aMaterno);
                        actualizar.Parameters.AddWithValue("@telefono", telefono);
                        actualizar.Parameters.AddWithValue("@correo", correo);
                        actualizar.Parameters.AddWithValue("@direccion", direccion);
                        actualizar.Parameters.AddWithValue("@idRol", idRol);
                        actualizar.Parameters.AddWithValue("@idUsuario", idUsuario);
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
                    string sql = "DELETE FROM tblusuario WHERE intIdUsuario = @idUsuario";
                    using (eliminar = new MySqlCommand(sql, conexion))
                    {
                        eliminar.Parameters.AddWithValue("@idUsuario", idUsuario);
                        int filasAfectadas = eliminar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "El registro se elimino correctamente.";
                        }
                        else
                        {
                            salida = "Error al eliminar el registro.";
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
        public DataTable Consulta()
        {
            try
            {
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT intIdUsuario as 'ID Usuario', Nombres, vchApaterno as 'Apellido Paterno', vchAmaterno as 'Apellido Materno', vchTelefono, vchCorreo, vchDireccion, intIdRol FROM tblusuario WHERE vchNombres like @nombres";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.SelectCommand.Parameters.AddWithValue("@nombres", "%" + nombres + "%");
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
        
    }
}
