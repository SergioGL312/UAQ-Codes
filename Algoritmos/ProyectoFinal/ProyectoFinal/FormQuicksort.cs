using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormQuicksort : System.Windows.Forms.Form
    {
        public FormQuicksort()
        {
            InitializeComponent();
        }

        private void FormQuicksort_Load(object sender, EventArgs e)
        {
            btnOrdenarQui.Enabled = false;
        }

        private void cmbCantiDatosQui_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void btnOrdenarQui_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenacion quicksort = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosQui.GetItemText(cmbCantiDatosQui.SelectedItem);

            if (item.Equals("10"))
            {
                size = 10;
                list = quicksort.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = quicksort.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = quicksort.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = quicksort.RandomList(size);
            }
            if (item.Equals("100000"))
            {
                size = 100000;
                list = quicksort.RandomList(size);
            }

            quicksort.setComparaciones(0);
            quicksort.setIteraciones(0);

            quicksort.QuickSort(list);

            lblmostComparacionesQui.Text = quicksort.getComparaciones().ToString();
            lblmostIterQui.Text = quicksort.getIteraiones().ToString();

            lstBoxDatosOrdenadosQui.DataSource = quicksort.QuickSort(list);
        }

        private void validarSeleccion()
        {
            if (cmbCantiDatosQui.SelectedIndex == 0 ||
                cmbCantiDatosQui.SelectedIndex == 1 ||
                cmbCantiDatosQui.SelectedIndex == 2 ||
                cmbCantiDatosQui.SelectedIndex == 3 ||
                cmbCantiDatosQui.SelectedIndex == 4)
            {
                btnOrdenarQui.Enabled = true;
            }
        }

    }
}
