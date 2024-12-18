﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Data;
using DTO;
using Entidades;

namespace Business
{
    public class CarritoProductoBLL
    {
        CarritoProductoDAO carritoProductoDAO = new CarritoProductoDAO();
        ProductosDAO productosDAO = new ProductosDAO();
        CarritoDAO carritoDAO = new CarritoDAO();
        ProductosBLL productosBLL = new ProductosBLL();

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
                    productosDAO.bajarStockProducto(idProducto, Cantidad);
                    trx.Complete();
                }
                
            }
            catch (Exception ex) { throw; }
        }

        public List<CarritoProducto> getCarritoProductos(int idCarrito)
        {
            try
            {
                //using (var trx = new TransactionScope())
                {
                    List<CarritoProducto> newlst = carritoProductoDAO.getCarritoProductos(idCarrito);
                    foreach (var CP in newlst)
                    {
                        CP.Carrito = carritoDAO.GetCarrito(CP.Carrito.CarritoID);
                        CP.Producto = productosDAO.GetProducto(CP.Producto.ProductoID);
                    }

                    //trx.Complete();
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
                    //List<DetalleCarrito> detalleCarrito = new List<DetalleCarrito>();
                    //List<CarritoProducto> lstCP = carritoProductoDAO.getCarritoProductos(idCarrito);
                    List<DetalleCarrito> detalleCarrito = DGVDetalleCarritoDTO.DTO(carritoProductoDAO.getCarritoProductos(idCarrito));
                    trx.Complete();
                    return detalleCarrito;
                }
            }
            catch (Exception ex) { throw; }
        }

        public int getIDproductoDesdeDetalleCarrito(int nroFila)
        {
            try
            {
                if (carritoProductoDAO.getIDproductoDesdeDetalleCarrito(nroFila) == -1) { throw new Exception("Error en la eliminación del producto"); }
                return carritoProductoDAO.getIDproductoDesdeDetalleCarrito(nroFila);

            }
            catch (Exception ex) { throw; }
        }

        public string eliminarProductoDeCarritoProducto(int idCarrito, int idProducto)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    //int stock = carritoProductoDAO.getProductoDesdeDetalleCarrito(idCarrito, idProducto).Cantidad;
                    Producto producto = productosDAO.GetProducto(idProducto);
                    producto.Stock += carritoProductoDAO.getProductoDesdeDetalleCarrito(idCarrito, idProducto).Cantidad;
                    carritoProductoDAO.eliminarProductoDeCarritoProducto(idCarrito, idProducto);
                    productosBLL.modificarProducto(producto);
                    trx.Complete();
                    return "Se elimino el stock del carrito y se devolvió a stock correctamente";
                }
            }
            catch (Exception ex) { throw; }
        }

    }
}
