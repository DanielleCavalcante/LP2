using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        double peso, altura, imc;
        public Form1()
        {
            InitializeComponent();
        }

        private void MskPeso_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskPeso.Text, out peso) ||
                peso <= 0)
            {
                MessageBox.Show("Digite um peso válido!");
            }
        }

        private void MskAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskAltura.Text, out altura) ||
                peso <= 0)
            {
                MessageBox.Show("Digite uma altura válida!");
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            imc = peso / (Math.Pow(altura, 2));
            //imc = peso / (altura * altura);

            imc = Math.Round(imc, 1); //arredonda o imc em 1 casa depois da vírgula

            if (peso > 0 && altura > 0)
            {
                if (imc < 18.5)
                {
                    txtClasse.Text = "Magreza";
                    txtObesidade.Text = "0";
                    txtIMC.Text = imc.ToString("N1");
                }

                else if (imc <= 24.9)
                {
                    txtClasse.Text = "Normal";
                    txtObesidade.Text = "0";
                    txtIMC.Text = imc.ToString("N1");
                }

                else if (imc <= 29.9)
                {
                    txtClasse.Text = "Sobrepeso";
                    txtObesidade.Text = "I";
                    txtIMC.Text = imc.ToString("N1");
                }

                else if (imc <= 39.9)
                {
                    txtClasse.Text = "Obesidade";
                    txtObesidade.Text = "II";
                    txtIMC.Text = imc.ToString("N1");
                }

                else
                {
                    txtClasse.Text = "Obesidade Grave";
                    txtObesidade.Text = "III";
                    txtIMC.Text = imc.ToString("N1");
                }
            }

            else
            {
                MessageBox.Show("Verifique os valores digitados!");
            }

        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtClasse.Clear();
            txtObesidade.Clear();
            txtIMC.Clear();
            mskAltura.Clear();
            mskPeso.Clear();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
