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
        private Action callback;
        private EtudiantBLO etudiantBLO;
        private EcoleBLO ecoleBLO;
        private Etudiant oldEtu;
        public FrmListeEtudiant()
        {

            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        public FrmListeEtudiant(Action callback) : this()
        {
            this.callback = callback;
        }
        public FrmListeEtudiant(Etudiant etudiant, Action callback) : this(callback)
        {
            this.oldEtu = etudiant;
            txtMatricule.Text = etudiant.Matricule;
            txtNom.Text = etudiant.Nom;
            txtPrenom.Text = etudiant.PreNom;
            dateTimePicker1.Text = etudiant.DateNais;
            txtLieu.Text = etudiant.LieuNais;
            txtEmail.Text = etudiant.Email;
            txtContact.Text = etudiant.Contact.ToString();
            pictureBox1.Image = etudiant.Photo != null ? Image.FromStream(new MemoryStream(etudiant.Photo)) : null;
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


        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmListeEtudiant
                        (
                            dataGridView1.SelectedRows[i].DataBoundItem as Etudiant,
                            loadData
                        );
                    this.Hide();
                    f.Show();
                    f.WindowState = FormWindowState.Maximized;
                }

            }
        }

         
        private void btnEnregistrer_Click(object sender, EventArgs e)   
        {
            try
            {
                checkForm();

                Etudiant newEtu = new Etudiant(
                    txtMatricule.Text.ToUpper(),
                    txtNom.Text,
                    txtPrenom.Text,
                    dateTimePicker1.Text,
                    txtLieu.Text,
                    txtEmail.Text,
                    long.Parse(txtContact.Text),
                    !String.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEtu?.Photo
                   
                    );

                EtudiantBLO etuBlo = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
                if (this.oldEtu == null)
                {
                    etuBlo.CreateEtudiant(newEtu);
                }
                else
                {
                    etuBlo.EditEtudiant(oldEtu, newEtu);
                }
                // etuBlo.CreateEtudiant(newEtu);
                MessageBox.Show(
                    "Enregistrement éffectué !",
                     "Confirmé",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                    );
                if (callback != null)
                    callback();

                if (oldEtu != null)
                    Close();
                txtMatricule.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                dateTimePicker1.Refresh();
                txtLieu.Clear();
                txtEmail.Clear();
                txtContact.Clear();
                txtMatricule.Focus();
            }
            catch (TypingException ex)
            {

                MessageBox.Show
                    (
                    ex.Message,
                    "Typing error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                   );
            }
            catch (DuplicateNameException ex)
            {

                MessageBox.Show
                    (
                    ex.Message,
                    "Duplicate error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                   );
            }
            catch (KeyNotFoundException ex)
            {

                MessageBox.Show
                    (
                    ex.Message,
                    "Not found error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                   );
            }

            catch (Exception ex)
            {
                ex.WriteToFile();
                using (StreamWriter sw =new StreamWriter("app.log", true))
                 {
                  sw.WriteLine(ex.ToString());
                }
                MessageBox.Show
                    (
                    "An Error occured! Please try again",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                   );
            }
            loadData();
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var mydata = qr.CreateQrCode(txtMatricule.Text,QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(mydata);
            pictureBoxQR.Image = code.GetGraphic(50);
           
        }

        private void checkForm()
        {
            string text = string.Empty;
            txtMatricule.BackColor = Color.White;
            txtNom.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtMatricule.Text))
            {
                text += "-------------Please enter the reference!\n";
                txtMatricule.BackColor = Color.Pink;
            }

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                text += "-------- Please enter the name! \n";
                txtNom.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
            {
                throw new TypingException(text);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnImprimer_Click(object sender, EventArgs e)
        {
           
        }

        private void txtRecherch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifier_Click(sender, e);
        }

        private void FrmListeEtudiant_Load_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnImprimer_Click_1(object sender, EventArgs e)
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
                    p.Photo,
                    p.Matricule,
                    p.Nom,
                    p.PreNom,
                    DateTime.Parse(p.DateNais),
                    p.LieuNais,
                    p.Contact,
                    ecole?.EmailEcole



                    )
                );

            }
            Form f = new FrmPreview("EtudiantListe.rdlc", items);
            f.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisissez la photo";
            ofd.Filter = "Image File|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}

 

    

