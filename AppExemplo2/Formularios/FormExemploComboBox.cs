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
    public partial class FormExemploComboBox : Form
    {
        public FormExemploComboBox()
        {
            InitializeComponent();
            txtPercDesconto.Visible = false; // <-- A caixa de texto "Perc(%) Desconto" ficará invisível
            lblPercDesconto.Visible = false; // <-- O label "Perc(%) Desconto" ficará invisível
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;
            double valorCompra = Convert.ToDouble(txtValorCompra.Text);
            double valorDesconto = 0;

            switch (tipoCliente)
            {
                case 0: // Cliente Diamante (25% de Desconto)
                    {
                        valorDesconto = valorCompra - valorCompra * 0.25;
                        lblResultado.Text = valorDesconto.ToString("C2");
                        break;
                    }

                case 1: // Cliente Ouro (20% de Desconto)
                    {
                        valorDesconto = valorCompra - valorCompra * 0.20;
                        lblResultado.Text = valorDesconto.ToString("C2");
                        break;
                    }

                case 2: // Cliente VIP (15% de Desconto)
                    {
                        valorDesconto = valorCompra - valorCompra * 0.15;
                        lblResultado.Text = valorDesconto.ToString("C2");
                        break;
                    }

                case 3: // Cliente Comum (10% de Desconto)
                    {
                        valorDesconto = valorCompra - valorCompra * 0.10;
                        lblResultado.Text = valorDesconto.ToString("C2");
                        break;
                    }

                case 4: // Cliente Aleatório (5% de Desconto)
                    {
                        valorDesconto = valorCompra - valorCompra * 0.05;
                        lblResultado.Text = valorDesconto.ToString("C2");
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Selecione um cliente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbTipoCliente.SelectedIndex = -1;
            txtPercDesconto.Clear();
            lblResultado.Text = "R$ 0,00";
            txtValorCompra.Clear();
            txtPercDesconto.Visible = false; // <-- A caixa de texto "Perc(%) Desconto" ficará invisível
            lblPercDesconto.Visible = false; // <-- O label "Perc(%) Desconto" ficará invisível
        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;

            if (tipoCliente == 4)
            {
                txtPercDesconto.Visible = true; // <-- A caixa de texto "Perc(%) Desconto" ficará visível
                lblPercDesconto.Visible = true; // <-- O label "Perc(%) Desconto" ficará visível
            }
            else
            {
                txtPercDesconto.Visible = false; // <-- A caixa de texto "Perc(%) Desconto" ficará invisível
                lblPercDesconto.Visible = false; // <-- O label "Perc(%) Desconto" ficará invisível
            }
        }

        private void linkJuletopi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/juletopi";
            Process.Start(url);
        }

        private void txtValorCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // <-- Vai para o campo seguinte
            {
                if (txtValorCompra.Text == " ") // <-- Verifica se o campo está vazio
                {
                    MessageBox.Show("O campo está vazio!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValorCompra.Select(); // <-- Volta ao campo
                }
                else
                {
                    txtPercDesconto.Select();
                }
            }
        }

        private void txtValorCompra_KeyUp(object sender, KeyEventArgs e)
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

                int qtdVirgula = txtValorCompra.Text.Count(v => v == ','); // <-- Contar as virgulas

                if (qtdVirgula > 1) verificarNumero = false; // <-- Verificar as virgulas
            }

            // Validação Final: A mensagem vai aparecer se um dos dois itens não foi atendido

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCompra.Text = txtValorCompra.Text.Remove(txtValorCompra.Text.Length - 1);
            }
        }
    }
}