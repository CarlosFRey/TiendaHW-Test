using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        private Producto producto;
        private int cantidad;
        private double precioUnitario;

        public Producto Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }

        public double Subtotal
        {
            get { return Cantidad * PrecioUnitario; }
        }
    }
}
