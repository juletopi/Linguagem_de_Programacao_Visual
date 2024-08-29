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
    public partial class FormDiaDeSorte : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        public FormDiaDeSorte()
        {
            InitializeComponent();
        }

        /*
          Dia de Sorte
          
          Números envolvidos: 7 números sorteados entre 1 e 31.
          Classificação de chances de ganhar:
            - 4 pares e 3 ímpares: "MUITO ALTO!"
            - 3 pares e 4 ímpares: "ALTO!"
            - 5 pares e 2 ímpares: "MÉDIO!"
            - 2 pares e 5 ímpares: "MÉDIO!"
            - 6 pares e 1 ímpar: "BAIXO!"
            - 1 par e 6 ímpares: "BAIXO!"
        */

        public void Classificacao(int par, int impar)
        {
            lblPar.Text = "Pares: " + par;
            lblImpar.Text = "Ímpares: " + impar;

            // Estatísticas
            if (par == 4 && impar == 3)
            {
                lblClass.Text = "MUITO ALTO!";
                lblClass.ForeColor = Color.Green;
            }
            else if (par == 3 && impar == 4)
            {
                lblClass.Text = "ALTO!";
                lblClass.ForeColor = Color.Green;
            }
            else if (par == 5 && impar == 2)
            {
                lblClass.Text = "MÉDIO!";
                lblClass.ForeColor = Color.Orange;
            }
            else if (par == 2 && impar == 5)
            {
                lblClass.Text = "BAIXO!";
                lblClass.ForeColor = Color.OrangeRed;
            }
            else
            {
                lblClass.Text = "MUITO BAIXO!";
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

            while (contador < 7) // Dia de Sorte são 7 números
            {
                numero = radNum.Next(1, 32); // Dia de Sorte tem números de 1 a 31
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