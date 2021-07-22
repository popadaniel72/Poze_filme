using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poze_filme
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poze p = new Poze();
            p.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filme f = new filme();
            f.ShowDialog();
        }
    }
}
