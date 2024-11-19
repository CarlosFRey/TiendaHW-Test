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
        private List<CarritoProducto> carritoProductos;
        private double montoTotal;
        private int estado;
                
        public int CarritoID { get => carritoID; set => carritoID = value; }
        public List<CarritoProducto> CarritoProductos { get => carritoProductos; set => carritoProductos = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
