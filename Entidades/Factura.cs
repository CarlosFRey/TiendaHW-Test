using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private int nroFactura;
        private int clienteID;
        private Cliente cliente;
        private int carritoID;
        private Carrito carrito;
        private double monto_total;
        private int estado;

        public int NroFactura { get => nroFactura; set => nroFactura = value; }
        public int ClienteID { get => clienteID; set => clienteID = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int CarritoID { get => carritoID; set => carritoID = value; }
        public Carrito Carrito { get => carrito; set => carrito = value; }
        public double Monto_total { get => monto_total; set => monto_total = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
