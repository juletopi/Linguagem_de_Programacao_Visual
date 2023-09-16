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
    public partial class FormTrianguloIsosceles : Form
    {
        public FormTrianguloIsosceles()
        {
            InitializeComponent();
            lblResultado.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbOpcCalculo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtLadoA.Text) || string.IsNullOrWhiteSpace(txtLadoB.Text) || string.IsNullOrWhiteSpace(txtBase.Text))
            {
                MessageBox.Show("Preencha todos os campos e selecione uma opção de cálculo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoCalculo = cmbOpcCalculo.SelectedItem.ToString();

            switch (tipoCalculo)
            {
                case "1. Calcular a área do triângulo isósceles":
                    double ladoA, ladoB, baseTriangulo, area;
                    if (double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB))
                    {
                        baseTriangulo = double.Parse(txtBase.Text);
                        area = (baseTriangulo * Math.Sqrt(Math.Pow(ladoA, 2) - Math.Pow(baseTriangulo, 2) / 4)) / 2;
                        lblResultado.Text = "Área do triângulo isósceles:\n\n" + area.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para os lados e a base.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "2. Calcular a altura do triângulo isósceles":
                    double altura;
                    if (double.TryParse(lblResultado.Text, out area) && double.TryParse(txtBase.Text, out baseTriangulo))
                    {
                        altura = (2 * area) / baseTriangulo;
                        lblResultado.Text = "Altura do triângulo isósceles:\n\n" + altura.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para a área e a base.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "3. Encontrar a aresta (lado) do triângulo isósceles":
                    double aresta;
                    if (double.TryParse(lblResultado.Text, out area) && double.TryParse(txtBase.Text, out baseTriangulo))
                    {
                        aresta = Math.Sqrt(Math.Pow(baseTriangulo, 2) + (4 * Math.Pow(area, 2))) / (2 * area);
                        lblResultado.Text = "Aresta (lado) do triângulo isósceles:\n\n" + aresta.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para a área e a base.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "4. Encontrar a base do triângulo isósceles":
                    double novaBase;
                    if (double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB))
                    {
                        area = double.Parse(lblResultado.Text);
                        novaBase = (2 * area) / Math.Sqrt(Math.Pow(ladoA, 2) - Math.Pow(ladoB, 2));
                        lblResultado.Text = "Nova base do triângulo isósceles:\n\n" + novaBase.ToString("F2");
                        lblResultado.Visible = true;
                        lblResultadoDeco.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para os lados e a área.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Selecione uma opção válida de cálculo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cmbOpcCalculo.SelectedIndex = -1;
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtBase.Clear();
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
                if (txtLadoA.Text == " ") // <-- Verifica se o campo está vazio
                {
                    MessageBox.Show("O campo está vazio. Por favor preencha os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLadoA.Select(); // <-- Volta ao campo
                }
                else
                {
                    txtLadoA.Select();
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

                int qtdVirgula = txtLadoA.Text.Count(v => v == ','); // <-- Contar as vírgulas

                if (qtdVirgula > 1) verificarNumero = false; // <-- Verificar as vírgulas
            }

            // Validação Final: A mensagem vai aparecer se um dos dois itens não foi atendido

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLadoA.Text = txtLadoA.Text.Remove(txtLadoA.Text.Length - 1);
            }
        }
    }
}