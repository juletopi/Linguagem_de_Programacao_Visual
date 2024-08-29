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
    public partial class FormLotoFacil : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        public FormLotoFacil()
        {
            InitializeComponent();
        }

        /*
          LotoFácil

          Números envolvidos: 15 números sorteados entre 1 e 25.
          Classificação de chances de ganhar:
            - 7 pares e 8 ímpares: "MUITO ALTO!"
            - 8 pares e 7 ímpares: "ALTO!"
            - 6 pares e 9 ímpares: "ALTO!"
            - 9 pares e 6 ímpares: "MÉDIO!"
            - 5 pares e 10 ímpares: "MÉDIO!"
            - Outras combinações: "BAIXO!"
        */

        public void Classificacao(int par, int impar)
        {
            lblPar.Text = "Pares: " + par;
            lblImpar.Text = "Ímpares: " + impar;

            // Estatísticas
            if (impar == 8 && par == 7)
            {
                lblClass.Text = "MUITO ALTO!";
                lblClass.ForeColor = Color.Green;
            }

            if (impar == 7 && par == 8)
            {
                lblClass.Text = "ALTO!";
                lblClass.ForeColor = Color.Green;
            }

            if (impar == 9 && par == 6)
            {
                lblClass.Text = "MÉDIO!";
                lblClass.ForeColor = Color.Orange;
            }

            if (impar == 6 && par == 9)
            {
                lblClass.Text = "BAIXO!";
                lblClass.ForeColor = Color.OrangeRed;
            }

            if (impar <= 5 && par >= 10)
            {
                lblClass.Text = "MUITO BAIXO!";
                lblClass.ForeColor = Color.Red;
            }

            if (impar >= 10 && par <= 5)
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

            while (contador < 15) // LotoFácil são 15 números
            {
                numero = radNum.Next(1, 26); // LotoFácil tem 25 números
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
            dgvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new {Numero = Numeros}).ToList();
        }
    }
}