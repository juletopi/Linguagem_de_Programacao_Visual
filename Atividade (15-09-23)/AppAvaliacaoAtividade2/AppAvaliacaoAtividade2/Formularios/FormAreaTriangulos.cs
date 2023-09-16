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
    public partial class FormAreaTriangulos : Form
    {
        public FormAreaTriangulos()
        {
            InitializeComponent();
            lblResultado.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCatetoA.Text) || string.IsNullOrWhiteSpace(txtCatetoB.Text) || string.IsNullOrWhiteSpace(txtHipotenusa.Text))
            {
                MessageBox.Show("Preencha todos os campos para calcular a área do triângulo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double ladoA, ladoB, ladoC;

            if (!double.TryParse(txtCatetoA.Text, out ladoA) || !double.TryParse(txtCatetoB.Text, out ladoB) || !double.TryParse(txtHipotenusa.Text, out ladoC))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para os lados do triângulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificando se os valores formam um triângulo
            if (IsTriangulo(ladoA, ladoB, ladoC))
            {
                double semiperimetro = (ladoA + ladoB + ladoC) / 2;
                double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

                lblResultado.Text = "Área do triângulo: " + area.ToString("F2") + " m²";
                lblResultado.Visible = true;
                lblClassificacao.Visible = true;
                lblResultadoDeco.Visible = false;

                // Classificação do triângulo
                string classificacao = ClassificarTriangulo(ladoA, ladoB, ladoC);
                lblClassificacao.Text = "Classificação: " + classificacao;
                lblResultado.Visible = true;
                lblClassificacao.Visible = true;
                lblResultadoDeco.Visible = false;
            }
            else
            {
                lblResultado.Text = "Os valores informados não formam um triângulo.";
                lblClassificacao.Text = "";
            }
        }

        private bool IsTriangulo(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private string ClassificarTriangulo(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Equilátero";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isósceles";
            }
            else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            {
                return "Triângulo Retângulo";
            }
            else
            {
                return "Escaleno";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
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