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
    public partial class FormConverterHecteKmQuadrado : Form
    {
        public FormConverterHecteKmQuadrado()
        {
            InitializeComponent();
        }

        private void btnConverterHectParaKmQuadrado_Click(object sender, EventArgs e)
        {
            double valorHectare = 0, valorKmQuadrado = 0;

            valorHectare = Convert.ToDouble(txtValorHectare.Text);
            valorKmQuadrado = Convert.ToDouble(lblResultadoHectParaKmQuadrado.Text);

            valorKmQuadrado = valorHectare * 0.0042;

            lblResultadoHectParaKmQuadrado.Text = valorKmQuadrado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorHectare.Clear();
            txtValorHectare.Select();
            lblResultadoHectParaKmQuadrado.Text = "0";
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}