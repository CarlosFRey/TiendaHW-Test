using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBConnection
    {
        //string cadenaConexion = "Data Source=PC-CHARLY;Initial Catalog=LUGYMDS2;Integrated Security=True;Trust Server Certificate=True";
        private const string DB_LUGMDS = "DBConectionProducto";

        public static string GetDBAccess()
        {
            return ConfigurationManager.ConnectionStrings[DB_LUGMDS].ConnectionString;
        }
        
    }
}
