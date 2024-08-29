using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLoterias.Formularios
{
    public partial class FormLotoMania : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        public FormLotoMania()
        {
            InitializeComponent();
        }

        /*
          LotoMania

          Números envolvidos: 50 números sorteados entre 0 e 99.
          Classificação de chances de ganhar:
            - 25 pares e 25 ímpares: "MUITO ALTO!"
            - 24 pares e 26 ímpares: "ALTO!"
            - 26 pares e 24 ímpares: "ALTO!"
            - 23 pares e 27 ímpares: "MÉDIO!"
            - 27 pares e 23 ímpares: "MÉDIO!"
            - Outras combinações: "BAIXO!"
        */

        public void Classificacao(int par, int impar)
        {
            lblPar.Text = "Pares: " + par;
            lblImpar.Text = "Ímpares: " + impar;

            // Estatísticas
            if (par == 25 && impar == 25)
            {
                lblClass.Text = "MUITO ALTO!";
                lblClass.ForeColor = Color.Green;
            }
            else if ((par == 26 && impar == 24) || (par == 24 && impar == 26))
            {
                lblClass.Text = "ALTO!";
                lblClass.ForeColor = Color.Green;
            }
            else if ((par == 23 && impar == 27) || (par == 27 && impar == 23))
            {
                lblClass.Text = "MÉDIO!";
                lblClass.ForeColor = Color.Orange;
            }
            else
            {
                lblClass.Text = "BAIXO!";
                lblClass.ForeColor = Color.Red;
            }
        }

        public void GerarNumeros()
        {
            int numero = 0;
            int contador = 0;
            int qtdPar = 0;
            int qtdImpar = 0;
            Random radNum = new Random();
            NumerosDaSorte.Clear();

            while (contador < 50) // Lotomania são 50 números
            {
                numero = radNum.Next(0, 100); // Lotomania tem números de 0 a 99
                if (NumerosDaSorte.Contains(numero) == false)
                {
                    NumerosDaSorte.Add(numero);
                    if (numero % 2 == 0) qtdPar++;
                    if (numero % 2 == 1) qtdImpar++;
                    contador++;
                }

                NumerosDaSorte = NumerosDaSorte.OrderBy(num => num).ToList();
                Classificacao(qtdPar, qtdImpar);
                dgvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();
            }
        }

        private void btnGerarNumeros_Click(object sender, EventArgs e)
        {
            GerarNumeros();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            NumerosDaSorte.Clear();
            lblPar.Text = "Pares: 0";
            lblImpar.Text = "Ímpares: 0";
            lblClass.Text = "Classificação";
            lblClass.ForeColor = Color.Black;
            dgvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();
        }
    }
}