﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Data;
using Entidades;

namespace Business
{
 
    public class CarritoBLL
    {
        public CarritoDAO carritoDAO = new CarritoDAO();

        public string AgregarCarrito(int clienteCarrito)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    string resultado = carritoDAO.AgregarCarrito(clienteCarrito);
                    trx.Complete();
                    return resultado;
                }
            }
            catch (Exception ex) { throw; }
        }
        public int getEstadoCarrito(int idCarrito)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    int resultado = carritoDAO.getEstadoCarrito(idCarrito);
                    trx.Complete();
                    return resultado;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
