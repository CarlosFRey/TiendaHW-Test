using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return carritoDAO.AgregarCarrito(clienteCarrito);
            }
            catch (Exception ex) { throw; }

        }
        public int getEstadoCarrito(int idCarrito)
        {
            try
            {
                return carritoDAO.getEstadoCarrito(idCarrito);
            }
            catch (Exception ex) { throw; }
        }
    }
}
