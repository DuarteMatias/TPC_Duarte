using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Alumnos
{
    public partial class frmAltaAlumnos : Form
    {
        public frmAltaAlumnos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();
        }
    }
}
