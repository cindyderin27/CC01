using CC01.BLL;
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
    public partial class FrmListeEcole : Form
    {
        private EcoleBLO ecoleBLO;
        public FrmListeEcole()
        {
            InitializeComponent();
        }

        private void btnCreerEcole_Click(object sender, EventArgs e)
        {
            //Form f = new FrmEcoleModif(loadData);
            //f.Show(); 

        }
        private void loadData()
        {
            //string value = txtRecherchEcole.Text.ToLower();
            //var etudiants = ecoleBLO.Get
            //(
            //    x =>
            //    x.NomEcole.ToLower().Contains(value) ||
            //    x.EmailEcole.ToLower().Contains(value)
            //).OrderBy(x => x.Matricule).ToArray();
            //dataGridView2.DataSource = null;
            //dataGridView2.DataSource = etudiants;
            ////lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            //dataGridView2.ClearSelection();
        }
    }
}
