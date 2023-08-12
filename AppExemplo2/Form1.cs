using System;
using System.Diagnostics;
using System.Windows.Forms;
using AppExemplo2.Formularios;

namespace AppExemplo2
{
    public partial class AppMenudeExemplos : Form
    {
        public AppMenudeExemplos()
        {
            InitializeComponent();
        }

        // Criando o Menu Principal

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            FormAlertas form = new FormAlertas();
            form.ShowDialog(); // <-- Não permite que o usuário faça qualquer outra ação até que termine
                                      // ou conclua o processo da janela atual do qual ele abriu.
        }

        private void btnExemploAlerta_Click(object sender, EventArgs e)
        {
            FormExemploAlerta form = new FormExemploAlerta(); // <-- Linkando a ação do click para abrir uma nova janela
            form.ShowDialog();
        }

        private void btnExemploAltdeRotulo_Click(object sender, EventArgs e)
        {
            FormExemploRotulos form = new FormExemploRotulos();
            form.ShowDialog();
        }

        private void btnExemploComboBox_Click(object sender, EventArgs e)
        {
            FormExemploComboBox form = new FormExemploComboBox();
            form.ShowDialog();
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}