using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        private int carritoID;
        private int clienteID;
        //private Cliente cliente;
        private double montoTotal;
        private int estado;
                
        public int CarritoID { get => carritoID; set => carritoID = value; }
        public int ClienteID { get => clienteID; set => clienteID = value; }
        //public Cliente Cliente { get => cliente; set => cliente = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
