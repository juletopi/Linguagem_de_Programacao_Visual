using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horas_e_Minutos_WinForms
{
    public partial class Horas_e_Minutos_WinForms : Form
    {
        public Horas_e_Minutos_WinForms()
        {
            InitializeComponent();
        }

        private void btnHtoMin_Click(object sender, EventArgs e)
        {
            double valorHoras = 0, valorMinutos = 0;

            valorHoras = Convert.ToDouble(txtHoras.Text);
            valorMinutos = Convert.ToDouble(lblResultadoNum1.Text);

            valorMinutos = valorHoras * 60;

            lblResultadoNum1.Text = valorMinutos.ToString("0.00");
        }

        private void btnMintoH_Click(object sender, EventArgs e)
        {
            double valorHoras = 0, valorMinutos = 0;

            valorMinutos = Convert.ToDouble(txtMinutos.Text);
            valorHoras = Convert.ToDouble(lblResultadoNum2.Text);

            valorHoras = valorMinutos / 60;

            lblResultadoNum2.Text = valorHoras.ToString("0.00");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHoras.Clear();
            txtMinutos.Clear();
            txtHoras.Select();
            lblResultadoNum1.Text = "0";
            lblResultadoNum2.Text = "0";
        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinutos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultadoNum1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoNum2_Click(object sender, EventArgs e)
        {

        }
    }
}