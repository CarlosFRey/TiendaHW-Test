using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Mapper
{
    public class CarritoMapper
    {
        public static Carrito Map(SqlDataReader reader, Cliente cliente)
        {
            Carrito carrito = new Carrito();
            carrito.CarritoID = Convert.ToInt32(reader["CARRITOID"]);
            carrito.MontoTotal = Convert.ToDouble(reader["CARRITOID"]);
            carrito.Estado = Convert.ToInt32(reader["ESTADO"]);
            carrito.Cliente = cliente;
            return carrito;
        }
    }
}
