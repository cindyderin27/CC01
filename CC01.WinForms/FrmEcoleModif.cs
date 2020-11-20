using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmEcoleModif : Form
    {

        private EcoleBLO ecoleBLO;
        private Ecole oldEcole;
        public FrmEcoleModif()
        {
            InitializeComponent();
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
            oldEcole = ecoleBLO.GetEcole();
            if (oldEcole!= null)
            {
                txtEmail.Text = oldEcole.EmailEcole;
                txtNom.Text = oldEcole.NomEcole;
                txtTel.Text = oldEcole.ContactEcole.ToString();
                pictureBox1.ImageLocation = oldEcole.Logo;
            }
        }
        private void  lblNom_Click(object sender, EventArgs e)
        {

        }

        private void FrmEcoleModif_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                Ecole newEcole = new Ecole
                (
                    txtNom.Text.ToUpper(),
                    txtEmail.Text,
                    long.Parse(txtTel.Text),
                    pictureBox1.ImageLocation
                );

                ecoleBLO.CreateEcole(oldEcole, newEcole);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Close();


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
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
        private void checkForm()
        {
            string text = string.Empty;
            txtNom.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            if (!long.TryParse(txtTel.Text, out _))
            {
                text += "- Please enter a good phone number ! \n";
                txtNom.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                text += "- Please enter the name ! \n";
                txtEmail.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
