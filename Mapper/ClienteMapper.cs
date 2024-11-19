using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Mapper
{
    public class ClienteMapper
    {
        public static Cliente Map(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.ClienteID = Convert.ToInt32(reader["CLIENTEID"]);
            cliente.Nombre = reader["Nombre"].ToString();
            cliente.Apellido = reader["Apellido"].ToString();
            cliente.Cuit = Convert.ToDouble(reader["CUIT"].ToString());
            cliente.Telefono = Convert.ToDouble(reader["Telefono"].ToString());
            cliente.Email = reader["Email"].ToString();
            cliente.Direccion = reader["Direccion"].ToString();
            return cliente;
        }
    }
}
