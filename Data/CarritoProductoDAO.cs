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
    public class CarritoProductoDAO
    {
        CarritoDAO CarritoDAO = new CarritoDAO();
        ProductosDAO productoDAO = new ProductosDAO();
        public void AgregarProductosCarrito(int idCarrito, int idProducto, int Cantidad, double Precio)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
            {
                conn.Open();
                string query = "INSERT INTO CARRITO_PRODUCTO (CARRITOID, PRODUCTOID, CANTIDAD, PRECIO_UNITARIO) VALUES (@CarritoId, @ProductoId, @Cantidad, @PrecioUnitario)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CarritoId", idCarrito);
                    cmd.Parameters.AddWithValue("@ProductoId", idProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", Precio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<CarritoProducto> getCarritoProductos(int idCarrito)
        {
            try
            {
                List<CarritoProducto> lstCarritoProducto = new List<CarritoProducto>();
                
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT CARRITOID, PRODUCTOID, CANTIDAD, PRECIO_UNITARIO FROM CARRITO_PRODUCTO WHERE CARRITOID = @IdCarrito";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("IdCarrito", idCarrito);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Carrito carrito = CarritoDAO.GetCarrito(Convert.ToInt32(reader["CARRITOID"]));
                                Producto producto = productoDAO.GetProducto(Convert.ToInt32(reader["PRODUCTOID"]));
                                lstCarritoProducto.Add(CarritoProductoMapper.Map(reader, carrito, producto));
                            }
                        }
                    }
                }
                return lstCarritoProducto;
            }
            catch (Exception ex) { throw; }
        }
    }
}
