using Entidades;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CarritoDAO
    {
        ClientesDAO clientedao = new ClientesDAO();
        public string AgregarCarrito(int clienteCarrito) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    connection.Open();
                    string cadenaNuevoCarrito = "INSERT INTO CARRITO (CLIENTE_ID, MONTO_TOTAL, ESTADO) VALUES (@clienteId, @MontoTotal, @Estado)";
                    using (SqlCommand cmd = new SqlCommand(cadenaNuevoCarrito, connection))
                    {
                        cmd.Parameters.AddWithValue("@clienteId", clienteCarrito);
                        cmd.Parameters.AddWithValue("@MontoTotal", 0);
                        cmd.Parameters.AddWithValue("@Estado", 1);
                        cmd.ExecuteNonQuery();
                    }
                }
                string mensajeSalida = "Carrito creado con éxito";
                return mensajeSalida;
            }catch (Exception ex) { throw new Exception("Ocurrió un error al agregar el carrito.", ex); }
        }


        public int getEstadoCarrito(int idCarrito)
        {
            try
            {
                int estado = 0;
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    string query = "SELECT ESTADO FROM CARRITO WHERE CARRITOID = @CarritoId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarritoId", idCarrito);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estado = reader.GetInt32(0);
                            }
                        }
                    }
                }
                return estado;
            }
            catch (Exception ex) { throw; }
        }

        public Carrito GetCarrito(int idCarrito)
        {
            try
            {
                Carrito carrito = new Carrito();
                using (SqlConnection conn2 = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn2.Open();
                    string query = "SELECT CARRITOID, CLIENTE_ID, MONTO_TOTAL, ESTADO FROM CARRITO WHERE CARRITOID = @CarritoId";

                    using (SqlCommand cmd = new SqlCommand(query, conn2))
                    {
                        cmd.Parameters.AddWithValue("@CarritoId", idCarrito);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = clientedao.GetCliente(Convert.ToInt32(reader["CLIENTE_ID"]));
                                carrito = CarritoMapper.Map(reader, cliente);
                            }
                        }
                    }
                }
                return carrito;
            }
            catch (Exception ex) { throw; }
        }


    }
}
