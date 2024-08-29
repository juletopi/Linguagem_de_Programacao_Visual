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
    public partial class FormMegaSena : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        public FormMegaSena()
        {
            InitializeComponent();
        }

        /*
          MegaSena

          Números envolvidos: 6 números sorteados entre 1 e 60.
          Classificação de chances de ganhar:
            - 3 pares e 3 ímpares: "MUITO ALTO!"
            - 4 pares e 2 ímpares: "ALTO!"
            - 2 pares e 4 ímpares: "MÉDIO!"
            - 5 pares e 1 ímpar: "BAIXO!"
            - 1 par e 5 ímpares: "MUITO BAIXO!"
        */

        public void Classificacao(int par, int impar)
        {
            lblPar.Text = "Pares: " + par;
            lblImpar.Text = "Ímpares: " + impar;

            // Estatísticas
            if (impar == 3 && par == 3)
            {
                lblClass.Text = "MUITO ALTO!";
                lblClass.ForeColor = Color.Green;
            }

            if (impar == 4 && par == 2)
            {
                lblClass.Text = "ALTO!";
                lblClass.ForeColor = Color.Green;
            }

            if (impar == 2 && par == 4)
            {
                lblClass.Text = "MÉDIO!";
                lblClass.ForeColor = Color.Orange;
            }

            if (impar == 5 && par == 1)
            {
                lblClass.Text = "BAIXO!";
                lblClass.ForeColor = Color.OrangeRed;
            }

            if (impar == 1 && par == 5)
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

            while (contador < 6) // Mega Sena são 6 números
            {
                numero = radNum.Next(1, 61); // Mega Sena tem 60 números
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

        private void btnGerarNumeros_Click_1(object sender, EventArgs e)
        {
            GerarNumeros();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
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