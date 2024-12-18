﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Data;
using Entidades;


namespace Business
{
    public class ProductosBLL
    {
        private ProductosDAO productoDAO = new ProductosDAO();
        private CarritoProductoDAO carritoProductoDAO = new CarritoProductoDAO();

        public void GuardarProducto(Producto producto)
        {
            try
            {
                if (producto.Marca == null || producto.Modelo == null || producto.Categoria == null || producto.Precio <= 0 || producto.Stock < 0)
                {
                    throw new Exception("Todos los campos deben tener valores, el precio debe ser mayor a 0 y el stock no puede ser negativo");
                }
                else 
                {
                    using (var trx = new TransactionScope())
                    {
                        productoDAO.GuardarProducto(producto); 
                        trx.Complete();
                    }
                }
            }
            catch (Exception ex) { throw; }
            
        }

        public List<Producto> getProductos()
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    List<Producto> lstProductos = productoDAO.getProductos();
                    trx.Complete();
                    return lstProductos;
                }
            }
            catch (Exception ex) { throw; }
        }
        public List<Producto> getProductos(int stock)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    List<Producto> lstProductos = productoDAO.getProductos(stock);
                    trx.Complete();
                    return lstProductos;
                }
            }
            catch (Exception ex) { throw; }
        }
        public List<Producto> getProductos(int stock, string categoria)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    List<Producto> lstProductos = new List<Producto>();
                    if (categoria == "Todos")
                    {
                        lstProductos =  productoDAO.getProductos(stock);
                        trx.Complete();
                    }
                    else
                    {
                        lstProductos = productoDAO.getProductos(stock, categoria);
                        trx.Complete();
                    }
                    return lstProductos;
                }
            }
            catch (Exception ex) { throw; }
        }

        public string modificarProducto(Producto modificarProducto)
        {
            try
            {
                if (string.IsNullOrEmpty(modificarProducto.Marca) || string.IsNullOrEmpty(modificarProducto.Modelo) || string.IsNullOrEmpty(modificarProducto.Categoria) ||
                    modificarProducto.Precio <= 0 || modificarProducto.Stock < 0 || string.IsNullOrEmpty(modificarProducto.ProductoID.ToString()) || modificarProducto.ProductoID < 0)
                {
                    throw new Exception("Validación de datos a modificar incorrecta, verifique los datos a modificar");
                }
                else 
                {
                    using (var trx = new TransactionScope())
                    {
                        string mensaje = productoDAO.modificarProducto(modificarProducto); 
                        trx.Complete();
                        return mensaje;
                    }
                }

            }
            catch (Exception ex) { throw; }
        }
        public string eliminarProducto(Producto eliminarProducto)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    string resultado = "No se encontraron productos";
                    if (productoDAO.existeProducto(eliminarProducto) == false) { throw new Exception(resultado.ToString()); }
                    List<int> lstCarritos = carritoProductoDAO.existeEnCarrito(eliminarProducto);
                    if (lstCarritos.Count != 0) {throw new Exception("No se puede eliminar un producto existente en carritos activos, elimine primero el producto de los carritos");}
                    if (eliminarProducto.Stock != 0) { throw new Exception("No se puede eliminar un producto cuyo stock sea diferente a 0, modifique antes el stock"); }
                    productoDAO.eliminarProducto(eliminarProducto);
                    if (productoDAO.existeProducto(eliminarProducto) == false) { resultado = "Producto eliminado"; }
                    trx.Complete(); 
                    return resultado;
                }
            }
            catch (Exception ex) { throw; }
        }

        public List<string> getCategorias()
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    List<string> categorias = productoDAO.getCategorias();
                    trx.Complete();
                    return categorias;
                }
            }
            catch (Exception ex) { throw; }
        }

        public Producto buscarProductoPorId(int idBuscado)
        {
            try
            {
                if ( string.IsNullOrEmpty(productoDAO.buscarProductoPorId(idBuscado).ProductoID.ToString())) { throw new Exception("Producto no encontrado"); }
                else
                {
                    using (var trx = new TransactionScope())
                    {
                        Producto producto = productoDAO.buscarProductoPorId(idBuscado);
                        trx.Complete();
                        return producto;
                    }
                }
            }
            catch (Exception ex) { throw; }
        }

    }
}
