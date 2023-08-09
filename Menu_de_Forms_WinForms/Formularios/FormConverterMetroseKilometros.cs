using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_de_Forms_WinForms.Formularios
{
    public partial class FormConverterMetroseKilometros : Form
    {
        public FormConverterMetroseKilometros()
        {
            InitializeComponent();
        }

        private void btnConverterMetrosParaKm_Click(object sender, EventArgs e)
        {
            double valorMetros = 0, valorQuilometros = 0;

            valorMetros = Convert.ToDouble(txtValorMetros.Text);
            valorQuilometros = Convert.ToDouble(lblResultadoMetrosParaKm.Text);

            valorQuilometros = valorMetros / 1000;

            lblResultadoMetrosParaKm.Text = valorQuilometros.ToString();
        }

        private void btnConverterKmParaMetros_Click(object sender, EventArgs e)
        {
            double valorMetros = 0, valorQuilometros = 0;

            valorQuilometros = Convert.ToDouble(txtValorKm.Text);
            valorMetros = Convert.ToDouble(lblResultadoKmParaMetros.Text);

            valorMetros = valorQuilometros * 1000;

            lblResultadoKmParaMetros.Text = valorMetros.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorMetros.Clear();
            txtValorKm.Clear();
            txtValorMetros.Select();
            lblResultadoMetrosParaKm.Text = "0";
            lblResultadoKmParaMetros.Text = "0";
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}
