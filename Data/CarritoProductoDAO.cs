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

        public int getIDproductoDesdeDetalleCarrito(int nroFila)
        {
            try
            {
                int idProducto = -1;
                int stock =0;
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT * FROM (SELECT CARRITOID,PRODUCTOID,CANTIDAD,PRECIO_UNITARIO,ROW_NUMBER() OVER (ORDER BY CARRITOID, PRODUCTOID) AS NumeroFila FROM CARRITO_PRODUCTO) AS Numeradas WHERE NumeroFila = @nroFila;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nroFila", nroFila);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                idProducto = (Convert.ToInt32(reader["PRODUCTOID"]));
                                stock = (Convert.ToInt32(reader["CANTIDAD"]));
                            }
                        }
                    }
                }
                return idProducto;
            }
            catch (Exception ex) { throw; }
        }

        public void eliminarProductoDeCarritoProducto(int idCarrito, int idProducto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string deletequery = "DELETE FROM CARRITO_PRODUCTO WHERE CARRITOID = @idcarrito AND PRODUCTOID =@idprodcto";
                    using (SqlCommand cmd = new SqlCommand(deletequery, conn))
                    {
                        cmd.Parameters.AddWithValue("@idcarrito", idCarrito);
                        cmd.Parameters.AddWithValue("@idprodcto", idProducto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw; }
        }

        public CarritoProducto getProductoDesdeDetalleCarrito(int idCarrito, int idProducto)
        {
            try
            {
                CarritoProducto carritoProducto = new CarritoProducto();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT CARRITOID,PRODUCTOID,CANTIDAD,PRECIO_UNITARIO FROM CARRITO_PRODUCTO WHERE CARRITOID = @idcarrito AND PRODUCTOID = @idProducto;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);
                        cmd.Parameters.AddWithValue("@idcarrito", idCarrito);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                carritoProducto = CarritoProductoMapper.Map(reader);
                            }
                        }
                    }
                }
                return carritoProducto;
            }
            catch (Exception ex) { throw; }
        }

    }

}
