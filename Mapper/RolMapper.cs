using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Mapper
{
    public class RolMapper
    {
        public static Rol Map(SqlDataReader reader)
        {
            Rol newRol = new Rol();
            newRol.IdRol = Convert.ToInt32(reader["IDROL"]);
            newRol.Descripcion = reader["DESCRIPCION"].ToString();
            newRol.FechaRegistro = Convert.ToDateTime(reader["FECHACREACION"]);
            return newRol;
        }
    }
}
