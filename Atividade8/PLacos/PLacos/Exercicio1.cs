using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void Exercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btnLetrasRepetidas_Click(object sender, EventArgs e)
        {
            int letrasRep = 0;
            string auxiliar = rchtxtFrase.Text.Replace(" ", "");

            if (rchtxtFrase.Text == "")
            {
                MessageBox.Show("Insira um texto");
                rchtxtFrase.Focus();
            }
            else
            {
                for (int i = 1; i < auxiliar.Length; i++)
                {
                    if (auxiliar.ToUpper()[i] == auxiliar.ToUpper()[i - 1])
                        letrasRep++;
                }

                txtResultado.Text = letrasRep.ToString();
                //MessageBox.Show("Pares de letras repetidas: " + letrasRep.ToString());
            }
        }

        private void btnQtdeR_Click(object sender, EventArgs e)
        {
            int letrasR = 0;

            if (rchtxtFrase.Text == "")
            {
                MessageBox.Show("Insira um texto");
            }

            else
            {
                foreach (char c in rchtxtFrase.Text)
                {
                    if (Char.ToUpper(c) == 'R')
                        letrasR++;
                }
                if (letrasR > 0)
                    txtResultado.Text = letrasR.ToString();
                    //MessageBox.Show("O número de letras R é: " + letrasR.ToString());
                else
                {
                    txtResultado.Text = letrasR.ToString();
                    MessageBox.Show("Esse texto não pussui nenhuma letra R");
                }
            }
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            if (rchtxtFrase.Text == "")
            {
                MessageBox.Show("Insira um texto");
                rchtxtFrase.Focus();
            }
            else
            {
                while (x < rchtxtFrase.Text.Length)
                {
                    if (Char.IsWhiteSpace(rchtxtFrase.Text, x) == true)
                    {
                        y += 1;
                    }
                    x++;
                }
                if (y > 0)
                {
                    txtResultado.Text = y.ToString();
                    MessageBox.Show("O texto possui " + y.ToString() + " espaços em branco");
                }
                else
                {
                    txtResultado.Text = y.ToString();
                    MessageBox.Show("Este texto não possui espaços em branco");
                }
             }
        }
    }
}
