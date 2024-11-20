using Entidades;
using Mapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class ProductosDAO
    {
        public void GuardarProducto(Producto producto)
        {
            //string conexion = "Data Source=pc-charly;Initial Catalog=LUGYMDS2;Integrated Security=True;Trust Server Certificate=True"
            SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess());
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO (Modelo, Marca, Stock, Precio, Categoria) VALUES (@Modelo, @Marca, @Stock, @Precio, @Categoria)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Modelo", producto.Modelo);
                        cmd.Parameters.AddWithValue("@Marca", producto.Marca);
                        cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                        cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw; }
        }

        public List<Producto> getProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess());
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ProductoID, Modelo, Marca, Stock, Precio, Categoria FROM PRODUCTO", conn);
                    using (cmd)
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaProductos.Add(ProductoMapper.Map(reader));
                            }
                           
                        }
                        
                    }

                }
                return listaProductos;
            }
            catch (Exception ex) { throw; }
        }
        public List<Producto> getProductos(int stock)
        {
            try
            {
                List<Producto> listaProductos = new List<Producto>();
                SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess());
                using (conn)
                {
                    conn.Open();
                    // Si stock = -1 entonces cambio la query y valor de stock para mostrar productos de stock 0
                    // si strock >= 0 entonces mantengo query original que muestra productos con stock (stock >= 1) o todos los productos (stock >= 0)
                    string query = "SELECT ProductoID, Modelo, Marca, Stock, Precio, Categoria FROM PRODUCTO WHERE Stock >= @stock";
                    if (stock == -1) { query = "SELECT ProductoID, Modelo, Marca, Stock, Precio, Categoria FROM PRODUCTO WHERE Stock = @stock"; stock = 0; }
                    //
                    //
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@stock",stock);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaProductos.Add(ProductoMapper.Map(reader));
                            }
                        }
                    }
                }
                return listaProductos;
            }
            catch (Exception ex) { throw; }
        }

        public string modificarProducto (Producto modificarProducto)
        {
            string resultadoOP = "No se realizaron cambios";
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "UPDATE PRODUCTO SET Modelo = @Modelo, Marca = @Marca, Stock = @Stock, Precio = @Precio, Categoria = @Categoria WHERE PRODUCTOID = @ProductoId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductoId", modificarProducto.ProductoID);
                        cmd.Parameters.AddWithValue("@Modelo", modificarProducto.Modelo);
                        cmd.Parameters.AddWithValue("@Marca", modificarProducto.Marca);
                        cmd.Parameters.AddWithValue("@Stock", modificarProducto.Stock);
                        cmd.Parameters.AddWithValue("@Precio", modificarProducto.Precio);
                        cmd.Parameters.AddWithValue("@Categoria", modificarProducto.Categoria);
                        cmd.ExecuteNonQuery();
                        resultadoOP = "Modificación exitosa";
                    }
                }
                return resultadoOP;
            }
            catch (Exception ex) { throw; }
        }

        public void eliminarProducto(Producto eliminarProducto)
        {
            try
            {
                string resultado = "No se eliminaron productos";
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTO WHERE PRODUCTOID = @ProductoId", conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductoId",eliminarProducto.ProductoID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw; }
        }

        public bool existeProducto(Producto producto)
        {
            try
            {
                bool resultado = false;
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCTO WHERE PRODUCTOID = @ProductoId", conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductoId",producto.ProductoID);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if(producto.ProductoID == Convert.ToInt32(reader["ProductoID"].ToString())) { resultado = true; }
                                    
                            }
                        }
                    }
                }
                return resultado;
            }
            catch (Exception ex) { throw; }
        }

        public List<string> getCategorias() 
        {
            List<string> listaCategorias = new List<string>();
            listaCategorias.Add("Todos");
            SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess());
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT Categoria FROM PRODUCTO", conn);
                    using (cmd)
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaCategorias.Add(reader["Categoria"].ToString());
                            }
                        }
                    }
                }
                return listaCategorias;
            }
            catch (Exception ex) { throw; }
        }

        public List<Producto> getProductos(int stock, string categoria)
        {
            try
            {
                List<Producto> listaProductos = new List<Producto>();
                SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess());
                using (conn)
                {
                    conn.Open();
                    // Si stock = -1 entonces cambio la query y valor de stock para mostrar productos de stock 0
                    // si strock >= 0 entonces mantengo query original que muestra productos con stock (stock >= 1) o todos los productos (stock >= 0)
                    string query = "SELECT ProductoID, Modelo, Marca, Stock, Precio, Categoria FROM PRODUCTO WHERE Stock >= @stock AND CATEGORIA = @Categoria";
                    if (stock == -1) { query = "SELECT ProductoID, Modelo, Marca, Stock, Precio, Categoria FROM PRODUCTO WHERE Stock = @stock AND CATEGORIA = @Categoria"; stock = 0; }
                    //
                    //
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@Categoria", categoria);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaProductos.Add(ProductoMapper.Map(reader));
                            }
                        }
                    }
                }
                return listaProductos;
            }
            catch (Exception ex) { throw; }
        }

        public Producto buscarProductoPorId(int idBuscado)
        {
            try
            {
                Producto productoEncontrado = new Producto();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ProductoID, Modelo, Marca, Stock, Precio, Categoria FROM PRODUCTO WHERE ProductoId = @IdBuscado", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdBuscado", idBuscado);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Producto producto = ProductoMapper.Map(reader);
                                if (producto.ProductoID == idBuscado) { productoEncontrado = producto; }
                            }
                        }
                    
                    }
                }
                return productoEncontrado;
            }
            catch (Exception ex) { throw; }
        }

        public int getStockProducto(int idProducto)
        {
            try
            {
                int stock = 0;
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ProductoID, Stock, Precio FROM PRODUCTO WHERE ProductoId = @idProducto", conn))
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (Convert.ToInt32(reader["ProductoID"].ToString()) == idProducto) { stock = Convert.ToInt32(reader["Stock"].ToString()); }
                            }
                        }
                    }
                }
                return stock;
            }
            catch (Exception ex) { throw; }
        }

        public void bajarStockProducto(int idProducto, int cantidad)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "UPDATE PRODUCTO set STOCK = STOCK-@cantidad WHERE PRODUCTOID = @idproducto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@idproducto", idProducto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw; }
        }
        public Producto GetProducto(int idProducto)
        {
            try
            {
                Producto producto = new Producto();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT ProductoID, Modelo, Marca, Stock, Precio, Categoria FROM PRODUCTO WHERE ProductoId = @idProducto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                producto = ProductoMapper.Map(reader);
                            }
                        }
                    }
                }
                return producto;
            }
            catch (Exception ex) { throw; }
        }

    }
}
