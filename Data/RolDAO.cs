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
    public class RolDAO
    {
        public Rol getRolbyID(int ID)
        {
            try
            {
                Rol getRol = new Rol();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT IDROL, DESCRIPCION, FECHACREACION FROM ROL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                getRol = RolMapper.Map(reader);
                            }
                        }

                    }
                }
                return getRol;
            }
            catch (Exception ex) { throw; }
        }
    }
}
