﻿using Entidades;
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
            }catch (Exception ex) { throw; }
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


    }
}
