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
    public class ClientesDAO
    {
        public void GuardarCliente(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
            {
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTE (Nombre, Apellido, CUIT, Email, Telefono, Direccion) VALUES (@Nombre, @Apellido, @CUIT, @Email, @Telefono, @Direccion)", conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                            cmd.Parameters.AddWithValue("@CUIT", cliente.Cuit);
                            cmd.Parameters.AddWithValue("@Email", cliente.Email);
                            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                            cmd.ExecuteNonQuery();
                        }

                    }
                }
                catch (Exception ex) { throw; }
            }

        }

        public List<Cliente> getClientes()
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT CLIENTEID, NOMBRE, APELLIDO, CUIT, EMAIL,TELEFONO,DIRECCION FROM CLIENTE", conn))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader()) {
                                while (reader.Read())
                                {
                                    listaClientes.Add(ClienteMapper.Map(reader));
                                }
                            }
                        }
                    }
                }
                return listaClientes;
            }
            catch (Exception ex) { throw; }
        }

        public bool encontrarCliente(Cliente cliente)
        {
            try
            {
                bool encontrado = false;
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM CLIENTE", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetDouble(3) == cliente.Cuit) { encontrado = true; }
                            }
                        }
                    }
                }
                return encontrado;
            }
            catch (Exception ex) { throw; }
        }
        public bool encontrarClienteID(int clienteID)
        {
            try
            {
                bool encontrado = false;
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM CLIENTE", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0) == clienteID) { encontrado = true; }
                            }
                        }
                    }
                }
                return encontrado;
            }
            catch (Exception ex) { throw; }
        }

        public List<Carrito> getCarritosCliente(int clienteId) 
        {
            try
            {
                List<Carrito> lstCarritos = new List<Carrito>();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT CARRITOID, CLIENTE_ID, MONTO_TOTAL, ESTADO FROM CARRITO WHERE CLIENTE_ID = @idcliente", conn))
                        {
                            cmd.Parameters.AddWithValue("idcliente", clienteId);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (clienteId == reader.GetInt32(1)) 
                                    {
                                        Carrito carrito = new Carrito();

                                        carrito.CarritoID = reader.GetInt32(0);
                                        carrito.MontoTotal = reader.GetDouble(2);
                                        carrito.Estado = reader.GetInt32(3);
                                        lstCarritos.Add(carrito);
                                    }
                                }
                            }
                        }
                    }
                }
                return lstCarritos;
            }
            catch (Exception ex) { throw; }
        }

        public Cliente GetCliente(int clienteId)
        {
            try
            {
                Cliente cliente = new Cliente();
                using (SqlConnection conn = new SqlConnection(DBConnection.GetDBAccess()))
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT CLIENTEID, NOMBRE, APELLIDO, CUIT, EMAIL,TELEFONO,DIRECCION FROM CLIENTE", conn))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = ClienteMapper.Map(reader);
                                }
                            }
                        }
                    }
                }
                return cliente;
            }
            catch (Exception ex) { throw; }
        }


    }

}
