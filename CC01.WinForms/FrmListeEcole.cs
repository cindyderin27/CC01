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
    public partial class FrmListeEcole : Form
    {
        private Action callback;
        private EcoleBLO ecoleBLO;
        private Ecole oldEco;
        public FrmListeEcole()
        {
            InitializeComponent();
            dataGridViewEcole.AutoGenerateColumns = false;
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
            
        }
        public FrmListeEcole(Action callback) : this()
        {
            this.callback = callback;
        }
        
        public FrmListeEcole(Ecole ecole, Action callback) : this(callback)
        {
            this.oldEco = ecole;
            txtNomEcole.Text = ecole.NomEcole;
            txtEmailEcole.Text = ecole.EmailEcole;
            txtContactEcole.Text = ecole.ContactEcole.ToString();
            pictureBoxLogo.Image = ecole.Logo != null ? Image.FromStream(new MemoryStream(ecole.Logo)) : null;
        }
        private void FrmListeEcole_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisissez le logo";
            ofd.Filter = "Image File|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.ImageLocation = ofd.FileName;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForm();

                Ecole newEco = new Ecole(
                    !String.IsNullOrEmpty(pictureBoxLogo.ImageLocation) ? File.ReadAllBytes(pictureBoxLogo.ImageLocation) : this.oldEco?.Logo,
                    txtNomEcole.Text.ToUpper(),
                     long.Parse(txtContactEcole.Text),
                    txtEmailEcole.Text
                    );

                EcoleBLO ecoBlo = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
                if (this.oldEco == null)
                {
                    ecoBlo.CreateEcole(newEco);
                }
                else
                {
                    ecoBlo.EditEcole(oldEco, newEco);
                }
                ecoBlo.CreateEcole(newEco);
                MessageBox.Show(
                    "Enregistrement éffectué !",
                     "Confirmé",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                    );
                if (callback != null)
                    callback();

                if (oldEco != null)
                    Close();
                txtNomEcole.Clear();
                txtEmailEcole.Clear();
                txtContactEcole.Clear();
                txtNomEcole.Focus();
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
        }
        private void loadData()
        {
            string value = txtRecherchEcole.Text.ToLower();
            var ecoles = ecoleBLO.GetBy
            (
                x =>
                x.NomEcole.ToLower().Contains(value)
            ).OrderBy(x => x.NomEcole).ToArray();
            dataGridViewEcole.DataSource = null;
            dataGridViewEcole.DataSource = ecoles;
            //lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridViewEcole.ClearSelection();
        }
        private void CheckForm()
        {
            string text = string.Empty;
            txtNomEcole.BackColor = Color.White;
            txtNomEcole.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtNomEcole.Text))
            {
                text += "-------------Please enter the school name!\n";
                txtNomEcole.BackColor = Color.Pink;
            }

            if (string.IsNullOrWhiteSpace(txtContactEcole.Text))
            {
                text += "-------- Please enter the name! \n";
                txtContactEcole.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
            {
                throw new TypingException(text);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewEcole.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridViewEcole.SelectedRows.Count; i++)
                {
                    Form f = new FrmListeEcole
                        (
                            dataGridViewEcole.SelectedRows[i].DataBoundItem as Ecole,
                            loadData
                        );
                    this.Hide();
                    f.Show();
                    f.WindowState = FormWindowState.Maximized;
                }

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewEcole.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this student(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridViewEcole.SelectedRows.Count; i++)
                    {
                        ecoleBLO.DeleteEcole(dataGridViewEcole.SelectedRows[i].DataBoundItem as Ecole);
                    }
                    loadData();
                }
            }
        }

        private void txtRecherchEcole_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridViewEcole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifier_Click(sender, e);
        }
    }

}
