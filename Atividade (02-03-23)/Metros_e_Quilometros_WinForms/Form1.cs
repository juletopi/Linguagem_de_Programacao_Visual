using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metros_e_Quilometros_WinForms
{
    public partial class Metros_e_Quilometros_WinForms : Form
    {
        public Metros_e_Quilometros_WinForms()
        {
            InitializeComponent();
        }

        private void btnQltoM_Click(object sender, EventArgs e)
        {
            double valorMetros = 0, valorQuilometros = 0;

            valorQuilometros = Convert.ToDouble(txtQuilometros.Text);
            valorMetros = Convert.ToDouble(lblResultadoNum2.Text);

            valorMetros = valorQuilometros * 1000;

            lblResultadoNum2.Text = valorMetros.ToString();
        }

        private void btnMtoQl_Click(object sender, EventArgs e)
        {
            double valorMetros = 0, valorQuilometros = 0;

            valorMetros = Convert.ToDouble(txtMetros.Text);
            valorQuilometros = Convert.ToDouble(lblResultadoNum1.Text);

            valorQuilometros = valorMetros / 1000;

            lblResultadoNum1.Text = valorQuilometros.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            txtQuilometros.Clear();
            txtMetros.Select();
            lblResultadoNum1.Text = "0";
            lblResultadoNum2.Text = "0";
        }

        private void txtMetros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuilometros_TextChanged(object sender, EventArgs e)
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