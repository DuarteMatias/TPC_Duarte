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
using Dominio;
using System.Data.SqlClient;

namespace Gestion_de_Alumnos
{
    public partial class frmBusquedaAlumno : Form
    {
        public frmBusquedaAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                   
            if (cmbLista.Text == "") {
                MessageBox.Show("DEBE SELECCIONAR UN MÉTODO DE BÚSQUEDA", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbLista.Text == "LEGAJO" && txtFiltro.Text == "") { MessageBox.Show("DEBE INGRESAR UN LEGAJO"); } // TODO Ver que queda mejor, si listar todo o el mensaje
            else if (cmbLista.Text == "LEGAJO")
            {

                AlumnoNegocio alum = new AlumnoNegocio();

                try
                {
                    dgvBusquedaAlumno.DataSource = alum.listarBusquedaLegajo(Convert.ToInt32(txtFiltro.Text));

                    dgvBusquedaAlumno.DataSource = alum.listarBusquedaLegajo(Convert.ToInt32(txtFiltro.Text));
                    dgvBusquedaAlumno.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//Se cambia el color Default de las columnas
                    dgvBusquedaAlumno.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;//Se cambia el color Default de las columnas
                    dgvBusquedaAlumno.EnableHeadersVisualStyles = false;
                    //Se ordenan las columnas de manera manual.
                    dgvBusquedaAlumno.Columns["Legajo"].DisplayIndex = 0;
                    dgvBusquedaAlumno.Columns["Nombre"].DisplayIndex = 1;
                    dgvBusquedaAlumno.Columns["Apellido"].DisplayIndex = 2;
                    dgvBusquedaAlumno.Columns["DNI"].DisplayIndex = 3;
                    dgvBusquedaAlumno.Columns["FechaNac"].DisplayIndex = 4;
                    dgvBusquedaAlumno.Columns["Email"].DisplayIndex = 5;

                    alum.listarBusquedaLegajo(Convert.ToInt32(txtFiltro.Text));
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else if (cmbLista.Text == "NOMBRE")
            {
                AlumnoNegocio alum = new AlumnoNegocio();

                try
                {
                    dgvBusquedaAlumno.DataSource = alum.listarBusquedaNombre(txtFiltro.Text);

                    dgvBusquedaAlumno.DataSource = alum.listarBusquedaNombre(txtFiltro.Text);
                    dgvBusquedaAlumno.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//Se cambia el color Default de las columnas
                    dgvBusquedaAlumno.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;//Se cambia el color Default de las columnas
                    dgvBusquedaAlumno.EnableHeadersVisualStyles = false;
                    //Se ordenan las columnas de manera manual.
                    dgvBusquedaAlumno.Columns["Legajo"].DisplayIndex = 0;
                    dgvBusquedaAlumno.Columns["Nombre"].DisplayIndex = 1;
                    dgvBusquedaAlumno.Columns["Apellido"].DisplayIndex = 2;
                    dgvBusquedaAlumno.Columns["DNI"].DisplayIndex = 3;
                    dgvBusquedaAlumno.Columns["FechaNac"].DisplayIndex = 4;
                    dgvBusquedaAlumno.Columns["Email"].DisplayIndex = 5;

                    alum.listarBusquedaNombre(txtFiltro.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_KeyPress_1(object sender, KeyPressEventArgs e) //Controla que no se ingresen letras o numeros si no corresponde con el metodo de busqueda
        {

        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e) //Cada vez que cambia el listbox, se vacia el textbox
        {
            txtFiltro.Text = "";
        }

        private void btnEliminarSeleccion_Click(object sender, EventArgs e)
        {
            AlumnoNegocio alum = new AlumnoNegocio();
            try
            {
                alum.baja((Alumno)dgvBusquedaAlumno.CurrentRow.DataBoundItem);
                MessageBox.Show("EL ALUMNO HA SIDO ELIMINADO EXITOSAMENTE"); // TODO Cambiar por un mensaje más copado
                this.Close(); //Regresa al control de usuario alumno
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarSeleccion_Click(object sender, EventArgs e)
        {
            Alumno modi;
            try
            {
                modi = (Alumno)dgvBusquedaAlumno.CurrentRow.DataBoundItem;
                frmAltaAlumnos alta = new frmAltaAlumnos(modi);
                alta.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e) // TODO Ver como se puede hacer para no repetir el mismo código
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (cmbLista.Text == "")
                {
                    MessageBox.Show("DEBE SELECCIONAR UN MÉTODO DE BÚSQUEDA", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cmbLista.Text == "LEGAJO" && txtFiltro.Text == "") { MessageBox.Show("DEBE INGRESAR UN LEGAJO"); } // TODO Ver que queda mejor, si listar todo o el mensaje
                else if (cmbLista.Text == "LEGAJO")
                {

                    AlumnoNegocio alum = new AlumnoNegocio();

                    try
                    {
                        dgvBusquedaAlumno.DataSource = alum.listarBusquedaLegajo(Convert.ToInt32(txtFiltro.Text));

                        dgvBusquedaAlumno.DataSource = alum.listarBusquedaLegajo(Convert.ToInt32(txtFiltro.Text));
                        dgvBusquedaAlumno.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//Se cambia el color Default de las columnas
                        dgvBusquedaAlumno.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;//Se cambia el color Default de las columnas
                        dgvBusquedaAlumno.EnableHeadersVisualStyles = false;
                        //Se ordenan las columnas de manera manual.
                        dgvBusquedaAlumno.Columns["Legajo"].DisplayIndex = 0;
                        dgvBusquedaAlumno.Columns["Nombre"].DisplayIndex = 1;
                        dgvBusquedaAlumno.Columns["Apellido"].DisplayIndex = 2;
                        dgvBusquedaAlumno.Columns["DNI"].DisplayIndex = 3;
                        dgvBusquedaAlumno.Columns["FechaNac"].DisplayIndex = 4;
                        dgvBusquedaAlumno.Columns["Email"].DisplayIndex = 5;

                        alum.listarBusquedaLegajo(Convert.ToInt32(txtFiltro.Text));
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                else if (cmbLista.Text == "NOMBRE")
                {
                    AlumnoNegocio alum = new AlumnoNegocio();

                    try
                    {
                        dgvBusquedaAlumno.DataSource = alum.listarBusquedaNombre(txtFiltro.Text);

                        dgvBusquedaAlumno.DataSource = alum.listarBusquedaNombre(txtFiltro.Text);
                        dgvBusquedaAlumno.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//Se cambia el color Default de las columnas
                        dgvBusquedaAlumno.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;//Se cambia el color Default de las columnas
                        dgvBusquedaAlumno.EnableHeadersVisualStyles = false;
                        //Se ordenan las columnas de manera manual.
                        dgvBusquedaAlumno.Columns["Legajo"].DisplayIndex = 0;
                        dgvBusquedaAlumno.Columns["Nombre"].DisplayIndex = 1;
                        dgvBusquedaAlumno.Columns["Apellido"].DisplayIndex = 2;
                        dgvBusquedaAlumno.Columns["DNI"].DisplayIndex = 3;
                        dgvBusquedaAlumno.Columns["FechaNac"].DisplayIndex = 4;
                        dgvBusquedaAlumno.Columns["Email"].DisplayIndex = 5;

                        alum.listarBusquedaNombre(txtFiltro.Text);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
