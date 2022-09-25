using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormBusqueda : System.Windows.Forms.Form
    {
        public FormBusqueda()
        {
            InitializeComponent();
        }

        private void btnLineal_Click(object sender, EventArgs e)
        {
            FormLineal lineal = new FormLineal();
            lineal.Show();
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            FormBinaria binaria = new FormBinaria();
            binaria.Show();
        }
    }
}
