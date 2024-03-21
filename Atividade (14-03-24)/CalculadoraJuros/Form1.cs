using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJuros
{
    public partial class CalculadoraJuros : Form
    {
        public CalculadoraJuros()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            // Verificando se o combo-box foi inicializado e se há um item selecionado
            if (cbTipoCalculo != null && cbTipoCalculo.SelectedItem != null)
            {
                double montante = 0, capital = 0, taxa = 0, tempo = 0;

                // Verificando se os campos de entrada têm valores válidos
                if (!string.IsNullOrEmpty(txtMontante.Text))
                {
                    if (!double.TryParse(txtMontante.Text, out montante))
                    {
                        MessageBox.Show("Valor inválido em um dos campos! Digite um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(txtCapital.Text))
                {
                    if (!double.TryParse(txtCapital.Text, out capital))
                    {
                        MessageBox.Show("Valor inválido em um dos campos! Digite um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(txtTaxa.Text))
                {
                    if (!double.TryParse(txtTaxa.Text, out taxa))
                    {
                        MessageBox.Show("Valor inválido em um dos campos! Digite um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(txtTempo.Text))
                {
                    if (!double.TryParse(txtTempo.Text, out tempo))
                    {
                        MessageBox.Show("Valor inválido em um dos campos! Digite um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Realizando o cálculo com base no tipo selecionado a partir do combo-box
                switch (cbTipoCalculo.SelectedItem.ToString())
                {
                    case "Montante":
                        montante = capital * (1 + taxa * tempo);
                        if (txtMontante.Enabled)
                            txtMontante.Text = montante.ToString("F2");
                    break;

                    case "Capital":
                        capital = montante / (1 + taxa * tempo);
                        if (txtCapital.Enabled)
                            txtCapital.Text = capital.ToString("F2");
                    break;

                    case "Taxa":
                        taxa = (montante - capital) / (capital * tempo);
                        if (txtTaxa.Enabled)
                            txtTaxa.Text = (taxa * 100).ToString("F2");
                    break;

                    case "Tempo":
                        tempo = (montante - capital) / (capital * taxa);
                        if (txtTempo.Enabled)
                            txtTempo.Text = tempo.ToString("F2");
                    break;
                }

                // Calculando e exibindo os juros
                double juros = montante - capital;
                lblResultadoJuros.Text = $"{juros.ToString("F2")}%";
            }
            else
            {
                MessageBox.Show("Selecione um tipo de operação primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Limpando os campos e restaurando as configurações-padrão
        private void btLimpar_Click(object sender, EventArgs e)
        {
            // Limpando e resetando o ComboBox
            cbTipoCalculo.SelectedIndex = -1;
            cbTipoCalculo.ResetText();

            // Limpando os outros campos
            txtMontante.Clear();
            txtCapital.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();

            // Restaurando a cor de fundo padrão dos campos de entrada
            txtMontante.BackColor = SystemColors.Window;
            txtCapital.BackColor = SystemColors.Window;
            txtTaxa.BackColor = SystemColors.Window;
            txtTempo.BackColor = SystemColors.Window;

            // Habilitando a edição dos campos
            txtMontante.ReadOnly = false;
            txtMontante.TabStop = true;
            txtCapital.ReadOnly = false;
            txtCapital.TabStop = true;
            txtTaxa.ReadOnly = false;
            txtTaxa.TabStop = true;
            txtTempo.ReadOnly = false;
            txtTempo.TabStop = true;

            // Limpando o label de resultado dos juros
            lblResultadoJuros.Text = "";
        }

        // Mudando a cor de fundo do campo selecionado a partir do
        // combo-box e desabilitando a edição dos outros campos
        private void cbTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificando se um item foi selecionado no combo-box
            if (cbTipoCalculo.SelectedItem != null)
            {
                // Restaurando a cor de fundo padrão dos campos de entrada
                txtMontante.BackColor = SystemColors.Window;
                txtCapital.BackColor = SystemColors.Window;
                txtTaxa.BackColor = SystemColors.Window;
                txtTempo.BackColor = SystemColors.Window;

                // Identificando qual item foi selecionado no combo-box
                switch (cbTipoCalculo.SelectedItem.ToString())
                {
                    case "Montante":
                        // Destacando o campo Montante e limpando os demais campos
                        txtMontante.BackColor = Color.LightGreen;
                        txtMontante.Clear();
                        txtCapital.Clear();
                        txtTaxa.Clear();
                        txtTempo.Clear();

                        // Habilitando a edição apenas do campo Montante
                        txtMontante.ReadOnly = true;
                        txtMontante.TabStop = false;
                        txtCapital.ReadOnly = false;
                        txtCapital.TabStop = true;
                        txtTaxa.ReadOnly = false;
                        txtTaxa.TabStop = true;
                        txtTempo.ReadOnly = false;
                        txtTempo.TabStop = true;

                        // Limpando o label de resultado dos juros
                        lblResultadoJuros.Text = "";
                        break;

                    case "Capital":
                        // Destacando o campo Capital e limpando os demais campos
                        txtCapital.BackColor = Color.LightGreen;
                        txtMontante.Clear();
                        txtCapital.Clear();
                        txtTaxa.Clear();
                        txtTempo.Clear();

                        // Habilitando a edição apenas do campo Capital
                        txtMontante.ReadOnly = false;
                        txtMontante.TabStop = true;
                        txtCapital.ReadOnly = true;
                        txtCapital.TabStop = false;
                        txtTaxa.ReadOnly = false;
                        txtTaxa.TabStop = true;
                        txtTempo.ReadOnly = false;
                        txtTempo.TabStop = true;

                        // Limpando o label de resultado dos juros
                        lblResultadoJuros.Text = "";
                        break;

                    case "Taxa":
                        // Destacando o campo Taxa e limpando os demais campos
                        txtTaxa.BackColor = Color.LightGreen;
                        txtMontante.Clear();
                        txtCapital.Clear();
                        txtTaxa.Clear();
                        txtTempo.Clear();

                        // Habilitando a edição apenas do campo Taxa
                        txtMontante.ReadOnly = false;
                        txtMontante.TabStop = true;
                        txtCapital.ReadOnly = false;
                        txtCapital.TabStop = true;
                        txtTaxa.ReadOnly = true;
                        txtTaxa.TabStop = false;
                        txtTempo.ReadOnly = false;
                        txtTempo.TabStop = true;

                        // Limpando o label de resultado dos juros
                        lblResultadoJuros.Text = "";
                        break;

                    case "Tempo":
                        // Destacando o campo Tempo e limpando os demais campos
                        txtTempo.BackColor = Color.LightGreen;
                        txtMontante.Clear();
                        txtCapital.Clear();
                        txtTaxa.Clear();
                        txtTempo.Clear();

                        // Habilitando a edição apenas do campo Tempo
                        txtMontante.ReadOnly = false;
                        txtMontante.TabStop = true;
                        txtCapital.ReadOnly = false;
                        txtCapital.TabStop = true;
                        txtTaxa.ReadOnly = false;
                        txtTaxa.TabStop = true;
                        txtTempo.ReadOnly = true;
                        txtTempo.TabStop = false;

                        // Limpando o label de resultado dos juros
                        lblResultadoJuros.Text = "";
                        break;
                }
            }
        }
    }
}