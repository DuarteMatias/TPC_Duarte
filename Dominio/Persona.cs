using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public DateTime FechaNac { set; get; }
        public Direccion Direccion { get; set; }
        public char Sexo { set; get; }
        public string Dni { set; get; }
    }
}
