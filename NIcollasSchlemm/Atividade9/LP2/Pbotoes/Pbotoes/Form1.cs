using Microsoft.VisualBasic;
using System.Collections;

namespace Pbotoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVetorInverte_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar;
            string saida = "";

            for (var i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite um numero",
                "Entrada de Dados"); // adcionar em projeto // add reference // visual basic

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Valor Inválido!");
                    i--;
                }
                else
                {
                    saida = vetor[i] + "\n" + saida;
                }
            }


            MessageBox.Show(saida);

            Array.Reverse(vetor);

            auxiliar = "";

            foreach (int x in vetor)
            {
                auxiliar += x + "\n";
            }
            MessageBox.Show(auxiliar);


            // forma tradicional 
            /*
            auxiliar =  "";
            for (var i = 19; i >= 0; i--)
            {
                auxiliar += "\n" + vetor[i];
            }

            MessageBox.Show(auxiliar);
            */

        }

        private void btnMercadora_Click(object sender, EventArgs e)
        {
            double[] quantidade = new double[10];
            double[] preco = new double[10];
            string auxiliar = "";
            double faturamento = 0;

            for (var i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite a quantidade da mercadoria " + (i + 1),
                "Entrada das quantidades");
                if (!double.TryParse(auxiliar, out quantidade[i]))
                {
                    MessageBox.Show("Quantidade inválida!");
                    i--;
                }
                else
                {
                    while (preco[i] <= 0)
                    {
                        auxiliar = Interaction.InputBox("Digite o preço da mercadoria " + (i + 1),
                        "Entrada dos preços");
                        if (!double.TryParse(auxiliar, out preco[i]))
                        {
                            MessageBox.Show("Preço Inválido!");
                        }
                        else
                        {
                            if (preco[i] <= 0)
                            {
                                MessageBox.Show("Preço deve ser maior que zero!");
                            }

                        }
                    }

                    faturamento += quantidade[i] * preco[i];

                }
            }

            MessageBox.Show("Faturamento: " + faturamento.ToString("N2"));
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();
            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fatima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thais");

            foreach (object obj in alunos)
            {

            }

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] Media = new double[20];
            string Auxiliar;
            int i, c;

            for (i = 0; i < 20; i++)
                for (c = 0; c < 3; c++)
                {

                    Auxiliar = Interaction.InputBox("Escreva As notas do aluno" + (c + 1));
                    if (!double.TryParse(Auxiliar, out notas[i, c]))
                    {
                        MessageBox.Show("Nota invalida!");
                        i--;
                    }

                }

            for (i = 0; i < 20; i++)
                for (c = 0; c < 1; c++)
                {
                    Media[i] = notas[i, c] + notas[i, c + 1] + notas[i, c + 2];
                }
            for (i = 0; i < 20; i++)
            {
                MessageBox.Show("Aluno" + i + ": " + Media[i]); 
            }
        }
    }
}


    



   