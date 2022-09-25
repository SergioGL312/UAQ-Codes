using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormSeleccion : System.Windows.Forms.Form
    {
        public FormSeleccion()
        {
            InitializeComponent();
        }

        private void FormSeleccion_Load(object sender, EventArgs e)
        {
            btnOrdenarSelec.Enabled = false;
        }

        private void cmbCantiDatosSelec_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarSeleccion();
        }

        private void btnOrdenarSelec_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOrdenacion seleccion = new AlgoritmosdeOrdenacion();
            List<int> list = new List<int>();
            int size = 0;
            string item = cmbCantiDatosSelec.GetItemText(cmbCantiDatosSelec.SelectedItem);

            if (item.Equals("10"))
            {
                size = 10;
                list = seleccion.RandomList(size);
            }
            if (item.Equals("100"))
            {
                size = 100;
                list = seleccion.RandomList(size);
            }
            if (item.Equals("1000"))
            {
                size = 1000;
                list = seleccion.RandomList(size);
            }
            if (item.Equals("10000"))
            {
                size = 10000;
                list = seleccion.RandomList(size);
            }

            seleccion.setComparaciones(0);
            seleccion.setIntercambios(0);

            seleccion.seleccion(list);

            lblmostInterSelec.Text = seleccion.getIntercambios().ToString();
            lblmostComparacionesSelec.Text = seleccion.getComparaciones().ToString();

            lstBoxDatosOrdenadosSelec.DataSource = seleccion.seleccion(list);
        }

        private void validarSeleccion()
        {
            if (cmbCantiDatosSelec.SelectedIndex == 0 ||
                cmbCantiDatosSelec.SelectedIndex == 1 ||
                cmbCantiDatosSelec.SelectedIndex == 2 ||
                cmbCantiDatosSelec.SelectedIndex == 3)
            {
                btnOrdenarSelec.Enabled = true;
            }
        }

    }
}
