namespace CC01.WinForms
{
    partial class FrmListeEcole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelPhoto = new System.Windows.Forms.LinkLabel();
            this.txtRecherchEcole = new System.Windows.Forms.TextBox();
            this.dataGridViewEcole = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtContactEcole = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailEcole = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtNomEcole = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEcole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGO";
            // 
            // linkLabelPhoto
            // 
            this.linkLabelPhoto.AutoSize = true;
            this.linkLabelPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPhoto.LinkColor = System.Drawing.Color.Red;
            this.linkLabelPhoto.Location = new System.Drawing.Point(165, 35);
            this.linkLabelPhoto.Name = "linkLabelPhoto";
            this.linkLabelPhoto.Size = new System.Drawing.Size(17, 16);
            this.linkLabelPhoto.TabIndex = 2;
            this.linkLabelPhoto.TabStop = true;
            this.linkLabelPhoto.Text = "X";
            // 
            // txtRecherchEcole
            // 
            this.txtRecherchEcole.Location = new System.Drawing.Point(630, 46);
            this.txtRecherchEcole.Name = "txtRecherchEcole";
            this.txtRecherchEcole.Size = new System.Drawing.Size(441, 20);
            this.txtRecherchEcole.TabIndex = 3;
            this.txtRecherchEcole.TextChanged += new System.EventHandler(this.txtRecherchEcole_TextChanged);
            // 
            // dataGridViewEcole
            // 
            this.dataGridViewEcole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEcole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewEcole.Location = new System.Drawing.Point(630, 72);
            this.dataGridViewEcole.Name = "dataGridViewEcole";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewEcole.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEcole.Size = new System.Drawing.Size(441, 353);
            this.dataGridViewEcole.TabIndex = 4;
            this.dataGridViewEcole.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEcole_CellDoubleClick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Location = new System.Drawing.Point(29, 54);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(153, 161);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(286, 363);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(92, 31);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(54, 363);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(92, 31);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(1096, 305);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(92, 31);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(1096, 124);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(92, 31);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtContactEcole
            // 
            this.txtContactEcole.Location = new System.Drawing.Point(277, 211);
            this.txtContactEcole.Name = "txtContactEcole";
            this.txtContactEcole.Size = new System.Drawing.Size(261, 20);
            this.txtContactEcole.TabIndex = 37;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(214, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email";
            // 
            // txtEmailEcole
            // 
            this.txtEmailEcole.Location = new System.Drawing.Point(277, 164);
            this.txtEmailEcole.Name = "txtEmailEcole";
            this.txtEmailEcole.Size = new System.Drawing.Size(261, 20);
            this.txtEmailEcole.TabIndex = 36;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(207, 212);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 16);
            this.lblContact.TabIndex = 39;
            this.lblContact.Text = "Contact";
            // 
            // txtNomEcole
            // 
            this.txtNomEcole.Location = new System.Drawing.Point(277, 72);
            this.txtNomEcole.Name = "txtNomEcole";
            this.txtNomEcole.Size = new System.Drawing.Size(261, 20);
            this.txtNomEcole.TabIndex = 35;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(214, 76);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 16);
            this.lblNom.TabIndex = 38;
            this.lblNom.Text = "Nom";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Rechercher";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Logo";
            this.Column1.HeaderText = "Logo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NomEcole";
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EmailEcole";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ContactEcole";
            this.Column4.HeaderText = "Contact";
            this.Column4.Name = "Column4";
            // 
            // FrmListeEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1215, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContactEcole);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmailEcole);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtNomEcole);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.dataGridViewEcole);
            this.Controls.Add(this.txtRecherchEcole);
            this.Controls.Add(this.linkLabelPhoto);
            this.Controls.Add(this.label1);
            this.Name = "FrmListeEcole";
            this.Text = "FrmListeEcole";
            this.Load += new System.EventHandler(this.FrmListeEcole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEcole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelPhoto;
        private System.Windows.Forms.TextBox txtRecherchEcole;
        private System.Windows.Forms.DataGridView dataGridViewEcole;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtContactEcole;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailEcole;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtNomEcole;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}