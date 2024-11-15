using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace Business
{
    public class ClientesBLL
    {
        public ClientesDAO clienteDao = new ClientesDAO();
        public void guardarCliente(Cliente cliente)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (string.IsNullOrEmpty(cliente.Nombre)) { throw new Exception("Debe completar el nombre del cliente para registrarlo"); }
                    if (string.IsNullOrEmpty(cliente.Apellido)) { throw new Exception("Debe completar el Apellido del cliente para registrarlo"); }
                    if (cliente.Cuit.ToString().Length != 11) { throw new Exception("El CUIT/CUIL del cliente debe tener 11 caracteres"); }
                    if (cliente.Telefono.ToString().Length < 10) { throw new Exception("El teléfono debe ingresarse con código de área. EJ: 1122223333"); }
                    if (ValidoEmail(cliente.Email) != true ) { throw new Exception("El email ingresado: " +cliente.Email.ToString() + " no es correcto."); }
                    if (clienteDao.encontrarCliente(cliente) == true) { throw new Exception("El cliente ya existe en la base de datos"); }
                    clienteDao.GuardarCliente(cliente);
                    trx.Complete();
                }
            }
            catch (Exception ex) { throw; }
        }
        private bool ValidoEmail(string email)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Copiado de internet, funciona... investigar
                    return Regex.IsMatch(email, patronEmail);
                    trx.Complete();
                }
            }
            catch (Exception ex) { throw; }
        }

        public List<Cliente> GetClientes()
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    return clienteDao.getClientes();
                    trx.Complete();
                }
            }
            catch (Exception ex) { throw; }
        }

        public List<Carrito> getCarritosCliente(int clienteId)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (clienteDao.encontrarClienteID(clienteId) == false) { throw new Exception("No se ha encontrado el cliente"); }
                    return clienteDao.getCarritosCliente(clienteId);
                    trx.Complete();
                }
            }catch (Exception ex) { throw; }
            
        }

    }
}
