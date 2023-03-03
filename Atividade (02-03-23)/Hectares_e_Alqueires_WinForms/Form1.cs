using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hectares_e_Alqueire_WinForms
{
    public partial class Hectares_e_Alqueire_WinForms : Form
    {
        public Hectares_e_Alqueire_WinForms()
        {
            InitializeComponent();
        }

        private void lblHectare_Click(object sender, EventArgs e)
        {

        }

        private void txtHectare_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultadoNum_Click(object sender, EventArgs e)
        {

        }

        private void btnConverterAlqueire_Click(object sender, EventArgs e)
        {
            double valorHectare = 0, valorAlqueire = 0;

            valorHectare = Convert.ToDouble(txtHectare.Text);
            valorAlqueire = Convert.ToDouble(lblResultadoNum1.Text);

            valorAlqueire = valorHectare * 2.42;

            lblResultadoNum1.Text = valorAlqueire.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHectare.Clear();
            txtAlqueire.Clear();
            txtHectare.Select();
            lblResultadoNum1.Text = "0";
            lblResultadoNum2.Text = "0";
        }

        private void lblResultado1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado2_Click(object sender, EventArgs e)
        {

        }

        private void btnConverterHectare_Click(object sender, EventArgs e)
        {
            double valorHectare = 0, valorAlqueire = 0;

            valorAlqueire = Convert.ToDouble(txtAlqueire.Text);
            valorHectare = Convert.ToDouble(lblResultadoNum2.Text);

            valorHectare = valorAlqueire / 2.42;

            lblResultadoNum2.Text = valorHectare.ToString();
        }
    }
}