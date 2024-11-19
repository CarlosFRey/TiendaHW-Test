using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Data;
using Entidades;

namespace Business
{
    public class CarritoProductoBLL
    {
        CarritoProductoDAO carritoProductoDAO = new CarritoProductoDAO();
        ProductosDAO productosDAO = new ProductosDAO();
        CarritoDAO carritoDAO = new CarritoDAO();

        public void AgregarProductosCarrito(int idCarrito, int idProducto, int Cantidad, double Precio)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (carritoDAO.getEstadoCarrito(idCarrito) != 1) { throw new Exception("El carrito no se encuentra Activo"); }
                    bajarStockProducto(idProducto, Cantidad);
                    carritoProductoDAO.AgregarProductosCarrito(idCarrito, idProducto, Cantidad, Precio);
                    trx.Complete();
                }

            }
            catch (Exception ex) { throw; }
        }
        public void bajarStockProducto(int idProducto, int Cantidad)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    int stock = productosDAO.getStockProducto(idProducto);
                    if (Cantidad > stock) { throw new Exception("No hay suficientes productos en stock"); }
                    trx.Complete();
                }
                
            }
            catch (Exception ex) { throw; }
        }

        public List<CarritoProducto> getCarritoProductos(int idCarrito)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    List<CarritoProducto> newlst = carritoProductoDAO.getCarritoProductos(idCarrito);
                    trx.Complete();
                    return newlst;
                }
                
            }
            catch (Exception ex) { throw; }
        }

        public List<DetalleCarrito> getDetalleCarritoProducto(int idCarrito)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    List<DetalleCarrito> detalleCarrito = new List<DetalleCarrito>();
                    List<CarritoProducto> lstCP = carritoProductoDAO.getCarritoProductos(idCarrito);
                    foreach (var CarritoProducto in lstCP)
                    {
                        DetalleCarrito nuevaLinea = new DetalleCarrito();
                        Producto detalleProducto = productosDAO.buscarProductoPorId(CarritoProducto.Producto.ProductoID);
                        nuevaLinea.Modelo = detalleProducto.Modelo;
                        nuevaLinea.Marca = productosDAO.buscarProductoPorId(CarritoProducto.Producto.ProductoID).Marca;
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
