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
using AppAvaliacaoAtividade2.Formularios;

namespace AppAvaliacaoAtividade2
{
    public partial class AtividadeAvaliativa2 : Form
    {
        public AtividadeAvaliativa2()
        {
            InitializeComponent();
        }

        // Criando o Menu Principal

        private void btnTrianguloEquilatero_Click(object sender, EventArgs e)
        {
            FormTrianguloEquilatero form = new FormTrianguloEquilatero();
            form.ShowDialog(); // <-- Não permite que o usuário faça qualquer outra ação até que termine
                               // ou conclua o processo da janela atual do qual ele abriu.
        }

        private void btnTrianguloRetangulo_Click(object sender, EventArgs e)
        {
            FormTrianguloRetangulo form = new FormTrianguloRetangulo();
            form.ShowDialog();
        }

        private void btnTrianguloIsosceles_Click(object sender, EventArgs e)
        {
            FormTrianguloIsosceles form = new FormTrianguloIsosceles();
            form.ShowDialog();
        }

        private void btnAreaTriangulos_Click(object sender, EventArgs e)
        {
            FormAreaTriangulos form = new FormAreaTriangulos();
            form.ShowDialog();
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}