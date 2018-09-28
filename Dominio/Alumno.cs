using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alumno : Estudiante
    {
        public string Email { set; get; }
        public Telefono Telefono { set; get; }
    }
}
