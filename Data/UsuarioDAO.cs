using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper;

namespace Data
{
    public class UsuarioDAO
    {
        RolDAO rolDAO = new RolDAO();
        public List<Usuario> getUsuarios()
        {
            try
            {
                List<Usuario> lstUsuarios = new List<Usuario>();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT IDUSUARIO, DNI, NOMBRECOMPLETO, CLAVE, IDROL, ESTADO FROM USUARIO";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read())
                            {
                                Rol newRol = rolDAO.getRolbyID(Convert.ToInt32(reader["IDROL"]));
                                lstUsuarios.Add(UsuarioMapper.Map(reader, newRol));
                            }
                        }

                    }
                }
                return lstUsuarios;
            }
            catch (Exception ex) { throw; }
        }
        public Usuario validarLogin(int DNI, string password)
        {
            try
            {
                Usuario newUsuario = new Usuario();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT IDUSUARIO, DNI, NOMBRECOMPLETO, CLAVE, IDROL, ESTADO FROM USUARIO WHERE DNI = @dni AND CLAVE = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", DNI);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (string.IsNullOrEmpty(reader["NOMBRECOMPLETO"].ToString())) { newUsuario = null; }
                                else
                                {
                                    Rol newRol = rolDAO.getRolbyID(Convert.ToInt32(reader["IDROL"]));
                                    newUsuario = (UsuarioMapper.Map(reader, newRol));
                                }
                             }
                        }
                    }
                }
                return newUsuario;
            }
            catch (Exception ex) { throw; }
        }
    }
}
