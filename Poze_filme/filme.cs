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
    public partial class filme : Form
    {
        string[] f;
        public filme()
        {
            InitializeComponent();
            cautaFisier.InitialDirectory = Directory.GetCurrentDirectory();
            if (cautaFisier.ShowDialog() == DialogResult.OK)
            {
                f = Directory.GetFiles(Path.GetDirectoryName(cautaFisier.FileName));
                for (int i = 0; i < f.Length; i++)
                    listaFilme.Items.Add(f[i]);
            }

        }

        private void listaFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmp.URL = (string)listaFilme.SelectedItem;
        }

        private void filme_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmp.Ctlcontrols.stop();
        }
    }
}
