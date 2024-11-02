using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidades;


namespace Business
{
    public class ProductosBLL
    {
        private ProductosDAO productoDAO = new ProductosDAO();

        public void GuardarProducto(Producto producto)
        {
            try
            {
                if (producto.Marca == null || producto.Modelo == null || producto.Categoria == null || producto.Precio <= 0 || producto.Stock < 0)
                {
                    throw new Exception("Todos los campos deben tener valores, el precio debe ser mayor a 0 y el stock no puede ser negativo");
                }
                else { productoDAO.GuardarProducto(producto); }
            }
            catch (Exception ex) { throw; }
            
        }

        public List<Producto> getProductos()
        {
            try
            {
                return productoDAO.getProductos();
            }
            catch (Exception ex) { throw; }
        }
        public List<Producto> getProductos(int stock)
        {
            try
            {
                return productoDAO.getProductos(stock);
            }
            catch (Exception ex) { throw; }
        }
        public List<Producto> getProductos(int stock, string categoria)
        {
            try
            {
                if (categoria == "Todos")
                {
                    return productoDAO.getProductos(stock);
                }
                else
                {
                return productoDAO.getProductos(stock, categoria);
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
                else { return productoDAO.modificarProducto(modificarProducto); }

            }
            catch (Exception ex) { throw; }
        }
        public string eliminarProducto(Producto eliminarProducto)
        {
            try
            {
                string resultado = "No se encontraron productos";
                if (productoDAO.existeProducto(eliminarProducto) == false) { throw new Exception(resultado.ToString()); }
                productoDAO.eliminarProducto(eliminarProducto);
                if (productoDAO.existeProducto(eliminarProducto) == false) { resultado = "Producto eliminado"; }
                return resultado;
            }
            catch (Exception ex) { throw; }
        }

        public List<string> getCategorias()
        {
            try
            {
                return productoDAO.getCategorias();
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
                    return productoDAO.buscarProductoPorId(idBuscado);
                }
            }
            catch (Exception ex) { throw; }
        }

    }
}
