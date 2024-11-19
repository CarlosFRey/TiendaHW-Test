using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CarritoProducto
    {
        //private int carritoID;
        //private int productoID;
        private Carrito carrito;
        private Producto producto;
        private int cantidad;
        private double precioUnitario;

        //public int CarritoID { get => carritoID; set => carritoID = value; }
        //public int ProductoID { get => productoID; set => productoID = value; }
        public Carrito Carrito { get => carrito; set => carrito = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }

    }
}
