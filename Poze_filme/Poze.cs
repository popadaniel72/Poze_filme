using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Poze_filme
{
    public partial class Poze : Form
    {
        string[] listaPoze;
        int crt, nrPoze;
        public Poze()
        {
            InitializeComponent();
            listaPoze = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\poze\");
            nrPoze = listaPoze.Length;
            crt = 0;
            poza.Load(listaPoze[crt]);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (crt < nrPoze - 1) crt++;
                else crt = 0;
            poza.Load(listaPoze[crt]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (crt > 0) crt--;
                else crt = nrPoze - 1;
            poza.Load(listaPoze[crt]);
        }
    }
}
