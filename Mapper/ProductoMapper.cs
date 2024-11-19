using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entidades;


namespace Mapper
{
    public class ProductoMapper
    {
        public static Producto Map(SqlDataReader reader)
        {
            Producto newProducto = new Producto()
            {
                ProductoID = Convert.ToInt32(reader["ProductoID"].ToString()),
                Modelo = reader["Modelo"].ToString(),
                Marca = reader["Marca"].ToString(),
                Stock = Convert.ToInt32(reader["Stock"].ToString()),
                Precio = Convert.ToDouble(reader["Precio"].ToString()),
                Categoria = reader["ProductoID"].ToString()
            };
            return newProducto;
        }
    }
}
