using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Gestion_de_Alumnos
{
    public partial class frmListadoDocentes : Form
    {
        public frmListadoDocentes()
        {
            InitializeComponent();
        }

        private void frmListadoDocentes_Load(object sender, EventArgs e)
        {
            DocenteNegocio doc = new DocenteNegocio();

            try
            {
                dgvDocentes.DataSource = doc.listar();
                //código que reescala la columnas para que quepan con el contenido de la misma.
                int i;
                for (i = 0; i < 6; i++)
                {
                    DataGridViewColumn column = dgvDocentes.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                dgvDocentes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//Se cambia el color Default de las columnas
                dgvDocentes.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;//Se cambia el color Default de las columnas
                dgvDocentes.EnableHeadersVisualStyles = false;
                //Se ordenan las columnas de manera manual.
                dgvDocentes.Columns["Legajo"].DisplayIndex = 0;
                dgvDocentes.Columns["Nombre"].DisplayIndex = 1;
                dgvDocentes.Columns["Apellido"].DisplayIndex = 2;
                dgvDocentes.Columns["DNI"].DisplayIndex = 3;
                dgvDocentes.Columns["Fnac"].DisplayIndex = 4;
                dgvDocentes.Columns["Email"].DisplayIndex = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["frmListadoDocentes"].Close();
            Show();
        }
    }
}
