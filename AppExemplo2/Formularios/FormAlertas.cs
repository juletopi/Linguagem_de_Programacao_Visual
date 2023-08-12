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
    public partial class FormAlertas : Form
    {
        public FormAlertas()
        {
            InitializeComponent();
        }

        // Como criar Mensagens de Interação com o Usuário

        private void btnInformacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Menssagem", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information); // <-- Menssagem de INFORMAÇÂO
        }

        private void btnAtencao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Menssagem", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning); // <-- Mensagem de ALERTA
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Menssagem", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error); // <-- Mensagem de ERRO
        }

        private void btnPergunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Menssagem", "Título da Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // <-- Mensagem de PERGUNTA
        }

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Em caminho de Paca, Tatu caminha dentro?", "Pergunta:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            MessageBox.Show("Resposta" +resposta.ToString(), "Pergunta:", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Deseja fechar o programa?", "Pergunta:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes) 
            {
                this.Close(); // <-- Fecha o programa
            }
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}