using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu_de_Forms_WinForms.Formularios;

namespace Menu_de_Forms_WinForms
{
    public partial class FormAppMenudeConversores : Form
    {
        public FormAppMenudeConversores()
        {
            InitializeComponent();
        }

        private void btnConversorHecteAlqu_Click(object sender, EventArgs e)
        {
            FormConverterHecteAlqu form = new FormConverterHecteAlqu();
            form.ShowDialog();
        }

        private void btnConversorMetroseKilometros_Click(object sender, EventArgs e)
        {
            FormConverterMetroseKilometros form = new FormConverterMetroseKilometros();
            form.ShowDialog();
        }

        private void btnConversorHoraseMinutos_Click(object sender, EventArgs e)
        {
            FormConverterHoraseMinutos form = new FormConverterHoraseMinutos();
            form.ShowDialog();
        }

        private void btnConversorHecteKmQuadrado_Click(object sender, EventArgs e)
        {
            FormConverterHecteKmQuadrado form = new FormConverterHecteKmQuadrado();
            form.ShowDialog();
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }

        private void btnConversorHecteAlqu_MouseEnter(object sender, EventArgs e)
        {
            lblSeta1.Visible = true;
        }

        private void btnConversorHecteAlqu_MouseLeave(object sender, EventArgs e)
        {
            lblSeta1.Visible = false;
        }

        private void btnConversorMetroseKilometros_MouseEnter(object sender, EventArgs e)
        {
            lblSeta2.Visible = true;
        }

        private void btnConversorMetroseKilometros_MouseLeave(object sender, EventArgs e)
        {
            lblSeta2.Visible = false;
        }

        private void btnConversorHoraseMinutos_MouseEnter(object sender, EventArgs e)
        {
            lblSeta3.Visible = true;
        }

        private void btnConversorHoraseMinutos_MouseLeave(object sender, EventArgs e)
        {
            lblSeta3.Visible = false;
        }

        private void btnConversorHecteKmQuadrado_MouseEnter(object sender, EventArgs e)
        {
            lblSeta4.Visible = true;
        }

        private void btnConversorHecteKmQuadrado_MouseLeave(object sender, EventArgs e)
        {
            lblSeta4.Visible = false;
        }
    }
}