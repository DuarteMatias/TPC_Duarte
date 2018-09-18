using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Gestion_de_Alumnos
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
             AlumnoNegocio alum = new AlumnoNegocio();

            try
            {
                dgvAlumnos.DataSource = alum.listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
