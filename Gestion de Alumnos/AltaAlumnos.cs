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
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

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
            Alumno nuevo = new Alumno();
            try
            {
                nuevo.Nombre = txtNombres.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.FechaNac = dtpFechaNacimiento.Value;
                if (rBtnMasculino.Checked) nuevo.Sexo = 'M';
                else if (rBtnFemenino.Checked) nuevo.Sexo = 'F';
                nuevo.Dni = txtDNI.Text;
                nuevo.Email = txtEmail.Text;
                //nuevo.Direccion=
                //nuevo.Telefono = txtTelefono.Text;

                alum.alta(nuevo);
                MessageBox.Show("ALUMNO GUARDADO CON ÉXITO"); 
                this.Close(); //Regresa al control de usuario alumno
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
