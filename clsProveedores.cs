using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pryCafeteriaUTHH
{
    internal class clsProveedores : clsCafeteriaBase
    {
        // Atributos
        private string nombres;
        private string aPaterno;
        private string aMaterno;
        private string telefono;
        private string direccion;
        private string correo;
        private string empresa;

        // Atributo para Eliminar o Actualizar
        private string rfc;
        private string nombreBuscado;

        public string Nombres 
        { 
            get => nombres;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El campo nombre no puede quedarse vacío");
                }
                nombres = value;
            }
        }
        public string APaterno 
        { get => aPaterno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El apellido paterno no puede estar vacío");
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
                    throw new ArgumentException("El apellido materno no puede estar vacío");
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
                    throw new ArgumentException("El numero de teléfono no puede quedarse vacío");
                }
                else if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("El campo teléfono debe contener solo valores numericos");
                }
                telefono = value;
            }
        }
        public string Direccion 
        { get => direccion; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La dirección no debe estar vacía");
                }
                direccion = value;
            }
        }
        public string Correo 
        { 
            get => correo; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El campo correo no debe estar vacio");
                }
                correo = value;
            }    
        }
        public string Empresa 
        { 
            get => empresa; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El campo compañia no debe estar vacio");
                }
                empresa = value;
            } 
        }

        public string Rfc { get => rfc; set => rfc = value; }
        public string NombreBuscado { get => nombreBuscado;}


        public override DataTable CargarDataGrid()
        {
            try
            {
                tabla = new DataTable();
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT vchRFC as RFC, vchNombres as Nombres, vchApaterno as 'Apellido Paterno', " +
                        "vchAmaterno as 'Apellido Materno', vchTelefono as Telefono, vchCorreo as Correo, vchDireccion as Direccion, vchEmpresa as 'Empresa' FROM tblproveedores";
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
        public override string Guardar()
        {
            string salida = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "INSERT INTO tblproveedores (vchRFC, vchNombres, vchApaterno, vchAmaterno, vchTelefono, vchDireccion, vchCorreo, vchEmpresa) " +
                                 "VALUES (@rfc, @nombres, @aPaterno, @aMaterno, @telefono, @direccion, @correo, @empresa)";
                    using (insertar = new MySqlCommand(sql, conexion))
                    {
                        insertar.Parameters.AddWithValue("@rfc", rfc);
                        insertar.Parameters.AddWithValue("@nombres", nombres);
                        insertar.Parameters.AddWithValue("@aPaterno", aPaterno);
                        insertar.Parameters.AddWithValue("@aMaterno", aMaterno);
                        insertar.Parameters.AddWithValue("@telefono", telefono);
                        insertar.Parameters.AddWithValue("@direccion", direccion);
                        insertar.Parameters.AddWithValue("@correo", correo);
                        insertar.Parameters.AddWithValue("@empresa", empresa);
                        int filasAfectadas = insertar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Datos guardados correctamente.";
                        }
                        else
                        {
                            salida = "Error no se guardarón los datos, Vuelva a intentarlo!!!";
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
                    string sql = "UPDATE tblproveedores SET vchNombres = @nombres, vchApaterno = @aPaterno, " +
                                 "vchAmaterno = @aMaterno, vchTelefono = @telefono, vchDireccion = @direccion, vchCorreo = @correo, vchCompania = @compania " +
                                 "WHERE vchRFC = @RFC";
                    using (actualizar = new MySqlCommand(sql, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@nombres", nombres);
                        actualizar.Parameters.AddWithValue("@aPaterno", aPaterno);
                        actualizar.Parameters.AddWithValue("@aMaterno", aMaterno);
                        actualizar.Parameters.AddWithValue("@telefono", telefono);
                        actualizar.Parameters.AddWithValue("@direccion", direccion);
                        actualizar.Parameters.AddWithValue("@correo", correo);
                        actualizar.Parameters.AddWithValue("@compania", empresa);
                        actualizar.Parameters.AddWithValue("@RFC", rfc);
                        int filasAfectadas = actualizar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Los datos se actualizarón correctamente.";
                        }
                        else
                        {
                            salida = "Error no se actualizarón los datos, Vuelva a intentarlo!!!";
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
                    string sql = "DELETE FROM tblproveedores WHERE vchRFC = @RFC";
                    using (eliminar = new MySqlCommand(sql, conexion))
                    {
                        eliminar.Parameters.AddWithValue("@RFC", rfc);
                        int filasAfectadas = eliminar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            salida = "Los datos se eliminarón correctamente.";
                        }
                        else
                        {
                            salida = "Error no se eliminarón los datos, Vuelva a intentarlo!!!";
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
                    string sql = "SELECT vchRFC as 'RFC', vchNombres as Nombres, vchApaterno as 'Apellido Paterno', " +
                                 "vchAmaterno as 'Apellido Materno', vchTelefono as Telefono, vchDireccion as Direccion, vchCorreo as Correo FROM tblproveedores " +
                                 "WHERE vchNombres LIKE @nombreBuscado";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.SelectCommand.Parameters.AddWithValue("@nombreBuscado", "%" + nombreBuscado + "%");
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
