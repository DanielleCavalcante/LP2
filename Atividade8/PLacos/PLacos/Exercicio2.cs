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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void Exercicio2_Load(object sender, EventArgs e)
        {
            btnGerarH.Enabled = false;
        }

        private void btnTestarN_Click(object sender, EventArgs e)
        {
            double n = 0;

            if (txtNumeroN.Text == "")
            {
                MessageBox.Show("Insira um número!");
                txtNumeroN.Focus();
                txtNumeroN.Text = "";
            }
            else if (!Double.TryParse(txtNumeroN.Text, out n))
            {
                MessageBox.Show("Insira um número válido!");
                txtNumeroN.Focus();
                txtNumeroN.Text = "";
            }
            else if (n <= 0)
            {
                MessageBox.Show("O número N é menor ou igual a 0!");
                txtNumeroN.Focus();
            }

            else
            {
                MessageBox.Show("O Número N é maior que 0");
                btnGerarH.Enabled = true;
            }
        }

        private void btnGerarH_Click(object sender, EventArgs e)
        {
            double n, x, h = 0;

            n = Double.Parse(txtNumeroN.Text);

            for (x = 0; x < n; x++)
            {
                h = (1 / (x + 1)) + h;
            }

            txtNumeroH.Text = h.ToString();
        }
    }
}
