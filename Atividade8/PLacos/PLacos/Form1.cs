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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exercicio1>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio1"].BringToFront();

                //método Activate () faz basicamente a mesma coisa que o BringToFront, com o adicional de dar foco no form.
            }

            else
            {
                Exercicio1 obj1 = new Exercicio1();
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }

        private void Exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exercicio2>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio2"].BringToFront();

                //método Activate () faz basicamente a mesma coisa que o BringToFront, com o adicional de dar foco no form.
            }

            else
            {
                Exercicio2 obj1 = new Exercicio2();
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exercicio3>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio3"].BringToFront();

                //método Activate () faz basicamente a mesma coisa que o BringToFront, com o adicional de dar foco no form.
            }

            else
            {
                Exercicio3 obj1 = new Exercicio3();
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exercicio4>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio4"].BringToFront();

                //método Activate () faz basicamente a mesma coisa que o BringToFront, com o adicional de dar foco no form.
            }

            else
            {
                Exercicio4 obj1 = new Exercicio4();
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
