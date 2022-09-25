using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormBurbuja : System.Windows.Forms.Form
    {
        public FormBurbuja()
        {
            InitializeComponent();
        }

        private void FormBurbuja_Load(object sender, EventArgs e)
        {
            btnOrdenarBurb.Enabled = false;
        }

        private void cmbCantiDatosBurb_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }
        private void btnOrdenarBurb_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenacion burbuja = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosBurb.GetItemText(cmbCantiDatosBurb.SelectedItem);

            if (item.Equals("10"))
            {
                size = 10;
                list = burbuja.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = burbuja.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = burbuja.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = burbuja.RandomList(size);
            }

            burbuja.setComparaciones(0);
            burbuja.setIntercambios(0);

            burbuja.burbuja(list);

            lblmostComparacionesBurb.Text = burbuja.getComparaciones().ToString();
            lblmostInterBurb.Text = burbuja.getIntercambios().ToString();

            lstBoxDatosOrdenadosBurb.DataSource = burbuja.burbuja(list);
        }

        private void validarSeleccion()
        {
            if (cmbCantiDatosBurb.SelectedIndex == 0 ||
                cmbCantiDatosBurb.SelectedIndex == 1 ||
                cmbCantiDatosBurb.SelectedIndex == 2 ||
                cmbCantiDatosBurb.SelectedIndex == 3)
            {
                btnOrdenarBurb.Enabled = true;
            }
        }
    }
}
