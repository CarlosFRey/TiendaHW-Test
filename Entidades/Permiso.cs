using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permiso
    {
        public int IdPermiso {  get; set; }
        public Rol Rol { get; set; }
        public string TipoMenu { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
