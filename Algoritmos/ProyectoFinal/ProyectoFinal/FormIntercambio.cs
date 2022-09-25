using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormIntercambio : System.Windows.Forms.Form
    {
        public FormIntercambio()
        {
            InitializeComponent();
        }

        private void FormIntercambio_Load(object sender, EventArgs e)
        {
            btnOrdenarInter.Enabled = false;
        }

        private void cmbCantiDatosInter_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void btnOrdenarInter_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenacion intercambio = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosInter.GetItemText(cmbCantiDatosInter.SelectedItem);

            if (item.Equals("10"))
            {
                size = 10;
                list = intercambio.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = intercambio.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = intercambio.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = intercambio.RandomList(size);
            }

            intercambio.setComparaciones(0);
            intercambio.setIntercambios(0);

            /*int[] arrayInter = new int[list.Count];
            arrayInter = list.ToArray();*/
            intercambio.intercambio(list);

            lblmostInterInter.Text = intercambio.getIntercambios().ToString();
            lblmostComparacionesInter.Text = intercambio.getComparaciones().ToString();

            lstBoxDatosOrdenadosInter.DataSource = intercambio.intercambio(list);
        }

        private void validarSeleccion()
        {
            if (cmbCantiDatosInter.SelectedIndex == 0 ||
                cmbCantiDatosInter.SelectedIndex == 1 ||
                cmbCantiDatosInter.SelectedIndex == 2 ||
                cmbCantiDatosInter.SelectedIndex == 3)
            {
                btnOrdenarInter.Enabled = true;
            }
        }

    }
}
