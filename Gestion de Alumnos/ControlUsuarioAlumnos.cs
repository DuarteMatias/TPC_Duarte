using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Alumnos
{
    public partial class ControlUsuarioAlumnos : UserControl
    {
        public ControlUsuarioAlumnos()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListadoAlumnos alum = new frmListadoAlumnos();
            alum.ShowDialog();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            frmAltaAlumnos alta = new frmAltaAlumnos();
            alta.ShowDialog();
        }

        private void btnBajasModificaciones_Click(object sender, EventArgs e)
        {
            frmBusquedaAlumno alum = new frmBusquedaAlumno();
            alum.ShowDialog();
        }
    }
}
