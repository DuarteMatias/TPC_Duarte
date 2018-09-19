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
    public partial class frmListadoAlumnos : Form
    {
        public frmListadoAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
             AlumnoNegocio alum = new AlumnoNegocio();

            try
            {
                dgvAlumnos.DataSource = alum.listar();
                //código que reescala la columnas para que quepan con el contenido de la misma.
                int i;
                for (i = 0; i < 6; i++)
                {
                DataGridViewColumn column = dgvAlumnos.Columns[i];
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
        }
    }
}
