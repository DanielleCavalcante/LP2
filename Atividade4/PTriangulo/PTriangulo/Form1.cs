using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double LadoA;
            double LadoB;
            double LadoC;

            if(!double.TryParse(txtLadoA.Text, out LadoA))
                MessageBox.Show("Lado A inválido!");
            else if(!double.TryParse(txtLadoB.Text, out LadoB))
                MessageBox.Show("Lado B inválido");
            else if(!double.TryParse(txtLadoC.Text, out LadoC))
                MessageBox.Show("Lado C inválido!");
            else //testar se forma o triângulo
            {
                if(LadoA < (LadoB + LadoC) && LadoA > Math.Abs(LadoB - LadoC) &&
                   LadoB < (LadoA + LadoC) && LadoB > Math.Abs(LadoA - LadoC) &&
                   LadoC < (LadoA + LadoB) && LadoC > Math.Abs(LadoA - LadoB))
                {
                    //verificar tipo do triângulo
                    if (LadoA == LadoB && LadoB == LadoC)
                    {
                        MessageBox.Show("Triângulo equilátero!");
                    }

                    else if(LadoA != LadoC && LadoB != LadoC && LadoA != LadoC)
                    {
                        MessageBox.Show("Triângulo escaleno!");
                    }

                    else
                    {
                        MessageBox.Show("Triângulo isósceles!");
                    }
                }

                else
                {
                    MessageBox.Show("Lados não formam um triângulo");
                }
            }
        }
    }
}
