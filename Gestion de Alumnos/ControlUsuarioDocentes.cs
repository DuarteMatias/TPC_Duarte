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
    public partial class ControlUsuarioDocentes : UserControl
    {
        public ControlUsuarioDocentes()
        {
            InitializeComponent();
        }

        private void btnListadoDocentes_Click(object sender, EventArgs e)
        {
            frmListadoDocentes doc = new frmListadoDocentes();
            doc.ShowDialog();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaDocentes alta = new frmAltaDocentes();
            alta.ShowDialog();
        }
    }
}
