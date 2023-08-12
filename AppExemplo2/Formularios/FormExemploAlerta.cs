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

namespace AppExemplo2.Formularios
{
    public partial class FormExemploAlerta : Form
    {
        public FormExemploAlerta()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2, total;
            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            if (valor2 != 0)
            {
                total = valor1 / valor2;
                lblResultadoDivisao.Text = total.ToString("F2");
            }
            else
            {
                MessageBox.Show("Não é possível dividir por zero!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor1.Clear();
                txtValor2.Clear();
                txtValor1.Select();
                lblResultadoDivisao.Text = "0";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor1.Select();
            lblResultadoDivisao.Text = "0";
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}