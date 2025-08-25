using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void onlyDigits(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                errIngresoDatos.SetError((Control)sender, "Solo se permiten números enteros.");
                e.Handled = true;
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(numero); i += 2) // solo impares desde el 3
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesde.Text) || string.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errIngresoDatos.Clear();
                return;
            }

            if (int.Parse(txtDesde.Text) <= int.Parse(txtHasta.Text))
            {
                lstNumeros.Items.Clear();
                chart1.Series.Clear();

                var series = chart1.Series.Add("Números");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                int desde, hasta;
                desde = int.Parse(txtDesde.Text);
                hasta = int.Parse(txtHasta.Text);

                bool mostrar = false;
                for (int i = desde; i <= hasta; i++)
                {
                    if (!chkPares.Checked && !chkImpares.Checked && !chkPrimos.Checked)
                    {
                        mostrar = true;
                    }

                    if ((chkPares.Checked && i % 2 == 0) ||
                        (chkImpares.Checked && i % 2 != 0) ||
                        (chkPrimos.Checked && EsPrimo(i)))
                    {
                        mostrar = true;
                    }

                    if (mostrar)
                    {
                        lstNumeros.Items.Add(i);
                        series.Points.AddXY(i, i);
                        mostrar = false;
                    }
                }

            }
            else
            {
                MessageBox.Show("El valor 'Desde' debe ser menor o igual al valor 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            errIngresoDatos.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
            chart1.Series.Clear();
        }

        private void frm4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
