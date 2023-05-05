using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasse
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInstanciarMensalista_Click(object sender, EventArgs e)
        {
            //não é possível: Empregado obj1 = new Empregado();

            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);
            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matricula: " + objMensalista.Matricula +
                            '\n' + '\n' + "Nome: " + objMensalista.NomeEmpregado +
                            '\n' + '\n' + "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() +
                            '\n' + '\n' + "Salario Bruto: " + objMensalista.SalarioBruto().ToString("N2") +
                            '\n' + '\n' + "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() +
                            '\n' + '\n' + objMensalista.VerificaHome());
        }

        private void btnInstanciarParametros_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                 Convert.ToInt32(txtMatricula.Text),
                 txtNome.Text,
                 Convert.ToDateTime(txtDataEntrada.Text),
                 Convert.ToDouble(txtSalarioMensal.Text));

            //get
            MessageBox.Show("Matrícula: " + objMensalista.Matricula + 
                            "\n" + "\n" + "Nome: " + objMensalista.NomeEmpregado +
                            "\n" + "\n" + "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() +
                            "\n" + "\n" + "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") +
                            "\n" + "\n" + "Tempo Empresa (dias): " + objMensalista.TempoTrabalho());
        }
    }
}
