using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMedia.Formularios
{
    public partial class FormSimularMedia : Form
    {
        public FormSimularMedia()
        {
            InitializeComponent();
        }

        private void btVerificarMedia_Click(object sender, EventArgs e)
        {
            double nota1 = 0, nota2 = 0;
            double resultado;
            string nome;

            try
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
                nota2 = Convert.ToDouble(txtNota2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira apenas números válidos nas notas.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nome = txtNomeAluno.Text;

            resultado = (nota1 + nota2) / 2;

            lblResultadoNota.Text = resultado.ToString();

            if (resultado >= 60)
            {
                lblResultadoNota.Text = $"A sua nota foi de {resultado} pontos.";
                lblAprovadoReprovado.Text = $"{nome}, você foi aprovado(a)!";
            }
            else
            {
                lblResultadoNota.Text = $"A sua nota foi de {resultado} pontos.";
                lblAprovadoReprovado.Text = $"{nome}, você foi reprovado(a)!";
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            lblResultadoNota.Text = "";
            lblAprovadoReprovado.Text = "";

            txtNomeAluno.Select();
        }
    }
}