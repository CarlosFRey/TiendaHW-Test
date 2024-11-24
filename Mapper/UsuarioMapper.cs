using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class UsuarioMapper
    {
        public static Usuario Map(SqlDataReader reader, Rol rol)
        {
            Usuario newUsuario = new Usuario();
            newUsuario.IdUsuario = Convert.ToInt32(reader["IDUSUARIO"]);
            newUsuario.DNI = Convert.ToInt32(reader["DNI"]);
            newUsuario.NombreCompleto = reader["NOMBRECOMPLETO"].ToString();
            newUsuario.Clave = reader["CLAVE"].ToString();
            newUsuario.Estado = Convert.ToBoolean(reader["ESTADO"]);
            newUsuario.Rol = rol;
            return newUsuario;
        }
    }
}
