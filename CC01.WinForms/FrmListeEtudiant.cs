using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmListeEtudiant : Form
    {
        private EtudiantBLO etudiantBLO;
        private EcoleBLO ecoleBLO;
        public FrmListeEtudiant()
        {

            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = txtRecherch.Text.ToLower();
            var etudiants = etudiantBLO.GetBy
            (
                x =>
                x.Matricule.ToLower().Contains(value) ||
                x.Nom.ToLower().Contains(value)
            ).OrderBy(x => x.Matricule).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiants;
            //lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
        }
        private void FrmListeEtudiant_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Form f = new FrmEtudiantModif(loadData);
            f.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmEtudiantModif
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Etudiant,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this student(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        etudiantBLO.DeleteEtudiant(dataGridView1.SelectedRows[i].DataBoundItem as Etudiant);
                    }
                    loadData();
                }
            }
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            List<ListeEtudiantImprimer> items = new List<ListeEtudiantImprimer>();
            Ecole ecole = ecoleBLO.GetEcole();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Etudiant p = dataGridView1.Rows[i].DataBoundItem as Etudiant;
                items.Add
                (
                new ListeEtudiantImprimer
                (
                    p.Matricule,
                    p.Nom,
                    p.PreNom,
                    p.Contact,
                    p.LieuNais,
                    DateTime.Parse(p.DateNais),
                    p.Email,
                    p.Photo,
                    ecole?.NomEcole,
                    ecole?.EmailEcole,
                    Byte.Parse(ecole?.ContactEcole.ToString()),
                    !string.IsNullOrEmpty(ecole?.Logo) ? File.ReadAllBytes(ecole?.Logo) : null
                    )
                );
            }
                Form f = new FrmPreview("EtudiantListe.rdlc", items);
                f.Show();
        }
        
    }

}

    

