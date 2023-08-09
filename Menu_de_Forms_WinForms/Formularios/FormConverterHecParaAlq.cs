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
    public partial class FormConverterHecteAlqu : Form
    {
        public FormConverterHecteAlqu()
        {
            InitializeComponent();
        }

        private void btnConverterHectare_Click(object sender, EventArgs e)
        {
            double valorHectare = 0, valorAlqueire = 0;

            valorHectare = Convert.ToDouble(txtValorHectare.Text);
            valorAlqueire = Convert.ToDouble(lblResultadoHectareParaAlqueire.Text);

            valorAlqueire = valorHectare * 2.42;

            lblResultadoHectareParaAlqueire.Text = valorAlqueire.ToString();
        }

        private void btnConverterAlquere_Click(object sender, EventArgs e)
        {
            double valorHectare = 0, valorAlqueire = 0;

            valorAlqueire = Convert.ToDouble(txtValorAlqueire.Text);
            valorHectare = Convert.ToDouble(lblResultadoAlqueireParaHectare.Text);

            valorHectare = valorAlqueire / 2.42;

            lblResultadoAlqueireParaHectare.Text = valorHectare.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorHectare.Clear();
            txtValorAlqueire.Clear();
            txtValorHectare.Select();
            lblResultadoHectareParaAlqueire.Text = "0";
            lblResultadoAlqueireParaHectare.Text = "0";
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}