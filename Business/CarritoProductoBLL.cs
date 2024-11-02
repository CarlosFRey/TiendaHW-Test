using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (carritoDAO.getEstadoCarrito(idCarrito) != 1) { throw new Exception("El carrito no se encuentra Activo"); }
                bajarStockProducto(idProducto, Cantidad);
                carritoProductoDAO.AgregarProductosCarrito(idCarrito, idProducto, Cantidad, Precio);

            }
            catch (Exception ex) { throw; }
        }
        public void bajarStockProducto(int idProducto, int Cantidad)
        {
            try
            {
                int stock = productosDAO.getStockProducto(idProducto);
                if (Cantidad > stock) { throw new Exception("No hay suficientes productos en stock"); }
                
            }
            catch (Exception ex) { throw; }
        }

        public List<CarritoProducto> getCarritoProductos(int idCarrito)
        {
            try
            {
                return carritoProductoDAO.getCarritoProductos(idCarrito);
            }
            catch (Exception ex) { throw; }
        }

        public List<DetalleCarrito> getDetalleCarritoProducto(int idCarrito)
        {
            try
            {
                List<DetalleCarrito> detalleCarrito = new List<DetalleCarrito>();
                List<CarritoProducto> lstCP = carritoProductoDAO.getCarritoProductos(idCarrito);
                foreach (var CarritoProducto in lstCP)
                {
                    DetalleCarrito nuevaLinea = new DetalleCarrito();
                    Producto detalleProducto = productosDAO.buscarProductoPorId(CarritoProducto.ProductoID);
                    nuevaLinea.Modelo = detalleProducto.Modelo;
                    nuevaLinea.Marca = productosDAO.buscarProductoPorId(CarritoProducto.ProductoID).Marca;
                    nuevaLinea.Cantidad = CarritoProducto.Cantidad;
                    nuevaLinea.PrecioUnitario = CarritoProducto.PrecioUnitario;
                    detalleCarrito.Add(nuevaLinea);
                }
                return detalleCarrito;
            }
            catch (Exception ex) { throw; }
        }
    }
}
