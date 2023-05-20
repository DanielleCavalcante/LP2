using Microsoft.VisualBasic;
using System.Collections;

namespace Pmatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInverterVetor_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar;
            string saida = "";

            for (var i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite um número:", "Entrada de dados");
                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Valor inválido!");
                    i++;
                }
                else
                {
                    saida = vetor[i] + "\n" + saida;
                }
            }

            /*auxiliar = "";
            for (var i = 19; i >= 0; i++)
            {
                //auxiliar=auxiliar + "\n" + vetor[i];
                auxiliar += "\n" + vetor[i];
            }*/

            Array.Reverse(vetor);
            auxiliar = "";
            foreach (int x in vetor)
            {
                auxiliar += x + "\n";
            }
            MessageBox.Show(auxiliar);

        }

        private void btnMercadoria_Click(object sender, EventArgs e)
        {
            double[] quantidade = new double[10];
            double[] preco = new double[10];
            string auxiliar = "";
            double faturamento = 0;

            for (var i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite a QUANTIDADE da mercadoria " + (i + 1), "Entrada de quantidades");

                if (!double.TryParse(auxiliar, out quantidade[i]))
                {
                    MessageBox.Show("quantidade inválida");
                    i++;
                }
                else
                {
                    while (preco[i] <= 0)
                    {
                        auxiliar = Interaction.InputBox("Digite o PREÇO da mercadoria " + (i + 1), "Entrada dos preços");

                        if (!double.TryParse(auxiliar, out preco[i]))
                        {
                            MessageBox.Show("Preço inválido!");

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

        private void brnVerificarTotal_Click(object sender, EventArgs e)
        {
            string[] alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "José", "Nelma", "Tobby" };
            Int32 i, total = 0;
            Int32 n = alunos.Length;

            for (i = 0; i < n - 1; i++)
            {
                total += alunos[i].Length;
                MessageBox.Show(Convert.ToString(total));
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] media = new double[20];
            string auxiliar = "";
            string mediaaluno = "";
            double soma;
            int i;
            int j;


            for (i = 0; i < 20; i++)
            {
                soma = 0;


                for (j = 0; j < 3; j++)
                {
                    {
                        auxiliar = Interaction.InputBox("Aluno: " + (i + 1) + "\n\n" + "Digite a Nota " + (j + 1));

                    }

                    if (!double.TryParse(auxiliar, out notas[i, j]))
                    {
                        MessageBox.Show("Valor da Nota é Inválido!");
                        j--;
                    }
                    else
                    {

                        if (notas[i, j] < 0 || notas[i, j] > 10)
                        {

                            if (notas[i, j] < 0)
                            {
                                MessageBox.Show("Nota deve ser maior ou igual a zero!");
                            }
                            else if (notas[i, j] > 10)
                            {
                                MessageBox.Show("Nota deve ser menor que dez!");
                            }

                            j--;

                        }

                    }

                    soma += notas[i, j];

                }
                media[i] = soma / 3;
                mediaaluno = mediaaluno + "Aluno " + (i + 1).ToString("00") + ": " + " Média: " + media[i].ToString("N2") + "\n";
                i++;
            }

            MessageBox.Show("Média das notas: \n\n" + mediaaluno.ToString());

        }

        private void btnListaAluno_Click(object sender, EventArgs e)
        {
            var arlist = new ArrayList();

            arlist.Add("Ana");
            arlist.Add("André");
            arlist.Add("Débora");
            arlist.Add("Fátima");
            arlist.Add("João");
            arlist.Add("Janete");
            arlist.Add("Otávio");
            arlist.Add("Marcelo");
            arlist.Add("Pedro");
            arlist.Add("Thaís");

            string listaalunos = "";
            int i = 1;

            foreach (var aluno in arlist)
            {
                listaalunos = listaalunos + i.ToString("00") + ". " + aluno.ToString() + "\n";
                i++;
            }

            MessageBox.Show("Lista completa de alunos:\n\n" + listaalunos.ToString());

            arlist.Remove("Otávio");

            i = 1;
            string nomes = "";
            foreach (var aluno in arlist)
            {
                nomes = nomes + i.ToString("00") + ". " + aluno.ToString() + "\n";
                i++;
            }

            MessageBox.Show("Lista sem o Otávio:\n\n" + nomes.ToString());

        }

        private void btnComprimento_Click(object sender, EventArgs e)
        {
            string[] nome = new string[6];
            int[] comprimento = new int[6];
            string auxiliar = "";
            string lista = "";
            int i = 0;


            for (i = 0; i < 6; i++)
            {
                auxiliar = Interaction.InputBox("Digite o Nome " + (i + 1).ToString("00") + ": ", "NOME");

                if (auxiliar.Trim() == "" || auxiliar.Length == 0)
                {
                    MessageBox.Show("Nome está vazio!");
                    i--;
                }
                else
                {
                    auxiliar = auxiliar.Trim();
                    nome[i] = auxiliar;
                    auxiliar = auxiliar.Replace(" ", "");
                    comprimento[i] = auxiliar.Length;
                }
            }

            i = 0;
            while (i < 6)
            {
                lista = lista + "O nome: " + nome[i] + " tem " + comprimento[i] + " caracteres;\n";
                i++;

            }

            MessageBox.Show(lista.ToString());

        }
    }
}