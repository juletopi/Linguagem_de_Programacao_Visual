using System;
using System.Windows.Forms;

namespace Calculadora_WinForms
{
    public partial class Calculadora_Simples : Form
    {
        public Calculadora_Simples()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResultadoNum.Text = (float.Parse(txtValor1.Text) + float.Parse(txtValor2.Text) + float.Parse(txtValor3.Text) + float.Parse(txtValor4.Text)).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultadoNum.Text = (float.Parse(txtValor1.Text) - float.Parse(txtValor2.Text) - float.Parse(txtValor3.Text) - float.Parse(txtValor4.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultadoNum.Text = (float.Parse(txtValor1.Text) * float.Parse(txtValor2.Text) * float.Parse(txtValor3.Text) * float.Parse(txtValor4.Text)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultadoNum.Text = (float.Parse(txtValor1.Text) / float.Parse(txtValor2.Text) / float.Parse(txtValor3.Text) / float.Parse(txtValor4.Text)).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor3.Clear();
            txtValor4.Clear();
            txtValor1.Select();
            lblResultadoNum.Text = "0";
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoNum_Click(object sender, EventArgs e)
        {

        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }

        private void lblValor2_Click(object sender, EventArgs e)
        {

        }

        private void lblValor3_Click(object sender, EventArgs e)
        {

        }

        private void lblValor4_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}