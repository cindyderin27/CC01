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
            this.btnAnnulerEcole = new System.Windows.Forms.Button();
            this.btnImprimerEcole = new System.Windows.Forms.Button();
            this.btnSupprimerEcole = new System.Windows.Forms.Button();
            this.btnModifierEcole = new System.Windows.Forms.Button();
            this.btnCreerEcole = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRecherchEcole = new System.Windows.Forms.TextBox();
            this.lblRecherchEcole = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnulerEcole
            // 
            this.btnAnnulerEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerEcole.Location = new System.Drawing.Point(1115, 442);
            this.btnAnnulerEcole.Name = "btnAnnulerEcole";
            this.btnAnnulerEcole.Size = new System.Drawing.Size(92, 31);
            this.btnAnnulerEcole.TabIndex = 15;
            this.btnAnnulerEcole.Text = "Annuler";
            this.btnAnnulerEcole.UseVisualStyleBackColor = true;
            // 
            // btnImprimerEcole
            // 
            this.btnImprimerEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerEcole.Location = new System.Drawing.Point(1115, 218);
            this.btnImprimerEcole.Name = "btnImprimerEcole";
            this.btnImprimerEcole.Size = new System.Drawing.Size(92, 31);
            this.btnImprimerEcole.TabIndex = 14;
            this.btnImprimerEcole.Text = "Imprimer";
            this.btnImprimerEcole.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerEcole
            // 
            this.btnSupprimerEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerEcole.Location = new System.Drawing.Point(1115, 162);
            this.btnSupprimerEcole.Name = "btnSupprimerEcole";
            this.btnSupprimerEcole.Size = new System.Drawing.Size(92, 31);
            this.btnSupprimerEcole.TabIndex = 13;
            this.btnSupprimerEcole.Text = "Supprimer";
            this.btnSupprimerEcole.UseVisualStyleBackColor = true;
            // 
            // btnModifierEcole
            // 
            this.btnModifierEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierEcole.Location = new System.Drawing.Point(1115, 103);
            this.btnModifierEcole.Name = "btnModifierEcole";
            this.btnModifierEcole.Size = new System.Drawing.Size(92, 31);
            this.btnModifierEcole.TabIndex = 12;
            this.btnModifierEcole.Text = "Modifier";
            this.btnModifierEcole.UseVisualStyleBackColor = true;
            // 
            // btnCreerEcole
            // 
            this.btnCreerEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerEcole.Location = new System.Drawing.Point(1115, 55);
            this.btnCreerEcole.Name = "btnCreerEcole";
            this.btnCreerEcole.Size = new System.Drawing.Size(92, 31);
            this.btnCreerEcole.TabIndex = 11;
            this.btnCreerEcole.Text = "Créer";
            this.btnCreerEcole.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView2.Location = new System.Drawing.Point(525, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(547, 418);
            this.dataGridView2.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prenom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Matricule";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Contact";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DateNais";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Lieu";
            this.Column7.Name = "Column7";
            // 
            // txtRecherchEcole
            // 
            this.txtRecherchEcole.Location = new System.Drawing.Point(525, 39);
            this.txtRecherchEcole.Name = "txtRecherchEcole";
            this.txtRecherchEcole.Size = new System.Drawing.Size(547, 20);
            this.txtRecherchEcole.TabIndex = 9;
            // 
            // lblRecherchEcole
            // 
            this.lblRecherchEcole.AutoSize = true;
            this.lblRecherchEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherchEcole.Location = new System.Drawing.Point(522, 20);
            this.lblRecherchEcole.Name = "lblRecherchEcole";
            this.lblRecherchEcole.Size = new System.Drawing.Size(88, 16);
            this.lblRecherchEcole.TabIndex = 8;
            this.lblRecherchEcole.Text = "Rechercher";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(12, 130);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(260, 20);
            this.txtTel.TabIndex = 19;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(9, 111);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(31, 16);
            this.lblTel.TabIndex = 18;
            this.lblTel.Text = "Tel";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(260, 20);
            this.txtNom.TabIndex = 17;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(9, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 16);
            this.lblNom.TabIndex = 16;
            this.lblNom.Text = "Nom";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(444, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(17, 16);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(287, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(43, 16);
            this.lblLogo.TabIndex = 25;
            this.lblLogo.Text = "Logo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(290, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Cliquez ici...";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(355, 386);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(109, 43);
            this.btnAnnuler.TabIndex = 23;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Green;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(48, 386);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(109, 43);
            this.btnEnregistrer.TabIndex = 22;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FrmListeEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1242, 495);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnAnnulerEcole);
            this.Controls.Add(this.btnImprimerEcole);
            this.Controls.Add(this.btnSupprimerEcole);
            this.Controls.Add(this.btnModifierEcole);
            this.Controls.Add(this.btnCreerEcole);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtRecherchEcole);
            this.Controls.Add(this.lblRecherchEcole);
            this.Name = "FrmListeEcole";
            this.Text = "FrmListeEcole";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulerEcole;
        private System.Windows.Forms.Button btnImprimerEcole;
        private System.Windows.Forms.Button btnSupprimerEcole;
        private System.Windows.Forms.Button btnModifierEcole;
        private System.Windows.Forms.Button btnCreerEcole;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtRecherchEcole;
        private System.Windows.Forms.Label lblRecherchEcole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}