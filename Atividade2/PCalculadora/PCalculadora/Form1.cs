using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; //variaveis globais, serão utilizadas em todo o código

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNum1_Validated(object sender, EventArgs e)
        {
            if  (!Double.TryParse(txtNum1.Text, out numero1)) //se tryparse der certo o resultado sera armazenado no numero1
            {
                MessageBox.Show("Número 1 inválido!");
                //txtNum1.Focus(); -- O curso não sairá do txtNum1 até que usuário digite um número válido
            }
        }

        private void TxtNum2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido!");
                //txtNum1.Focus(); 
            }
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNum1.Text, out numero1) && 
                Double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNum1.Text, out numero1) &&
                Double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNum1.Text, out numero1) &&
                Double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNum1.Text, out numero1) &&
                Double.TryParse(txtNum2.Text, out numero2) &&
                numero2 != 0)
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString("N2");
            }

            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";

            //txtNum1.Clear();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
