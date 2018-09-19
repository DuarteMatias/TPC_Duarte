using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alumno
    {
        public int Legajo { set; get; } 
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public DateTime Fnac { set; get; }
        public string Email { set; get; }
        public Direccion Direccion { set; get; }
        public Telefono Telefono { set; get; }
        public int Dni { set; get; }
    }
}
