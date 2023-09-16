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

namespace AppAvaliacaoAtividade2.Formularios
{
    public partial class FormTrianguloEquilatero : Form
    {
        public FormTrianguloEquilatero()
        {
            InitializeComponent();
            lblResultado.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbOpcCalculo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCatetoA.Text) || string.IsNullOrWhiteSpace(txtCatetoB.Text) || string.IsNullOrWhiteSpace(txtHipotenusa.Text))
            {
                MessageBox.Show("Preencha todos os campos e selecione uma opção de cálculo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoCalculo = cmbOpcCalculo.SelectedItem.ToString();

            switch (tipoCalculo)
            {
                case "1. Calcular a área do triângulo equilátero":
                    double catetoA, catetoB, area;
                    if (double.TryParse(txtCatetoA.Text, out catetoA) && double.TryParse(txtCatetoB.Text, out catetoB))
                    {
                        area = (catetoA * catetoB) / 2;
                        lblResultado.Text = "A Área do seu triângulo equilátero é:\n\n " + area.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para Cateto A e Cateto B.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "2. Calcular a altura do triângulo equilátero":
                    double altura;
                    if (double.TryParse(lblResultado.Text, out area) && double.TryParse(txtCatetoB.Text, out catetoB))
                    {
                        altura = (2 * area) / catetoB;
                        lblResultado.Text = "A Altura do seu triângulo equilátero é:\n\n " + altura.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para Área e Cateto B.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "3. Encontrar o lado do triângulo":
                    double lado;
                    if (double.TryParse(lblResultado.Text, out area) && double.TryParse(txtHipotenusa.Text, out altura))
                    {
                        lado = (2 * area) / altura;
                        lblResultado.Text = "O Lado do seu triângulo equilátero é:\n\n " + lado.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para Área e Hipotenusa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Selecione uma opção válida de cálculo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void txtCatetoA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // <-- Vai para o campo seguinte
            {
                if (txtCatetoA.Text == " ") // <-- Verifica se o campo está vazio
                {
                    MessageBox.Show("O campo está vazio. Por favor preencha os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCatetoA.Select(); // <-- Volta ao campo
                }
                else
                {
                    txtCatetoA.Select();
                }
            }
        }

        private void txtCatetoA_KeyUp(object sender, KeyEventArgs e)
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

                int qtdVirgula = txtCatetoA.Text.Count(v => v == ','); // <-- Contar as virgulas

                if (qtdVirgula > 1) verificarNumero = false; // <-- Verificar as virgulas
            }

            // Validação Final: A mensagem vai aparecer se um dos dois itens não foi atendido

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatetoA.Text = txtCatetoA.Text.Remove(txtCatetoA.Text.Length - 1);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cmbOpcCalculo.SelectedIndex = -1;
            txtCatetoA.Clear();
            txtCatetoB.Clear();
            txtHipotenusa.Clear();
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