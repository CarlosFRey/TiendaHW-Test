using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int productoID;
        private string modelo;
        private string marca;
        private int stock;
        private double precio;
        private string categoria;

        public int ProductoID { get => productoID; set => productoID = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        public List<CarritoProducto> CarritoProductos { get; set; } = new List<CarritoProducto>();
        public List<RemitoProducto> RemitoProductos { get; set; } = new List<RemitoProducto>();
    }
}
