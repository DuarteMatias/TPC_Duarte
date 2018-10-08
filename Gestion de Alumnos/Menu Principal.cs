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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            controlUsuarioLogo1.BringToFront(); //TODO ver como puedo hacer para sacar el primer sidepanel
        }

        private void MenuPrincipal_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MoverForm();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseMove);
        }

        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        // 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // 
        // función privada usada para mover el formulario actual 

        private void MoverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAlumnos.Height;
            SidePanel.Top = btnAlumnos.Top;
            controlUsuarioAlumnos1.BringToFront();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDocentes.Height;
            SidePanel.Top = btnDocentes.Top;
            controlUsuarioDocentes1.BringToFront();
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborado por Duarte Matias.\nAMS Copyright reserved 2018.\nConsultas y/o sugerencias a duarte-matias@live.com.ar");
        }

        private void btnPadres_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPadres.Height;
            SidePanel.Top = btnPadres.Top;
            controlUsuarioPadres1.BringToFront();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
