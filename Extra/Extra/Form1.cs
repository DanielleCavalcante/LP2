using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))//tecla que foi pressionada é o ENTER (13 na tabela asc), transformamos em char para verifcar
            {
                SendKeys.Send("{TAB}"); //simula que uma tecla foi pressionada (tab no lugar do enter).
                //sendkeys envia algo quando algum evento for criado, nesse caso ele envia o TAB no lugar o quando enter pressionar
                e.Handled = true; //desabilita o som de BIP que faz quando o textbox é "teclado" com TAB            
            }
        }

        private void textBox2_Validated(object sender, EventArgs e) //evento criado a partir das propriedades VALIDATED
        {
            if((textBox2.Text == "") || (textBox2.Text.Length < 20))
            {
                MessageBox.Show("Nome inválido!");
                textBox2.Focus(); //Mesmo com o erro depois o "cursor" tem que voltar para o mesmo textbox
            }
        }
        private void textBox3_Validating(object sender, CancelEventArgs e) //a partir das propriedades VALIDATING
        {
            if(textBox3.Text == "")
            {
                MessageBox.Show("E-mail vazio!");
                e.Cancel = true; //cancela a validação, ou seja, não vai ser validado e não vai passar para o próximo textbox
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("textBox4 perdeu o foco"); //para deixar alguma mensagem quando o cursor sai do textbox "perder foco"
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("textBox5 ganhou o foco"); //para deixar alguma mensagem quando o cursor chega no textbox "ganhou foco"
        }
    }
}
