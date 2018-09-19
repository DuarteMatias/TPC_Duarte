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
        public DateTime Fnac { set; get; }
        public char Sexo { set; get; }
        public int Dni { set; get; }
    }
}
