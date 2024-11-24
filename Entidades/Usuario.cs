using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public Rol Rol { get; set; }
        public  int DNI { get; set; }
        public string NombreCompleto { get; set; }
        public string Clave {  get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
