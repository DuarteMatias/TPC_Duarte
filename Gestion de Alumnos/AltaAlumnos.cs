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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Gestion_de_Alumnos
{

    public partial class frmAltaAlumnos : Form
    {
        public frmAltaAlumnos()
        {
            InitializeComponent();
            lblNumLegajo.Text = (AlumnoNegocio.UltimoLegajo() + 1).ToString();
        }

        public frmAltaAlumnos(Alumno modi)
        {
            InitializeComponent();
            alumno = modi;
        }

        private Alumno alumno = null;

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();
        }

        //private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

        //    {
        //        e.Handled = true;

        //        return;
        //    }
        //}

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AlumnoNegocio alum = new AlumnoNegocio();
            try
            {
                if (alumno == null)
                {
                    alumno = new Alumno();
                }
                alumno.Nombre = txtNombres.Text;
                alumno.Apellido = txtApellido.Text;
                alumno.FechaNac = dtpFechaNacimiento.Value;
                if (rBtnMasculino.Checked) alumno.Sexo = "M";
                else if (rBtnFemenino.Checked) alumno.Sexo = "F";
                alumno.Dni = txtDNI.Text;
                alumno.Email = txtEmail.Text;
                //nuevo.Direccion=
                //nuevo.Telefono = txtTelefono.Text;

                if (alumno.Legajo != 0)
                {
                    alum.modificar(alumno);
                }
                else
                {
                    alum.alta(alumno);

                    }

                MSB_Guardado_con_exito msb = new MSB_Guardado_con_exito();
                msb.ShowDialog();
                this.Close(); //Regresa al control de usuario alumno
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaAlumnos_Load(object sender, EventArgs e)
        {

            try
            {
                if (alumno != null)
                {
                    txtNombres.Text= alumno.Nombre;
                    txtApellido.Text = alumno.Apellido;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
