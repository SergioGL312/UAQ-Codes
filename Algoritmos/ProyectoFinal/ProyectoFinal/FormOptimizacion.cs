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
    public partial class FormOptimizacion : Form
    {

        private static int acts;
        private static string valor = " ";
        private static string duracion = " ";

        public FormOptimizacion()
        {
            InitializeComponent();
        }

        private void btnGenerarLista_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtBCantidaddeNodos.Text) >= 1)
            {
                if (txtBCantidaddeNodos.TextLength == 0)
                {
                    MessageBox.Show("Ingrese solo numeros enteros positivos!)", "Aviso");
                }
                else
                {
                    acts = Convert.ToInt32(txtBCantidaddeNodos.Text);
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.RowCount = acts;
                    for (int j = 0; j < acts; ++j)
                    {
                        DataGridViewRow fila = dataGridView1.Rows[j];
                        fila.HeaderCell.Value = Convert.ToString(j + 1);
                        for (int x = 0; x < 3; x++)
                        {
                            fila.Cells[x].Value = 1;
                        }
                    }
                    dataGridView1.Columns[0].HeaderText = "Id";
                    dataGridView1.Columns[0].Width = 50;
                    /*dataGridView1.Columns[1].HeaderText = "Actividad";
                    dataGridView1.Columns[1].Width = 200;*/
                    dataGridView1.Columns[1].HeaderText = "Predecesoras";
                    dataGridView1.Columns[1].Width = 100;
                    dataGridView1.Columns[2].HeaderText = "Duracion";
                    dataGridView1.Columns[2].Width = 80;
                }
            }
        }

        private void txtBCantidaddeNodos_TextChanged(object sender, EventArgs e)
        {
            /*if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }*/
        }

        private void FormOptimizacion_Load(object sender, EventArgs e)
        {
            txtBCantidaddeNodos.Text = "2";
        }

        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            string cellcont = "";
            for (int j = 0; j < acts; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    cellcont = Convert.ToString(dataGridView1.Rows[j].Cells[i].Value);
                    //MessageBox.Show(cellcont);
                    if (cellcont == String.Empty)
                    {
                        //MessageBox.Show("Debe rellenar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (acts > 1)
            {
                valor = "";
                duracion = "";
                Activity[] list = null;
                list = GetActivities(list);
                list = WalkListAhead(list);
                list = WalkListAback(list);
                CriticalPath(list);
                txtBxMostRutaCritica.Text = valor;
                txtBxMostDuracionTot.Text = duracion;
            }
            else
            {
                MessageBox.Show("Debe ingresar las actividades primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public  Activity[] GetActivities(Activity[] list)
        {
            list = new Activity[acts];
            string nDurac;

            for (int i = 0; i < acts; i++)
            {
                Activity activity = new Activity();
                activity.Id = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                //activity.Duration = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                nDurac = dataGridView1.Rows[i].Cells[2].Value.ToString();
                activity.Duration = System.Convert.ToDecimal(nDurac);
                //===========
                string[] separators = { ",", "-" };
                string value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int npred = 0;
                foreach (var word in words)
                    npred++;
                //===========
                int np = npred;
                if (np != 0)
                {
                    activity.Predecessors = new Activity[np];
                    string id;

                    for (int j = 0; j < np; j++)
                    {
                        id = words[j];
                        Activity aux = new Activity();

                        if ((aux = aux.CheckActivity(list, id, i)) != null)
                        {
                            activity.Predecessors[j] = aux;
                            list[aux.GetIndex(list, aux, i)] = aux.SetSuccessors(aux, activity);
                        }
                        else
                        {
                            j--;
                            //MessageBox.Show("Ocurrio un error!, Verifique los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }

                    }
                }
                list[i] = activity;
            }
            return list;
        }

        private static Activity[] WalkListAhead(Activity[] list)
        {
            list[0].Eet = list[0].Est + list[0].Duration;

            try
            {
                for (int i = 1; i < acts; i++)
                {
                    foreach (Activity activity in list[i].Predecessors)
                    {
                        if (list[i].Est < activity.Eet)
                            list[i].Est = activity.Eet;
                    }
                    list[i].Eet = list[i].Est + list[i].Duration;
                }
            }
            catch (Exception)
            {
                //y el try..catch te hara libreeeeee!!!!!
            }
            return list;
        }
        private static Activity[] WalkListAback(Activity[] list)
        {
            list[acts - 1].Let = list[acts - 1].Eet;
            list[acts - 1].Lst = list[acts - 1].Let - list[acts - 1].Duration;
            try
            {
                for (int i = acts - 2; i >= 0; i--)
                {
                    try
                    {
                        try{
                            foreach (Activity activity in list[i].Successors)
                            {
                                if (list[i].Let == 0)
                                    list[i].Let = activity.Lst;
                                else
                                    if (list[i].Let > activity.Lst)
                                    list[i].Let = activity.Lst;
                            }
                            list[i].Lst = list[i].Let - list[i].Duration;
                        }catch (Exception)
                        {

                        }
                        
                    }
                    catch (Exception)
                    {

                    }
                    
                }
            }
            catch (Exception)
            {
                //y el try..catch te hara libreeeeee!!!!!
            }
            return list;
        }
        public static void CriticalPath(Activity[] list)
        {
            foreach (Activity activity in list)
            {
                if ((activity.Eet - activity.Let == 0) && (activity.Est - activity.Lst == 0))
                    valor = valor + "->" + activity.Id;
            }
            duracion = Convert.ToString(list[list.Length - 1].Eet);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("No se permiten campos vacios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SendKeys.Send("{ESC}");
                    e.Cancel = true;
                }

                if (e.ColumnIndex == 0)
                {
                    if (!this.EsEntero(e.FormattedValue.ToString()))
                    {
                        MessageBox.Show("Solo se permiten NUMEROS ENTEROS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SendKeys.Send("{ESC}");
                        e.Cancel = true;
                    }
                }

                if (e.ColumnIndex == 3)
                {
                    if (!this.EsDecimal(e.FormattedValue.ToString()))
                    {
                        MessageBox.Show("El dato ingresado debe ser NUMERICO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SendKeys.Send("{ESC}");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }
        private Boolean EsEntero(String numero)
        {
            try
            {
                int.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private Boolean EsDecimal(String numerodec)
        {
            decimal num;
            try
            {
                decimal.TryParse(numerodec, out num);
                //MessageBox.Show(Convert.ToString(num));
                if (num == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        
    }
}
