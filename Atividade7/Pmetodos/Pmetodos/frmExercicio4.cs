using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCaracterNum_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string Texto;
            int Tamanho;

            if ((rchtxrbxTexto.Text == ""))
                MessageBox.Show("Caixa de Texto Vazia!");
            else
            {
                Texto = rchtxrbxTexto.Text;
                Tamanho = rchtxrbxTexto.Text.Length;

                for (int i = 0; i < Tamanho; i++)
                    if (char.IsNumber(Texto[i]))
                    {
                        cont++;
                    }

                if (cont > 0)
                    MessageBox.Show("Quantidade de caracter numérico no texto: " + cont);
                else
                    MessageBox.Show("Não há caracter numérico!");
            }

        }

        private void btnCaracterBranco_Click(object sender, EventArgs e)
        {
            int i = 0;
            int posicao = 0;
            string Texto;

            if ((rchtxrbxTexto.Text == ""))
                MessageBox.Show("Caixa de Texto Vazia!");
            else
            {
                Texto = rchtxrbxTexto.Text;

                while (i < Texto.Length)
                {
                    if (!char.IsWhiteSpace(Texto[i]))
                    {
                        i++;

                    }
                    else
                    {
                        posicao = i + 1;
                        break;
                    }

                }

                if (posicao > 0)
                    MessageBox.Show("O 1ª espaço em branco localizado está na posição: " + posicao);
                else
                    MessageBox.Show("Não há espaço em branco!");
            }


        }

        private void btnCaracterAlfabetico_Click(object sender, EventArgs e)
        {
            int cont = 0;


            if (rchtxrbxTexto.Text == "")
                MessageBox.Show("Caixa de Texto Vazia!");
            else
            {
                foreach (char i in rchtxrbxTexto.Text)
                    if (char.IsLetter(i))
                    {
                        cont++;
                    }
                if (cont > 0)
                    MessageBox.Show("Quantidade de caracteres alfabéticos: " + cont);
                else
                    MessageBox.Show("Não há caracteres alfabéticos!");

            }

        }
    }
}
