using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class CarritoProductoMapper
    {
        public static CarritoProducto Map(SqlDataReader reader, Carrito carrito, Producto producto)
        {
            CarritoProducto cp = new CarritoProducto();
            cp.Carrito = new Carrito();
            cp.Producto = new Producto();
            cp.Carrito = carrito;
            cp.Producto = producto;
            cp.Cantidad = Convert.ToInt32(reader["CANTIDAD"]);
            cp.PrecioUnitario = Convert.ToDouble(reader["PRECIO_UNITARIO"]);
            return cp;
        }
    }
}
