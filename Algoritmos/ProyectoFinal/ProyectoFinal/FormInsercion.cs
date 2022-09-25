using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormInsercion : System.Windows.Forms.Form
    {
        public FormInsercion()
        {
            InitializeComponent();
        }

        private void FormInsercion_Load(object sender, EventArgs e)
        {
            btnOrdenarInser.Enabled = false;
        }

        private void cmbCantiDatosInser_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }
        private void btnOrdenarInser_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenacion insercion = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosInser.GetItemText(cmbCantiDatosInser.SelectedItem);

            if (item.Equals("10"))
            {
                size = 10;
                list = insercion.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = insercion.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = insercion.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = insercion.RandomList(size);
            }

            insercion.setComparaciones(0);
            insercion.setIntercambios(0);

            insercion.insercion(list);

            lblmostInterInser.Text = insercion.getIntercambios().ToString();
            lblmostComparacionesInser.Text = insercion.getComparaciones().ToString();

            lstBoxDatosOrdenadosInser.DataSource = insercion.insercion(list);

        }

        private void validarSeleccion()
        {
            if (cmbCantiDatosInser.SelectedIndex == 0 ||
                cmbCantiDatosInser.SelectedIndex == 1 ||
                cmbCantiDatosInser.SelectedIndex == 2 ||
                cmbCantiDatosInser.SelectedIndex == 3)
            {
                btnOrdenarInser.Enabled = true;
            }
        }
    }
}
