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
    public partial class Sair : Form
    {
        public Sair()
        {
            InitializeComponent();
        }

        private void Sair_Load(object sender, EventArgs e)
        {
            Close();
        }
    }
}
