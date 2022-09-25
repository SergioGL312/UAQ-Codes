using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormShell : System.Windows.Forms.Form
    {
        public FormShell()
        {
            InitializeComponent();
        }

        private void FormShell_Load(object sender, EventArgs e)
        {
            btnOrdenarShell.Enabled = false;
        }

        private void cmbCantiDatosShell_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void btnOrdenarShell_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenacion shell = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosShell.GetItemText(cmbCantiDatosShell.SelectedItem);

            if (item.Equals("10"))
            {
                size = 10;
                list = shell.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = shell.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = shell.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = shell.RandomList(size);
            }

            shell.setComparaciones(0);
            shell.setIntercambios(0);

            shell.shell(list);

            lblmostComparacionesShell.Text = shell.getComparaciones().ToString();
            lblmostInterShell.Text = shell.getIntercambios().ToString();

            lstBoxDatosOrdenadosShell.DataSource = shell.shell(list);
        }

        private void validarSeleccion()
        {
            if (cmbCantiDatosShell.SelectedIndex == 0 ||
                cmbCantiDatosShell.SelectedIndex == 1 ||
                cmbCantiDatosShell.SelectedIndex == 2 ||
                cmbCantiDatosShell.SelectedIndex == 3)
            {
                btnOrdenarShell.Enabled = true;
            }
        }

        
    }
}
