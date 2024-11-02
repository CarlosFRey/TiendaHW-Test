using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Data
{
    public class CarritoProductoDAO
    {
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
                    string query = "SELECT * FROM CARRITO_PRODUCTO WHERE CARRITOID = @IdCarrito";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("IdCarrito", idCarrito);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CarritoProducto cp = new CarritoProducto();
                                cp.CarritoID = reader.GetInt32(0);
                                cp.ProductoID = reader.GetInt32(1);
                                cp.Cantidad = reader.GetInt32(2);
                                cp.PrecioUnitario = reader.GetDouble(3);
                                lstCarritoProducto.Add(cp);
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
