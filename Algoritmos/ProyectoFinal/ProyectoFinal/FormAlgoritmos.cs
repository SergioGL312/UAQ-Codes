using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmAlgoritmos : System.Windows.Forms.Form
    {
        public frmAlgoritmos()
        {
            InitializeComponent();
        }

        private void btnOrdenacion_Click(object sender, EventArgs e)
        {
            FormOrdenamiento order = new FormOrdenamiento();
            order.Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FormBusqueda busqueda = new FormBusqueda();
            busqueda.Show();
        }

        private void btnOptimizacion_Click(object sender, EventArgs e)
        {
            FormOptimizacion optimi = new FormOptimizacion();
            optimi.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            FormSeguridad x = new FormSeguridad();
            x.Show();
        }
    }
}
