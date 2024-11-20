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
            carrito.Cliente = new Cliente();
            carrito.Cliente = cliente;
            carrito.CarritoID = Convert.ToInt32(reader["CARRITOID"]);
            carrito.MontoTotal = Convert.ToDouble(reader["MONTO_TOTAL"]);
            carrito.Estado = Convert.ToInt32(reader["ESTADO"]);
            return carrito;
        }
    }
}
