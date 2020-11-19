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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnulerEcole
            // 
            this.btnAnnulerEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerEcole.Location = new System.Drawing.Point(883, 437);
            this.btnAnnulerEcole.Name = "btnAnnulerEcole";
            this.btnAnnulerEcole.Size = new System.Drawing.Size(92, 31);
            this.btnAnnulerEcole.TabIndex = 15;
            this.btnAnnulerEcole.Text = "Annuler";
            this.btnAnnulerEcole.UseVisualStyleBackColor = true;
            // 
            // btnImprimerEcole
            // 
            this.btnImprimerEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerEcole.Location = new System.Drawing.Point(883, 213);
            this.btnImprimerEcole.Name = "btnImprimerEcole";
            this.btnImprimerEcole.Size = new System.Drawing.Size(92, 31);
            this.btnImprimerEcole.TabIndex = 14;
            this.btnImprimerEcole.Text = "Imprimer";
            this.btnImprimerEcole.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerEcole
            // 
            this.btnSupprimerEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerEcole.Location = new System.Drawing.Point(883, 157);
            this.btnSupprimerEcole.Name = "btnSupprimerEcole";
            this.btnSupprimerEcole.Size = new System.Drawing.Size(92, 31);
            this.btnSupprimerEcole.TabIndex = 13;
            this.btnSupprimerEcole.Text = "Supprimer";
            this.btnSupprimerEcole.UseVisualStyleBackColor = true;
            // 
            // btnModifierEcole
            // 
            this.btnModifierEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierEcole.Location = new System.Drawing.Point(883, 98);
            this.btnModifierEcole.Name = "btnModifierEcole";
            this.btnModifierEcole.Size = new System.Drawing.Size(92, 31);
            this.btnModifierEcole.TabIndex = 12;
            this.btnModifierEcole.Text = "Modifier";
            this.btnModifierEcole.UseVisualStyleBackColor = true;
            // 
            // btnCreerEcole
            // 
            this.btnCreerEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerEcole.Location = new System.Drawing.Point(883, 50);
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
            this.dataGridView2.Location = new System.Drawing.Point(27, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(800, 418);
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
            this.txtRecherchEcole.Location = new System.Drawing.Point(135, 24);
            this.txtRecherchEcole.Name = "txtRecherchEcole";
            this.txtRecherchEcole.Size = new System.Drawing.Size(692, 20);
            this.txtRecherchEcole.TabIndex = 9;
            // 
            // lblRecherchEcole
            // 
            this.lblRecherchEcole.AutoSize = true;
            this.lblRecherchEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherchEcole.Location = new System.Drawing.Point(24, 25);
            this.lblRecherchEcole.Name = "lblRecherchEcole";
            this.lblRecherchEcole.Size = new System.Drawing.Size(88, 16);
            this.lblRecherchEcole.TabIndex = 8;
            this.lblRecherchEcole.Text = "Rechercher";
            // 
            // FrmListeEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1010, 495);
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
    }
}