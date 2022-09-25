using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormSeguridad : System.Windows.Forms.Form
    {
        public FormSeguridad()
        {
            InitializeComponent();
        }

        private void FormSeguridad_Load(object sender, EventArgs e)
        {
            lblMostTamContrasena.Text = trkBTam.Value.ToString();
        }

        private void trkBTam_Scroll(object sender, EventArgs e)
        {
            lblMostTamContrasena.Text = trkBTam.Value.ToString();
        }

        private void btnGenerarContra_Click(object sender, EventArgs e)
        {
            AlgoritmodeSeguridad password = new AlgoritmodeSeguridad();
            int size = trkBTam.Value;
            
            txtBmostContra.Text = password.generarContra(size);
        }
    }
}
