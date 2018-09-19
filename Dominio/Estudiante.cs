using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estudiante : Persona
    {
        public int Legajo { get; set; }
        public DateTime FAlta { get; set; }
        public DateTime FBaja { get; set; }
    }
}
