﻿using System;
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
    public partial class ControlUsuarioPadres : UserControl
    {
        public ControlUsuarioPadres()
        {
            InitializeComponent();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            frmAltaPadres alta = new frmAltaPadres();
            alta.ShowDialog();
        }
    }
}
