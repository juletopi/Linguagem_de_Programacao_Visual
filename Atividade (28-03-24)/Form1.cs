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

namespace Atividade__28_03_24_
{
    public partial class FormSimulacaoComissao : Form
    {
        public FormSimulacaoComissao()
        {
            InitializeComponent();
        }

        private void btSimular_Click(object sender, EventArgs e)
        {
            // Verificando se um cargo foi selecionado
            if (cbSelecaoCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um cargo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificando se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(txtSalario.Text) || string.IsNullOrEmpty(txtMeta.Text) || string.IsNullOrEmpty(txtVendas.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double salario, meta, vendas;

            // Verificando se os campos de entrada tem valores válidos
            if (!double.TryParse(txtSalario.Text, out salario) || !double.TryParse(txtVendas.Text, out vendas) || !double.TryParse(txtMeta.Text, out meta))
            {
                MessageBox.Show("Valor inválido em um dos campos! Digite um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculando a comissão de acordo com o cargo
            string cargo = cbSelecaoCargo.SelectedItem.ToString();
            double comissao = 0, bonus = 0;

            switch (cargo)
            {
                case "Vendedor Junior":
                    comissao = vendas * 0.04;
                    bonus = salario * 0.02;
                    break;
                case "Vendedor Padrão":
                    comissao = vendas * 0.06;
                    bonus = salario * 0.02;
                    break;
                case "Vendedor Master":
                    comissao = vendas * 0.08;
                    bonus = salario * 0.02;
                    break;
                case "Supervisor de Vendas":
                    comissao = vendas * 0.10;
                    bonus = salario * 0.02 + vendas * 0.01;
                    break;
                case "Gerente":
                    comissao = vendas * 0.10;
                    bonus = salario * 0.02 + vendas * 0.02;
                    break;
            }

            // Verificando se a meta foi atingida
            if (vendas >= meta * 0.65)
            {
                // Verificando se a meta da concessionária foi atingida
                if (vendas >= meta * 0.85 || cargo == "Supervisor de Vendas" || cargo == "Gerente")
                {
                    double comissaoTotal = comissao + bonus;
                    double salarioFinal = salario + comissaoTotal;

                    lblResultadosComissao.Visible = true;
                    lblResultadosComissao.Text =
                    $"Comissão: {comissao.ToString("C2")}\n" +
                    $"Bônus: {bonus.ToString("C2")}\n" +
                    $"Comissão Total: {comissaoTotal.ToString("C2")}\n" +
                    $"Salário Final: {salarioFinal.ToString("C2")}";
                }
                else
                {
                    MessageBox.Show("A concessionária não atingiu a meta de vendas para pagar a comissão sobre as vendas da concessionária.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("O vendedor não atingiu 65% da sua meta de vendas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            // Limpando e resetando o ComboBox
            cbSelecaoCargo.SelectedIndex = -1;
            cbSelecaoCargo.ResetText();

            // Limpando os outros campos
            txtSalario.Clear();
            txtVendas.Clear();
            txtMeta.Clear();

            // Restaurando a cor de fundo padrão dos campos de entrada
            txtSalario.BackColor = SystemColors.Window;
            txtVendas.BackColor = SystemColors.Window;
            txtMeta.BackColor = SystemColors.Window;

            // Limpando e restaurando os labels
            lblResultadosComissao.Visible = false;
            lblSubtitulo.Visible = false;
            lblSubtitulo.AutoSize = false;
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitulo.Text = "{Texto de cargo selecionado}";
        }

        private void lblLinkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }

        private void cbSelecaoCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mudando a cor de fundo dos campos de acordo com o cargo
            switch (cbSelecaoCargo.SelectedIndex)
            {
                case 0: // Vendedor Junior
                    txtSalario.BackColor = Color.LightGray;
                    txtMeta.BackColor = Color.LightGray;
                    txtVendas.BackColor = Color.LightGray;
                    txtSalario.Clear();
                    txtVendas.Clear();
                    txtMeta.Clear();
                    lblResultadosComissao.Visible = false;
                    lblSubtitulo.Visible = true;
                    lblSubtitulo.AutoSize = false;
                    lblSubtitulo.Text = "Cargo: Vendedor Junior";
                    break;
                case 1: // Vendedor Padrão
                    txtSalario.BackColor = Color.LightGreen;
                    txtMeta.BackColor = Color.LightGreen;
                    txtVendas.BackColor = Color.LightGreen;
                    txtSalario.Clear();
                    txtVendas.Clear();
                    txtMeta.Clear();
                    lblResultadosComissao.Visible = false;
                    lblSubtitulo.Visible = true;
                    lblSubtitulo.AutoSize = false;
                    lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
                    lblSubtitulo.Text = "Cargo: Vendedor Padrão";
                    break;
                case 2: // Vendedor Master
                    txtSalario.BackColor = Color.LightBlue;
                    txtMeta.BackColor = Color.LightBlue;
                    txtVendas.BackColor = Color.LightBlue;
                    txtSalario.Clear();
                    txtVendas.Clear();
                    txtMeta.Clear();
                    lblResultadosComissao.Visible = false;
                    lblSubtitulo.Visible = true;
                    lblSubtitulo.AutoSize = false;
                    lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
                    lblSubtitulo.Text = "Cargo: Vendedor Master";
                    break;
                case 3: // Supervisor de Vendas
                    txtSalario.BackColor = Color.LightPink;
                    txtMeta.BackColor = Color.LightPink;
                    txtVendas.BackColor = Color.LightPink;
                    txtSalario.Clear();
                    txtVendas.Clear();
                    txtMeta.Clear();
                    lblResultadosComissao.Visible = false;
                    lblSubtitulo.Visible = true;
                    lblSubtitulo.AutoSize = false;
                    lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
                    lblSubtitulo.Text = "Cargo: Surpevisor de Vendas";
                    break;
                case 4: // Gerente
                    txtSalario.BackColor = Color.LightSalmon;
                    txtMeta.BackColor = Color.LightSalmon;
                    txtVendas.BackColor = Color.LightSalmon;
                    txtSalario.Clear();
                    txtVendas.Clear();
                    txtMeta.Clear();
                    lblResultadosComissao.Visible = false;
                    lblSubtitulo.Visible = true;
                    lblSubtitulo.AutoSize = false;
                    lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
                    lblSubtitulo.Text = "Cargo: Gerente";
                    break;
                default:
            break;
            }
        }
    }
}