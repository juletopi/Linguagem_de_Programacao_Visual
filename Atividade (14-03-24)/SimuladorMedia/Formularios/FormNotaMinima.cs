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
    public partial class FormNotaMinima : Form
    {
        public FormNotaMinima()
        {
            InitializeComponent();
        }

        private void btVerificarNotaMinima_Click(object sender, EventArgs e)
        {
            double mediaFinal = 0;
            double notaNecessaria = 0;
            string nome;

            mediaFinal = Convert.ToDouble(txtMediaFinal.Text);
            nome = txtNomeAluno.Text;

            notaNecessaria = (500 - 6 * mediaFinal) / 4;

            if (notaNecessaria <= 0)
            {
                lblNotaParaPassar.Text = $"Aluno(a) {nome}, você está \naprovado(a), não é necessário \nmais nota.";
            }
            else
            {
                lblNotaParaPassar.Text = $"Aluno(a) {nome}, \nvocê precisa de {notaNecessaria} pontos \npara passar.";
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
            txtMediaFinal.Clear();
            lblNotaParaPassar.Text = "";

            txtNomeAluno.Select();
        }
    }
}