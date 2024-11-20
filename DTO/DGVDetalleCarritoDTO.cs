using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Entidades;

namespace DTO
{
    public class DGVDetalleCarritoDTO
    {
        public static List<DetalleCarrito> DTO(List<CarritoProducto> cp)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    List<DetalleCarrito> detalleCarrito = new List<DetalleCarrito>();
                    foreach (var CarritoProducto in cp)
                    {
                        DetalleCarrito nuevaLinea = new DetalleCarrito();
                        nuevaLinea.Modelo = CarritoProducto.Producto.Modelo;
                        nuevaLinea.Marca = CarritoProducto.Producto.Marca;
                        nuevaLinea.Cantidad = CarritoProducto.Cantidad;
                        nuevaLinea.PrecioUnitario = CarritoProducto.PrecioUnitario;
                        detalleCarrito.Add(nuevaLinea);
                    }
                    trx.Complete();
                    return detalleCarrito;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
