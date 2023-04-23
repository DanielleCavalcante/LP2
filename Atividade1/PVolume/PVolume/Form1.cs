using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double raio;
            double altura; 

            if (!double.TryParse(txtRaio.Text, out raio))  //se não for double:
            {
                MessageBox.Show("Verifique o número digitado no campo Raio ");
            }

            if (!double.TryParse(txtAltura.Text, out altura))  //se não for double:
            {
                MessageBox.Show("Verifique o número digitado no campo Altura ");
            }

            double volume = Math.PI * raio * raio * altura; //para fazer o cálculo, precisa transformar o raio/altura de string para double

            txtVolume.Text = volume.ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //ao clicar no botão de fechar, o evento de fechar a aplicação será executado
        }
    }
}
