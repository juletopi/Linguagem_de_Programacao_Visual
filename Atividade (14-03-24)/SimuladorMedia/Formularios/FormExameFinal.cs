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
    public partial class FormExameFinal : Form
    {
        public FormExameFinal()
        {
            InitializeComponent();
        }

        private void btVerificarMedia_Click(object sender, EventArgs e)
        {
            double MediaFinal = 0.00;
            double NotaAposExame = 0.00;
            string nome;

            try
            {
                MediaFinal = double.Parse(txtMediaFinal.Text);
                NotaAposExame = double.Parse(txtExameFinal.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira apenas números válidos nas notas.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nome = txtNomeAluno.Text;

            NotaAposExame = (6 * MediaFinal + 4 * NotaAposExame) / 10;

            if (NotaAposExame >= 50)
            {
                lblAprovadoReprovado.Text = $"Parabéns {nome}! \nVocê foi aprovado(a)!";
            }
            else
            {
                lblAprovadoReprovado.Text = $"Aluno(a) {nome}, você \nnão foi aprovado(a).";
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
            txtMediaFinal.Clear();
            txtExameFinal.Clear();
            lblAprovadoReprovado.Text = "";

            txtNomeAluno.Select();
        }
    }
}