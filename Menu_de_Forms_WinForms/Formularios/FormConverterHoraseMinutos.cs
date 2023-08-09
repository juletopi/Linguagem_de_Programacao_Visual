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
    public partial class FormConverterHoraseMinutos : Form
    {
        public FormConverterHoraseMinutos()
        {
            InitializeComponent();
        }

        private void btnConverterHorasParaMinutos_Click(object sender, EventArgs e)
        {
            double valorHoras = 0, valorMinutos = 0;

            valorHoras = Convert.ToDouble(txtValorHoras.Text);
            valorMinutos = Convert.ToDouble(lblResultadoHorasParaMinutos.Text);

            valorMinutos = valorHoras * 60;

            lblResultadoHorasParaMinutos.Text = valorMinutos.ToString();
        }

        private void btnConverteMinutosParaHoras_Click(object sender, EventArgs e)
        {
            double valorHoras = 0, valorMinutos = 0;

            valorMinutos = Convert.ToDouble(txtValorMinutos.Text);
            valorHoras = Convert.ToDouble(lblResultadoMinutosParaHoras.Text);

            valorHoras = valorMinutos / 60;

            lblResultadoMinutosParaHoras.Text = valorHoras.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorHoras.Clear();
            txtValorMinutos.Clear();
            txtValorHoras.Select();
            lblResultadoHorasParaMinutos.Text = "0";
            lblResultadoMinutosParaHoras.Text = "0";
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}