using CC01.BLL;
using CC01.BO;
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
        //private EcoleBLO ecoleBLO;
        //private Action callBack;
        //private Etudiant oldEtudiant;
        public FrmListeEcole()
        {
            InitializeComponent();
        }

        //private void btnCreerEcole_Click(object sender, EventArgs e)
        //{
        //    //Form f = new FrmEcoleModif(loadData);
        //    //f.Show(); 

        //}
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        checkForm();

            //        Etudiant newEtudiant = new Etudiant
            //        (
            //        txtMatricule.Text.ToUpper(),
            //        txtNom.Text,
            //        txtPrenom.Text,
            //        dateTimePicker1.Text,
            //        txtLieu.Text,
            //        txtEmail.Text,
            //        long.Parse(txtContact.Text),
            //         !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEtudiant?.Photo
            //        );
            //        if (newEtudiant.Photo != null)
            //        {
            //            pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])newEtudiant.Photo));
            //        }

            //        EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);

            //        if (this.oldEtudiant == null)
            //            etudiantBLO.CreateEtudiant(newEtudiant);
            //        else
            //            etudiantBLO.EditEtudiant(oldEtudiant, newEtudiant);

            //        MessageBox.Show
            //        (
            //            "Save done !",
            //            "Confirmation",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Information
            //        );

            //        if (callBack != null)
            //            callBack();

            //        if (oldEtudiant != null)
            //            Close();

            //        txtMatricule.Clear();
            //        txtNom.Clear();
            //        txtPrenom.Clear();
            //        txtContact.Clear();
            //        txtEmail.Clear();
            //        txtLieu.Clear();
            //        txtMatricule.Focus();

            //    }
            //    catch (TypingException ex)
            //    {
            //        MessageBox.Show
            //       (
            //           ex.Message,
            //           "Typing error",
            //           MessageBoxButtons.OK,
            //           MessageBoxIcon.Warning
            //       );
            //    }
            //    catch (DuplicateNameException ex)
            //    {
            //        MessageBox.Show
            //       (
            //           ex.Message,
            //           "Duplicate error",
            //           MessageBoxButtons.OK,
            //           MessageBoxIcon.Warning
            //       );
            //    }
            //    catch (KeyNotFoundException ex)
            //    {
            //        MessageBox.Show
            //       (
            //           ex.Message,
            //           "Not found error",
            //           MessageBoxButtons.OK,
            //           MessageBoxIcon.Warning
            //       );
            //    }
            //    catch (Exception ex)
            //    {
            //        ex.WriteToFile();
            //        MessageBox.Show
            //       (
            //           "An error occurred! Please try again later.",
            //           "Erreur",
            //           MessageBoxButtons.OK,
            //           MessageBoxIcon.Error
            //       );
            //    }
            //}
        }
    }
}
