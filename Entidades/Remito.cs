using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Remito
    {
        private int remitoID;
        private int carritoID;
        private int numeroRemito;

        public int RemitoID { get => remitoID; set => remitoID = value; }
        public int CarritoID { get => carritoID; set => carritoID = value; }
        public int NumeroRemito { get => numeroRemito; set => numeroRemito = value; }
        public List<RemitoProducto> RemitoProductos = new List<RemitoProducto>();
    }
}
