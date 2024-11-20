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
                                lstCarritoProducto.Add(CarritoProductoMapper.Map(reader));
                            }
                        }
                    }
                }
                return lstCarritoProducto;
            }
            catch (Exception ex) { throw; }
        }

        public List<int> existeEnCarrito(Producto producto)
        {
            try
            {
                List<int> lstCarritos = new List<int>();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT * FROM CARRITO_PRODUCTO where PRODUCTOID = @productoid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productoid", producto.ProductoID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstCarritos.Add(Convert.ToInt32(reader["CARRITOID"]));
                            }
                        }
                    }
                }
                return lstCarritos;
            }
            catch (Exception ex) { throw; }
        }

    }
}
