namespace Nozel.Views
{
    partial class FicheEleve
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
            this.headPanel = new System.Windows.Forms.Panel();
            this.ficheEleveTitle = new System.Windows.Forms.Label();
            this.detailsStudentPanel = new System.Windows.Forms.Panel();
            this.labelNom = new System.Windows.Forms.Label();
            this.prenomData = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.nomData = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.sexeData = new System.Windows.Forms.Label();
            this.labelDateNaiss = new System.Windows.Forms.Label();
            this.dateNaissData = new System.Windows.Forms.Label();
            this.labelMatricule = new System.Windows.Forms.Label();
            this.matriculeData = new System.Windows.Forms.Label();
            this.labelClasse = new System.Windows.Forms.Label();
            this.classeData = new System.Windows.Forms.Label();
            this.labelDejaPayer = new System.Windows.Forms.Label();
            this.mtPayerData = new System.Windows.Forms.Label();
            this.labelReste = new System.Windows.Forms.Label();
            this.restePayerData = new System.Windows.Forms.Label();
            this.headPanel.SuspendLayout();
            this.detailsStudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.headPanel.Controls.Add(this.ficheEleveTitle);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1792, 71);
            this.headPanel.TabIndex = 0;
            // 
            // ficheEleveTitle
            // 
            this.ficheEleveTitle.AutoSize = true;
            this.ficheEleveTitle.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ficheEleveTitle.Location = new System.Drawing.Point(636, 9);
            this.ficheEleveTitle.Name = "ficheEleveTitle";
            this.ficheEleveTitle.Size = new System.Drawing.Size(341, 53);
            this.ficheEleveTitle.TabIndex = 1;
            this.ficheEleveTitle.Text = "FICHE ELEVE";
            // 
            // detailsStudentPanel
            // 
            this.detailsStudentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsStudentPanel.Controls.Add(this.restePayerData);
            this.detailsStudentPanel.Controls.Add(this.labelReste);
            this.detailsStudentPanel.Controls.Add(this.mtPayerData);
            this.detailsStudentPanel.Controls.Add(this.labelDejaPayer);
            this.detailsStudentPanel.Controls.Add(this.classeData);
            this.detailsStudentPanel.Controls.Add(this.labelClasse);
            this.detailsStudentPanel.Controls.Add(this.matriculeData);
            this.detailsStudentPanel.Controls.Add(this.labelMatricule);
            this.detailsStudentPanel.Controls.Add(this.dateNaissData);
            this.detailsStudentPanel.Controls.Add(this.labelDateNaiss);
            this.detailsStudentPanel.Controls.Add(this.sexeData);
            this.detailsStudentPanel.Controls.Add(this.labelSexe);
            this.detailsStudentPanel.Controls.Add(this.nomData);
            this.detailsStudentPanel.Controls.Add(this.labelPrenom);
            this.detailsStudentPanel.Controls.Add(this.prenomData);
            this.detailsStudentPanel.Controls.Add(this.labelNom);
            this.detailsStudentPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsStudentPanel.Location = new System.Drawing.Point(431, 206);
            this.detailsStudentPanel.Name = "detailsStudentPanel";
            this.detailsStudentPanel.Size = new System.Drawing.Size(647, 389);
            this.detailsStudentPanel.TabIndex = 2;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(13, 62);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(76, 26);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom : ";
            // 
            // prenomData
            // 
            this.prenomData.AutoSize = true;
            this.prenomData.Location = new System.Drawing.Point(122, 108);
            this.prenomData.Name = "prenomData";
            this.prenomData.Size = new System.Drawing.Size(28, 26);
            this.prenomData.TabIndex = 1;
            this.prenomData.Text = "la";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(13, 108);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(103, 26);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prénom : ";
            // 
            // nomData
            // 
            this.nomData.AutoSize = true;
            this.nomData.Location = new System.Drawing.Point(95, 62);
            this.nomData.Name = "nomData";
            this.nomData.Size = new System.Drawing.Size(67, 26);
            this.nomData.TabIndex = 3;
            this.nomData.Text = "label4";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(13, 150);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(74, 26);
            this.labelSexe.TabIndex = 4;
            this.labelSexe.Text = "Sexe : ";
            // 
            // sexeData
            // 
            this.sexeData.AutoSize = true;
            this.sexeData.Location = new System.Drawing.Point(93, 150);
            this.sexeData.Name = "sexeData";
            this.sexeData.Size = new System.Drawing.Size(67, 26);
            this.sexeData.TabIndex = 5;
            this.sexeData.Text = "label6";
            // 
            // labelDateNaiss
            // 
            this.labelDateNaiss.AutoSize = true;
            this.labelDateNaiss.Location = new System.Drawing.Point(13, 197);
            this.labelDateNaiss.Name = "labelDateNaiss";
            this.labelDateNaiss.Size = new System.Drawing.Size(164, 26);
            this.labelDateNaiss.TabIndex = 6;
            this.labelDateNaiss.Text = "DateNaissance : ";
            // 
            // dateNaissData
            // 
            this.dateNaissData.AutoSize = true;
            this.dateNaissData.Location = new System.Drawing.Point(183, 197);
            this.dateNaissData.Name = "dateNaissData";
            this.dateNaissData.Size = new System.Drawing.Size(67, 26);
            this.dateNaissData.TabIndex = 7;
            this.dateNaissData.Text = "label8";
            // 
            // labelMatricule
            // 
            this.labelMatricule.AutoSize = true;
            this.labelMatricule.Location = new System.Drawing.Point(13, 20);
            this.labelMatricule.Name = "labelMatricule";
            this.labelMatricule.Size = new System.Drawing.Size(117, 26);
            this.labelMatricule.TabIndex = 8;
            this.labelMatricule.Text = "Matricule : ";
            // 
            // matriculeData
            // 
            this.matriculeData.AutoSize = true;
            this.matriculeData.Location = new System.Drawing.Point(136, 20);
            this.matriculeData.Name = "matriculeData";
            this.matriculeData.Size = new System.Drawing.Size(60, 26);
            this.matriculeData.TabIndex = 9;
            this.matriculeData.Text = "matri";
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Location = new System.Drawing.Point(13, 243);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(89, 26);
            this.labelClasse.TabIndex = 10;
            this.labelClasse.Text = "Classe : ";
            // 
            // classeData
            // 
            this.classeData.AutoSize = true;
            this.classeData.Location = new System.Drawing.Point(108, 243);
            this.classeData.Name = "classeData";
            this.classeData.Size = new System.Drawing.Size(78, 26);
            this.classeData.TabIndex = 11;
            this.classeData.Text = "label12";
            // 
            // labelDejaPayer
            // 
            this.labelDejaPayer.AutoSize = true;
            this.labelDejaPayer.Location = new System.Drawing.Point(13, 289);
            this.labelDejaPayer.Name = "labelDejaPayer";
            this.labelDejaPayer.Size = new System.Drawing.Size(165, 26);
            this.labelDejaPayer.TabIndex = 12;
            this.labelDejaPayer.Text = "Montant Payer : ";
            // 
            // mtPayerData
            // 
            this.mtPayerData.AutoSize = true;
            this.mtPayerData.Location = new System.Drawing.Point(184, 289);
            this.mtPayerData.Name = "mtPayerData";
            this.mtPayerData.Size = new System.Drawing.Size(78, 26);
            this.mtPayerData.TabIndex = 13;
            this.mtPayerData.Text = "label14";
            // 
            // labelReste
            // 
            this.labelReste.AutoSize = true;
            this.labelReste.Location = new System.Drawing.Point(13, 333);
            this.labelReste.Name = "labelReste";
            this.labelReste.Size = new System.Drawing.Size(153, 26);
            this.labelReste.TabIndex = 14;
            this.labelReste.Text = "Reste à payer : ";
            // 
            // restePayerData
            // 
            this.restePayerData.AutoSize = true;
            this.restePayerData.Location = new System.Drawing.Point(172, 333);
            this.restePayerData.Name = "restePayerData";
            this.restePayerData.Size = new System.Drawing.Size(78, 26);
            this.restePayerData.TabIndex = 15;
            this.restePayerData.Text = "label16";
            // 
            // FicheEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1792, 785);
            this.Controls.Add(this.detailsStudentPanel);
            this.Controls.Add(this.headPanel);
            this.Name = "FicheEleve";
            this.Text = "FicheEleve";
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.detailsStudentPanel.ResumeLayout(false);
            this.detailsStudentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label ficheEleveTitle;
        private System.Windows.Forms.Panel detailsStudentPanel;
        private System.Windows.Forms.Label restePayerData;
        private System.Windows.Forms.Label labelReste;
        private System.Windows.Forms.Label mtPayerData;
        private System.Windows.Forms.Label labelDejaPayer;
        private System.Windows.Forms.Label classeData;
        private System.Windows.Forms.Label labelClasse;
        private System.Windows.Forms.Label matriculeData;
        private System.Windows.Forms.Label labelMatricule;
        private System.Windows.Forms.Label dateNaissData;
        private System.Windows.Forms.Label labelDateNaiss;
        private System.Windows.Forms.Label sexeData;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label nomData;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label prenomData;
        private System.Windows.Forms.Label labelNom;
    }
}