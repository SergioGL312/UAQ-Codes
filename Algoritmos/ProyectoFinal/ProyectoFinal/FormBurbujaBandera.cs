using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormBurbujaBandera : System.Windows.Forms.Form
    {
        public FormBurbujaBandera()
        {
            InitializeComponent();
        }
        private void FormBurbujaBandera_Load(object sender, EventArgs e)
        {
            btnOrdenarBurbBand.Enabled = false;
        }

        private void cmbCantiDatosBurbBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void btnOrdenarBurbBand_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenacion burbujaBandera = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosBurbBand.GetItemText(cmbCantiDatosBurbBand.SelectedItem);

            if (item.Equals("10"))
            {
                size = 10;
                list = burbujaBandera.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = burbujaBandera.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = burbujaBandera.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = burbujaBandera.RandomList(size);
            }

            burbujaBandera.setComparaciones(0);
            burbujaBandera.setIntercambios(0);

            burbujaBandera.burbujaBandera(list);

            lblmostComparacionesBurbBand.Text = burbujaBandera.getComparaciones().ToString();
            lblmostInterBurbBand.Text = burbujaBandera.getIntercambios().ToString();

            lstBoxDatosOrdenadosBurbBand.DataSource = burbujaBandera.burbujaBandera(list);
        }

        private void validarSeleccion()
        {
            if (cmbCantiDatosBurbBand.SelectedIndex == 0 ||
                cmbCantiDatosBurbBand.SelectedIndex == 1 ||
                cmbCantiDatosBurbBand.SelectedIndex == 2 ||
                cmbCantiDatosBurbBand.SelectedIndex == 3)
            {
                btnOrdenarBurbBand.Enabled = true;
            }
        }
    }
}
