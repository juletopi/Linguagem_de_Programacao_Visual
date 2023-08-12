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
    public partial class FormExemploRotulos : Form
    {
        public FormExemploRotulos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtPercentual.Clear();
            txtSalarioAtual.Clear();
            txtSalarioAtual.Select();
            lblResultado.Text = "Salário Reajustado";
            lblResultado.ForeColor = Color.Black;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioAtual = 0, percentual = 0, salarioReajustado;

            salarioAtual = Convert.ToDouble(txtSalarioAtual.Text);
            percentual = Convert.ToDouble(txtPercentual.Text);
            percentual = percentual / 100;

            salarioReajustado = salarioAtual + salarioAtual * percentual;

            lblResultado.Text = "O salário atualizado é: " + salarioReajustado.ToString("C2"); // <-- "C2" adiciona a moeda corrente: "R$ 0,00" ao resultado numérico
            lblResultado.ForeColor = Color.Blue;
        }

        private void txtSalarioAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) // <-- Vai para o campo seguinte
            {
                if(txtSalarioAtual.Text == " ") // <-- Verifica se o campo está vazio
                {
                    MessageBox.Show("O campo está vazio!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSalarioAtual.Select(); // <-- Volta ao campo
                }
                else
                {
                    txtPercentual.Select();
                }
            }
        }

        private void txtSalarioAtual_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;

            // Verificando o que foi digitado, "Número" ou "Letra"?

            if((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true; // <-- Liberar a virgula

                if (e.KeyCode == Keys.Enter) verificarNumero = true; // <-- Liberar a tecla "enter"

                if (e.KeyCode == Keys.Back) verificarNumero = true; // <-- Liberar a tecla "backspace"

                int qtdVirgula = txtSalarioAtual.Text.Count(v => v == ','); // <-- Contar as virgulas

                if (qtdVirgula > 1) verificarNumero = false; // <-- Verificar as virgulas
            }

            // Validação Final: A mensagem vai aparecer se um dos dois itens não foi atendido

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioAtual.Text = txtSalarioAtual.Text.Remove(txtSalarioAtual.Text.Length- 1);
            }
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }
    }
}