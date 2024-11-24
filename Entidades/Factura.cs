using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private int facturaID;
        private DateTime fecha;
        private Carrito carrito;
        private Cliente cliente;
        private List<DetalleFactura> detalles;
        private double subtotal;
        private double impuestos;
        private double total;

        public int FacturaID { get => facturaID; set => facturaID = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Carrito Carrito { get => carrito; set => carrito = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<DetalleFactura> Detalles { get => detalles; set => detalles = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Impuestos { get => impuestos; set => impuestos = value; }
        public double Total { get => total; set => total = value; }

        public Factura()
        {
            detalles = new List<DetalleFactura>();
        }

        public void CalcularTotales()
        {
            subtotal = detalles.Sum(d => d.Cantidad * d.PrecioUnitario);
            impuestos = subtotal * 0.21; // Suponiendo un 21% de IVA
            total = subtotal + impuestos;
        }
    }
}
