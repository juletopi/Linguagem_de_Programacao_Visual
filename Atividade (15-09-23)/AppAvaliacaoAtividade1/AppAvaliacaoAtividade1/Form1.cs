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

namespace AppAvaliacaoAtividade1
{
    public partial class AtividadeAvaliativa1 : Form
    {
        public AtividadeAvaliativa1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCargo.Text) || string.IsNullOrEmpty(txtMetaVendas.Text) || string.IsNullOrEmpty(txtVendas.Text) || string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("O campo está vazio. Por favor preencha os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetaVendas.Select(); // <-- Volta ao campo
            }

            // Declarando as variáveis
            int tipoCargo = cmbCargo.SelectedIndex;
            double meta = Convert.ToDouble(txtMetaVendas.Text);
            double vendas = Convert.ToDouble(txtVendas.Text);
            double salario = Convert.ToDouble(txtSalario.Text);
            string cargo = cmbCargo.Text;
            double comissao = 0;

            // Usando um switch-case com base no índice do combo-box para calcular a comissão
            switch (tipoCargo)
            {
                case 0: // Gerente: (10% de vendas) + (2% de bonificação) +  (2% das vendas da concessionária) + (salário)
                    {
                        comissao = (0.10 * vendas) + (0.02 * salario) + (0.02 * vendas) + salario;
                        break;
                    }

                case 1: // Supervisor de Vendas: (10% de vendas) + (2% de bonificação) +  (1% das vendas da concessionária) + (salário)
                    {
                        comissao = (0.10 * vendas) + (0.02 * salario) + (0.01 * vendas) + salario;
                        break;
                    }

                case 2: // Vendedor Master: (8% de vendas) + (2% de bonificação) + (salário)
                    {
                        comissao = (0.08 * vendas) + (0.02 * salario) + salario;
                        break;
                    }

                case 3: // Vendedor Padrão: (6% de vendas) + (2% de bonificação) + (salário)
                    {
                        comissao = (0.06 * vendas) + (0.02 * salario) + salario;
                        break;
                    }

                case 4: // Vendedor Junior: (4% de vendas) + (2% de bonificação) + (salário)
                    {
                        comissao = (0.04 * vendas) + (0.02 * salario) + salario;
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Selecione um cargo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }

            // Verificando se a comissão atingiu 65% da meta
            double percentualAtingido = (vendas / meta) * 100;

            if (percentualAtingido >= 65)
            {
                lblResultado.Text = "Comissão: R$" + comissao.ToString("F2") + "\nPercentual Atingido: " + percentualAtingido.ToString("F2") + "%\n\nSalário Final: R$" + (comissao + salario).ToString("F2");
                lblResultado.ForeColor = System.Drawing.Color.Black;
                lblResultado.Visible = true;
                lblResultadoDeco.Visible = false;
            }
            else
            {
                lblResultado.Text = "Não atingiu os 65% da meta.\nComissão: R$0.00\n\nSalário Final: R$" + salario.ToString("F2");
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Visible = true;
                lblResultadoDeco.Visible = false;
            }
        }

        private void txtMetaVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // <-- Vai para o campo seguinte
            {
                if (txtMetaVendas.Text == " ") // <-- Verifica se o campo está vazio
                {
                    MessageBox.Show("O campo está vazio. Por favor preencha os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMetaVendas.Select(); // <-- Volta ao campo
                }
                else
                {
                    txtMetaVendas.Select();
                }
            }
        }

        private void txtMetaVendas_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;

            // Verificando o que foi digitado, "Número" ou "Letra"?

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true; // <-- Liberar a virgula

                if (e.KeyCode == Keys.Enter) verificarNumero = true; // <-- Liberar a tecla "enter"

                if (e.KeyCode == Keys.Back) verificarNumero = true; // <-- Liberar a tecla "backspace"

                int qtdVirgula = txtMetaVendas.Text.Count(v => v == ','); // <-- Contar as virgulas

                if (qtdVirgula > 1) verificarNumero = false; // <-- Verificar as virgulas
            }

            // Validação Final: A mensagem vai aparecer se um dos dois itens não foi atendido

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetaVendas.Text = txtMetaVendas.Text.Remove(txtMetaVendas.Text.Length - 1);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cmbCargo.SelectedIndex = -1;
            txtMetaVendas.Clear();
            txtVendas.Clear();
            txtSalario.Clear();
            lblResultado.Visible = false;
            lblResultadoDeco.Visible = true;
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}