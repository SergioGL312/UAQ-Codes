using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormBinaria : System.Windows.Forms.Form
    {
        public FormBinaria()
        {
            InitializeComponent();
        }

        private void FormBinaria_Load(object sender, EventArgs e)
        {
            btnBuscarBusqBinaria.Enabled = false;
        }

        private void cmbCantiDatosBusqBinaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void txtBoxNumBusqBinaria_TextChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void btnBuscarBusqBinaria_Click(object sender, EventArgs e)
        {
            AlgoritmosdeBusqueda binaria = new AlgoritmosdeBusqueda();
            AlgoritmosdeOrdenacion randm = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosBusqBinaria.GetItemText(cmbCantiDatosBusqBinaria.SelectedItem);
            string numBuscar = txtBoxNumBusqBinaria.Text;
            int nB = int.Parse(numBuscar);

            if (item.Equals("10"))
            {
                size = 10;
                list = randm.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = randm.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = randm.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = randm.RandomList(size);
            }

            List<int> lPivote = new List<int>();

            binaria.setPivotes(lPivote);

            DateTime inicio = DateTime.Now;
            binaria.busquedaBinaria(nB, list);
            DateTime fin = DateTime.Now;

            lPivote = binaria.getPivotes();

            lblMostPosiBinaria.Text = binaria.getIndice().ToString();
            lblMostCompsBinaria.Text = binaria.getComparaciones().ToString();
            lblMostTiempoBusqBinaria.Text = (fin - inicio).TotalMilliseconds.ToString();
            lblMostPivotesBusqBinaria.Text = lPivote.Count().ToString();

            lstBoxPivotesBusqBinaria.DataSource = lPivote;
            lstBoxBusquedaBinaria.DataSource = list;
        }

        private void validarSeleccion()
        {
            if ((cmbCantiDatosBusqBinaria.SelectedIndex == 0 ||
                cmbCantiDatosBusqBinaria.SelectedIndex == 1 ||
                cmbCantiDatosBusqBinaria.SelectedIndex == 2 ||
                cmbCantiDatosBusqBinaria.SelectedIndex == 3) &&
                !string.IsNullOrEmpty(txtBoxNumBusqBinaria.Text))
            {
                btnBuscarBusqBinaria.Enabled = true;
            }
        }
    }
}
