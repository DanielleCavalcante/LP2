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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void Exercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string texto, textoInvertido;

            if (txtTextoP.Text == "")
            {
                MessageBox.Show("Insira um texto!");
                txtTextoP.Focus();
            }
            else
            {
                texto = txtTextoP.Text.ToLower().Replace(" ", "");

                byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(texto);

                texto = System.Text.Encoding.UTF8.GetString(bytes);

                textoInvertido = new string(texto.Reverse().ToArray());

                if (textoInvertido == texto)
                    MessageBox.Show(texto + " é um palindromo!");
                else
                    MessageBox.Show(texto + " não é um palindromo!");
            }
        }
    }
}
