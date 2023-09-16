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
    public partial class FormTrianguloRetangulo : Form
    {
        public FormTrianguloRetangulo()
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
                case "1. Calcular área do Triângulo Retângulo":
                    double catetoA, catetoB, area;
                    if (double.TryParse(txtCatetoA.Text, out catetoA) && double.TryParse(txtCatetoB.Text, out catetoB))
                    {
                        area = (catetoA * catetoB) / 2;
                        lblResultado.Text = "A Área do seu triângulo retângulo é:\n\n " + area.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para Cateto A e Cateto B.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "2. Descobrir o lado (a)":
                    double hipotenusa, ladoA;
                    if (double.TryParse(txtHipotenusa.Text, out hipotenusa) && double.TryParse(txtCatetoB.Text, out catetoB))
                    {
                        ladoA = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(catetoB, 2));
                        lblResultado.Text = "O Lado (a) do seu triângulo retângulo é:\n\n " + ladoA.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para Hipotenusa e Cateto B.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "3. Descobrir o lado (b)":
                    double ladoB;
                    if (double.TryParse(txtHipotenusa.Text, out hipotenusa) && double.TryParse(txtCatetoA.Text, out catetoA))
                    {
                        ladoB = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(catetoA, 2));
                        lblResultado.Text = "O Lado (b) do seu triângulo retângulo é:\n\n " + ladoB.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para Hipotenusa e Cateto A.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "4. Descobrir o lado (c)":
                    double ladoC;
                    if (double.TryParse(txtCatetoA.Text, out catetoA) && double.TryParse(txtCatetoB.Text, out catetoB))
                    {
                        ladoC = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
                        lblResultado.Text = "O Lado (c) do seu triângulo retângulo é:\n\n " + ladoC.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para Cateto A e Cateto B.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Selecione uma opção válida de cálculo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
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
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true; // <-- Liberar a vírgula

                if (e.KeyCode == Keys.Enter) verificarNumero = true; // <-- Liberar a tecla "enter"

                if (e.KeyCode == Keys.Back) verificarNumero = true; // <-- Liberar a tecla "backspace"

                int qtdVirgula = txtCatetoA.Text.Count(v => v == ','); // <-- Contar as vírgulas

                if (qtdVirgula > 1) verificarNumero = false; // <-- Verificar as vírgulas
            }

            // Validação Final: A mensagem vai aparecer se um dos dois itens não foi atendido

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatetoA.Text = txtCatetoA.Text.Remove(txtCatetoA.Text.Length - 1);
            }
        }
    }
}