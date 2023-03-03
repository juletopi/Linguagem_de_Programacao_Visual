using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_de_Desconto_WinForms
{
    public partial class Calc_de_Desconto : Form
    {
        public Calc_de_Desconto()
        {
            InitializeComponent();
        }

        private void lblPercDeDesconto_Click(object sender, EventArgs e)
        {

        }

        private void lblValorDaCompra_Click(object sender, EventArgs e)
        {

        }

        private void txtPercDeDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorDaCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoNum_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularDesconto_Click(object sender, EventArgs e)
        {
            double valorDaCompra = 0, percDeDesconto = 0, valorComDesconto = 0;

            valorDaCompra = Convert.ToDouble(txtValorDaCompra.Text);
            percDeDesconto = Convert.ToDouble(txtPercDeDesconto.Text);
            valorComDesconto = Convert.ToDouble(lblResultadoNum.Text);

            valorComDesconto = valorDaCompra - valorDaCompra * (percDeDesconto / 100);

            lblResultadoNum.Text = valorComDesconto.ToString("F");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPercDeDesconto.Clear();
            txtValorDaCompra.Clear();
            txtValorDaCompra.Select();
            lblResultadoNum.Text = "0";
        }
    }
}