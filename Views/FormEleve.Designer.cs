namespace Nozel.Views
{
    partial class FormEleve
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
            this.label1 = new System.Windows.Forms.Label();
            this.enregistrerBtn = new System.Windows.Forms.Button();
            this.annulerBtn = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.adresse = new System.Windows.Forms.TextBox();
            this.contactTuteur = new System.Windows.Forms.TextBox();
            this.nomTuteur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNaiss = new System.Windows.Forms.DateTimePicker();
            this.sexe = new System.Windows.Forms.CheckedListBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.classe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateNaiss_label = new System.Windows.Forms.Label();
            this.sexe_label = new System.Windows.Forms.Label();
            this.prenom_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.headEleve_panel = new System.Windows.Forms.Panel();
            this.backEleveBtn = new System.Windows.Forms.Button();
            this.formPanel.SuspendLayout();
            this.headEleve_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DES ELEVES";
            // 
            // enregistrerBtn
            // 
            this.enregistrerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(46)))));
            this.enregistrerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerBtn.ForeColor = System.Drawing.Color.White;
            this.enregistrerBtn.Location = new System.Drawing.Point(580, 700);
            this.enregistrerBtn.Name = "enregistrerBtn";
            this.enregistrerBtn.Size = new System.Drawing.Size(225, 48);
            this.enregistrerBtn.TabIndex = 2;
            this.enregistrerBtn.Text = "ENREGISTRER";
            this.enregistrerBtn.UseVisualStyleBackColor = false;
            this.enregistrerBtn.Click += new System.EventHandler(this.enregistrerBtn_Click);
            // 
            // annulerBtn
            // 
            this.annulerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.annulerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.annulerBtn.Location = new System.Drawing.Point(257, 700);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(169, 48);
            this.annulerBtn.TabIndex = 3;
            this.annulerBtn.Text = "ANNULER";
            this.annulerBtn.UseVisualStyleBackColor = false;
            this.annulerBtn.Click += new System.EventHandler(this.annulerBtn_Click);
            // 
            // formPanel
            // 
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formPanel.Controls.Add(this.adresse);
            this.formPanel.Controls.Add(this.contactTuteur);
            this.formPanel.Controls.Add(this.nomTuteur);
            this.formPanel.Controls.Add(this.label4);
            this.formPanel.Controls.Add(this.label3);
            this.formPanel.Controls.Add(this.label2);
            this.formPanel.Controls.Add(this.dateNaiss);
            this.formPanel.Controls.Add(this.sexe);
            this.formPanel.Controls.Add(this.prenom);
            this.formPanel.Controls.Add(this.nom);
            this.formPanel.Controls.Add(this.classe);
            this.formPanel.Controls.Add(this.annulerBtn);
            this.formPanel.Controls.Add(this.enregistrerBtn);
            this.formPanel.Controls.Add(this.label7);
            this.formPanel.Controls.Add(this.dateNaiss_label);
            this.formPanel.Controls.Add(this.sexe_label);
            this.formPanel.Controls.Add(this.prenom_label);
            this.formPanel.Controls.Add(this.nom_label);
            this.formPanel.Location = new System.Drawing.Point(518, 141);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(866, 785);
            this.formPanel.TabIndex = 4;
            // 
            // adresse
            // 
            this.adresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.adresse.Location = new System.Drawing.Point(257, 532);
            this.adresse.Multiline = true;
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(548, 75);
            this.adresse.TabIndex = 19;
            // 
            // contactTuteur
            // 
            this.contactTuteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.contactTuteur.Location = new System.Drawing.Point(257, 438);
            this.contactTuteur.Multiline = true;
            this.contactTuteur.Name = "contactTuteur";
            this.contactTuteur.Size = new System.Drawing.Size(548, 40);
            this.contactTuteur.TabIndex = 18;
            // 
            // nomTuteur
            // 
            this.nomTuteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.nomTuteur.Location = new System.Drawing.Point(257, 369);
            this.nomTuteur.Multiline = true;
            this.nomTuteur.Name = "nomTuteur";
            this.nomTuteur.Size = new System.Drawing.Size(548, 36);
            this.nomTuteur.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contact du Tuteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom du Tuteur";
            // 
            // dateNaiss
            // 
            this.dateNaiss.Location = new System.Drawing.Point(257, 242);
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.Size = new System.Drawing.Size(401, 22);
            this.dateNaiss.TabIndex = 13;
            // 
            // sexe
            // 
            this.sexe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.sexe.FormattingEnabled = true;
            this.sexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.sexe.Location = new System.Drawing.Point(257, 173);
            this.sexe.MultiColumn = true;
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(341, 38);
            this.sexe.TabIndex = 12;
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.prenom.Location = new System.Drawing.Point(257, 100);
            this.prenom.Multiline = true;
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(548, 36);
            this.prenom.TabIndex = 8;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.nom.Location = new System.Drawing.Point(257, 35);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(548, 36);
            this.nom.TabIndex = 7;
            // 
            // classe
            // 
            this.classe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.classe.FormattingEnabled = true;
            this.classe.Location = new System.Drawing.Point(257, 309);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(330, 24);
            this.classe.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "CLASSE";
            // 
            // dateNaiss_label
            // 
            this.dateNaiss_label.AutoSize = true;
            this.dateNaiss_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNaiss_label.Location = new System.Drawing.Point(18, 242);
            this.dateNaiss_label.Name = "dateNaiss_label";
            this.dateNaiss_label.Size = new System.Drawing.Size(165, 25);
            this.dateNaiss_label.TabIndex = 4;
            this.dateNaiss_label.Text = "Date Naissance";
            // 
            // sexe_label
            // 
            this.sexe_label.AutoSize = true;
            this.sexe_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe_label.Location = new System.Drawing.Point(113, 173);
            this.sexe_label.Name = "sexe_label";
            this.sexe_label.Size = new System.Drawing.Size(70, 25);
            this.sexe_label.TabIndex = 3;
            this.sexe_label.Text = "SEXE";
            // 
            // prenom_label
            // 
            this.prenom_label.AutoSize = true;
            this.prenom_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label.Location = new System.Drawing.Point(66, 96);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(117, 25);
            this.prenom_label.TabIndex = 2;
            this.prenom_label.Text = "PRENOM";
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(113, 35);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(70, 25);
            this.nom_label.TabIndex = 1;
            this.nom_label.Text = "NOM";
            // 
            // headEleve_panel
            // 
            this.headEleve_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.headEleve_panel.Controls.Add(this.label1);
            this.headEleve_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headEleve_panel.Location = new System.Drawing.Point(0, 0);
            this.headEleve_panel.Name = "headEleve_panel";
            this.headEleve_panel.Size = new System.Drawing.Size(1799, 75);
            this.headEleve_panel.TabIndex = 6;
            // 
            // backEleveBtn
            // 
            this.backEleveBtn.Location = new System.Drawing.Point(273, 107);
            this.backEleveBtn.Name = "backEleveBtn";
            this.backEleveBtn.Size = new System.Drawing.Size(97, 37);
            this.backEleveBtn.TabIndex = 7;
            this.backEleveBtn.Text = "Back";
            this.backEleveBtn.UseVisualStyleBackColor = true;
            this.backEleveBtn.Click += new System.EventHandler(this.backEleveBtn_Click);
            // 
            // FormEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1799, 988);
            this.Controls.Add(this.backEleveBtn);
            this.Controls.Add(this.headEleve_panel);
            this.Controls.Add(this.formPanel);
            this.Name = "FormEleve";
            this.Text = "FormEleve";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.headEleve_panel.ResumeLayout(false);
            this.headEleve_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enregistrerBtn;
        private System.Windows.Forms.Button annulerBtn;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label sexe_label;
        private System.Windows.Forms.Label prenom_label;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateNaiss_label;
        private System.Windows.Forms.ComboBox classe;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.CheckedListBox sexe;
        private System.Windows.Forms.DateTimePicker dateNaiss;
        private System.Windows.Forms.Panel headEleve_panel;
        private System.Windows.Forms.Button backEleveBtn;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox contactTuteur;
        private System.Windows.Forms.TextBox nomTuteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}