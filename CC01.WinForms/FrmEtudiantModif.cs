using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmEtudiantModif : Form
    {
        private Action callBack;
        private Etudiant oldEtudiant;
        public FrmEtudiantModif()
        {
            InitializeComponent();
        }
        public FrmEtudiantModif(Action callBack):this()
        {
            this.callBack = callBack;
        }
      public FrmEtudiantModif(Etudiant etudiant, Action callBack) : this(callBack)
        {
            this.oldEtudiant = etudiant;
            txtMatricule.Text = etudiant.Matricule;
            txtNom.Text = etudiant.Nom;
            txtPrenom.Text = etudiant.PreNom;
            dateTimePicker1.Text = etudiant.DateNais.ToString();
            txtLieu.Text = etudiant.LieuNais;
            txtContact.Text = etudiant.Contact.ToString();
            if (etudiant.Photo != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])etudiant.Photo));
            }

            EtudiantBLO productBLO = new ProductBLO(ConfigurationManager.AppSettings["DbFolder"]);

            if (this.oldProduct == null)
                productBLO.CreateProduct(newProduct);
            else
                productBLO.EditProduct(oldProduct, newProduct);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblMatricule_Click(object sender, EventArgs e)
        {

        }

        private void txtLieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                Etudiant newEtudiant = new Etudiant
                (
                txtMatricule.Text,
                txtNom.Text,
                txtPrenom.Text,
                dateTimePicker1.Text,
                txtLieu.Text,
                long.Parse(txtContact.Text),
                 !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEtudiant?.Photo
                );
                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldEtudiant!= null)
                    Close();

                txtMatricule.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                txtContact.Clear();
                txtEmail.Clear();
                txtLieu.Clear();
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
               // ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
