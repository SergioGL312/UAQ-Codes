using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormLineal : System.Windows.Forms.Form
    {

        public FormLineal()
        {
            InitializeComponent();
        }
        private void FormLineal_Load(object sender, EventArgs e)
        {
            btnBuscarLineal.Enabled = false;
        }

        private void cmbCantiDatosBusqLineal_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void txtBoxNumBusqLineal_TextChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void btnBuscarLineal_Click(object sender, EventArgs e)
        {
            AlgoritmosdeBusqueda lineal = new AlgoritmosdeBusqueda();
            AlgoritmosdeOrdenacion random = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosBusqLineal.GetItemText(cmbCantiDatosBusqLineal.SelectedItem);
            string numBuscar = txtBoxNumBusqLineal.Text;
            int nB = int.Parse(numBuscar);

            if (item.Equals("10"))
            {
                size = 10;
                list = random.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = random.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = random.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = random.RandomList(size);
            }

            DateTime inicio = DateTime.Now;
            lineal.busquedaLineal(nB, list);
            DateTime fin = DateTime.Now;

            lblMostPosiLineal.Text = lineal.getIndice().ToString();
            lblMostCompsLineal.Text = lineal.getComparaciones().ToString();//comparaciones
            lblMostTiempoBusqLineal.Text = (fin - inicio).TotalMilliseconds.ToString();//tiempo busqueda
            
            lstBoxBusquedaLineal.DataSource = list;
        }

        /*private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtBoxNumBusqLineal.Text);
            btnBuscarLineal.Enabled = vr;
            MessageBox.Show("ES: " + vr);
        }*/

        private void validarSeleccion()
        {
            if ((cmbCantiDatosBusqLineal.SelectedIndex == 0 ||
                cmbCantiDatosBusqLineal.SelectedIndex == 1 ||
                cmbCantiDatosBusqLineal.SelectedIndex == 2 ||
                cmbCantiDatosBusqLineal.SelectedIndex == 3) &&
                !string.IsNullOrEmpty(txtBoxNumBusqLineal.Text))
            {
                btnBuscarLineal.Enabled = true;
            }
        }

        
    }
}
