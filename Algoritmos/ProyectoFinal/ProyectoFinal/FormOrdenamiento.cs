using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormOrdenamiento : System.Windows.Forms.Form
    {
        public FormOrdenamiento()
        {
            InitializeComponent();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            FormBurbuja burbuja = new FormBurbuja();
            burbuja.Show();
        }

        private void btnBurbujaBandera_Click(object sender, EventArgs e)
        {
            FormBurbujaBandera burbujaBandera = new FormBurbujaBandera();
            burbujaBandera.Show();
        }

        private void btnIntercambio_Click(object sender, EventArgs e)
        {
            FormIntercambio intercambio = new FormIntercambio();
            intercambio.Show();
        }

        private void btnInsercion_Click(object sender, EventArgs e)
        {
            FormInsercion insercion = new FormInsercion();
            insercion.Show();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            FormSeleccion seleccion = new FormSeleccion();
            seleccion.Show();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            FormShell shell = new FormShell();
            shell.Show();
        }

        private void btnQuicksort_Click(object sender, EventArgs e)
        {
            FormQuicksort quicksort = new FormQuicksort();
            quicksort.Show();
        }

    }
}
