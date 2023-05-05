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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random numsorteado = new Random();
            int numinicio;
            int numfinal;
            int resultado;


            if (Int32.TryParse(txtNumero1.Text, out numinicio) &&
                Int32.TryParse(txtNumero2.Text, out numfinal))
            {
                if (numinicio <= numfinal)
                {
                    resultado = numsorteado.Next(numinicio, numfinal + 1);
                }
                else
                {
                    resultado = numsorteado.Next(numfinal, numinicio + 1);
                }

                MessageBox.Show("Número Sorteado: " + resultado.ToString());
            }
            else
            {
                if (txtNumero1.Text == "" && txtNumero2.Text == "")
                {
                    MessageBox.Show("Caixa Número 1 e Número 2 estão vazias!");

                }
            }
        }
    }
}
