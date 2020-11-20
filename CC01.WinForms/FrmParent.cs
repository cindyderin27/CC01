using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmEtudiantModif();
            f.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmListeEtudiant();
            f.Show();
        }

        private void creerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmEcoleModif();
            f.Show();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new FrmListeEcole();
            f.Show();
        }
    }
}
