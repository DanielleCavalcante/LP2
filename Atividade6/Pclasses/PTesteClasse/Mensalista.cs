using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasse
{
    class Mensalista : Empregado //especializacao -> heranca
    {

        public Double SalarioMensal { get; set; } //forma mais enxuta

        //sobreescrevendo o método

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

        //construtor --> new
        public Mensalista()
        {
            MessageBox.Show("Passei por aqui");
        }

        public Mensalista(double x)
        {

        }

        public Mensalista(int matx, string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }
    }
}
