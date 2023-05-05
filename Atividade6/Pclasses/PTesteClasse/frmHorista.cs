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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            //set
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);
            if (rbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matricula: " + objHorista.Matricula +
                            '\n' + '\n' + "Nome: " + objHorista.NomeEmpregado +
                            '\n' + '\n' + "Data Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() +
                            '\n' + '\n' + "Salario Bruto: " + objHorista.SalarioBruto().ToString("N2") +
                            '\n' + '\n' + "Tempo Empresa (dias): " + objHorista.TempoTrabalho() +
                            '\n' + '\n' + objHorista.VerificaHome());
        }
    }
}
