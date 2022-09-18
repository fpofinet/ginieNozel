namespace Nozel.Views
{
    partial class Recu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recu));
            this.headPanel = new System.Windows.Forms.Panel();
            this.ficheEleveTitle = new System.Windows.Forms.Label();
            this.detailsStudentPanel = new System.Windows.Forms.Panel();
            this.restePayerData = new System.Windows.Forms.Label();
            this.labelReste = new System.Windows.Forms.Label();
            this.mtPayerData = new System.Windows.Forms.Label();
            this.labelDejaPayer = new System.Windows.Forms.Label();
            this.classeData = new System.Windows.Forms.Label();
            this.labelClasse = new System.Windows.Forms.Label();
            this.matriculeData = new System.Windows.Forms.Label();
            this.labelMatricule = new System.Windows.Forms.Label();
            this.dateNaissData = new System.Windows.Forms.Label();
            this.labelDateNaiss = new System.Windows.Forms.Label();
            this.sexeData = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.nomData = new System.Windows.Forms.Label();
            this.labelSomme = new System.Windows.Forms.Label();
            this.montantData = new System.Windows.Forms.Label();
            this.labelNomPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.headPanel.SuspendLayout();
            this.detailsStudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.headPanel.Controls.Add(this.ficheEleveTitle);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.detailsStudentPanel.Controls.Add(this.label1);
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
            this.detailsStudentPanel.Controls.Add(this.labelSomme);
            this.detailsStudentPanel.Controls.Add(this.montantData);
            this.detailsStudentPanel.Controls.Add(this.labelNomPrenom);
            this.detailsStudentPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsStudentPanel.Location = new System.Drawing.Point(431, 211);
            this.detailsStudentPanel.Name = "detailsStudentPanel";
            this.detailsStudentPanel.Size = new System.Drawing.Size(647, 450);
            this.detailsStudentPanel.TabIndex = 2;
            // 
            // restePayerData
            // 
            this.restePayerData.AutoSize = true;
            this.restePayerData.Location = new System.Drawing.Point(169, 337);
            this.restePayerData.Name = "restePayerData";
            this.restePayerData.Size = new System.Drawing.Size(78, 26);
            this.restePayerData.TabIndex = 15;
            this.restePayerData.Text = "label16";
            // 
            // labelReste
            // 
            this.labelReste.AutoSize = true;
            this.labelReste.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReste.Location = new System.Drawing.Point(13, 337);
            this.labelReste.Name = "labelReste";
            this.labelReste.Size = new System.Drawing.Size(166, 25);
            this.labelReste.TabIndex = 14;
            this.labelReste.Text = "Total Restant : ";
            // 
            // mtPayerData
            // 
            this.mtPayerData.AutoSize = true;
            this.mtPayerData.Location = new System.Drawing.Point(153, 287);
            this.mtPayerData.Name = "mtPayerData";
            this.mtPayerData.Size = new System.Drawing.Size(78, 26);
            this.mtPayerData.TabIndex = 13;
            this.mtPayerData.Text = "label14";
            // 
            // labelDejaPayer
            // 
            this.labelDejaPayer.AutoSize = true;
            this.labelDejaPayer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDejaPayer.Location = new System.Drawing.Point(13, 287);
            this.labelDejaPayer.Name = "labelDejaPayer";
            this.labelDejaPayer.Size = new System.Drawing.Size(147, 25);
            this.labelDejaPayer.TabIndex = 12;
            this.labelDejaPayer.Text = "Total Payer : ";
            // 
            // classeData
            // 
            this.classeData.AutoSize = true;
            this.classeData.Location = new System.Drawing.Point(108, 193);
            this.classeData.Name = "classeData";
            this.classeData.Size = new System.Drawing.Size(78, 26);
            this.classeData.TabIndex = 11;
            this.classeData.Text = "label12";
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasse.Location = new System.Drawing.Point(13, 193);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(95, 25);
            this.labelClasse.TabIndex = 10;
            this.labelClasse.Text = "Classe : ";
            // 
            // matriculeData
            // 
            this.matriculeData.AutoSize = true;
            this.matriculeData.Location = new System.Drawing.Point(136, 54);
            this.matriculeData.Name = "matriculeData";
            this.matriculeData.Size = new System.Drawing.Size(60, 26);
            this.matriculeData.TabIndex = 9;
            this.matriculeData.Text = "matri";
            // 
            // labelMatricule
            // 
            this.labelMatricule.AutoSize = true;
            this.labelMatricule.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricule.Location = new System.Drawing.Point(13, 54);
            this.labelMatricule.Name = "labelMatricule";
            this.labelMatricule.Size = new System.Drawing.Size(130, 25);
            this.labelMatricule.TabIndex = 8;
            this.labelMatricule.Text = "Matricule : ";
            // 
            // dateNaissData
            // 
            this.dateNaissData.AutoSize = true;
            this.dateNaissData.Location = new System.Drawing.Point(91, 381);
            this.dateNaissData.Name = "dateNaissData";
            this.dateNaissData.Size = new System.Drawing.Size(67, 26);
            this.dateNaissData.TabIndex = 7;
            this.dateNaissData.Text = "label8";
            // 
            // labelDateNaiss
            // 
            this.labelDateNaiss.AutoSize = true;
            this.labelDateNaiss.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateNaiss.Location = new System.Drawing.Point(13, 381);
            this.labelDateNaiss.Name = "labelDateNaiss";
            this.labelDateNaiss.Size = new System.Drawing.Size(80, 25);
            this.labelDateNaiss.TabIndex = 6;
            this.labelDateNaiss.Text = "Date : ";
            // 
            // sexeData
            // 
            this.sexeData.AutoSize = true;
            this.sexeData.Location = new System.Drawing.Point(93, 147);
            this.sexeData.Name = "sexeData";
            this.sexeData.Size = new System.Drawing.Size(67, 26);
            this.sexeData.TabIndex = 5;
            this.sexeData.Text = "label6";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexe.Location = new System.Drawing.Point(13, 147);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(78, 25);
            this.labelSexe.TabIndex = 4;
            this.labelSexe.Text = "Sexe : ";
            // 
            // nomData
            // 
            this.nomData.AutoSize = true;
            this.nomData.Location = new System.Drawing.Point(204, 100);
            this.nomData.Name = "nomData";
            this.nomData.Size = new System.Drawing.Size(67, 26);
            this.nomData.TabIndex = 3;
            this.nomData.Text = "label4";
            // 
            // labelSomme
            // 
            this.labelSomme.AutoSize = true;
            this.labelSomme.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSomme.Location = new System.Drawing.Point(13, 239);
            this.labelSomme.Name = "labelSomme";
            this.labelSomme.Size = new System.Drawing.Size(121, 25);
            this.labelSomme.TabIndex = 2;
            this.labelSomme.Text = "Montant : ";
            // 
            // montantData
            // 
            this.montantData.AutoSize = true;
            this.montantData.Location = new System.Drawing.Point(140, 238);
            this.montantData.Name = "montantData";
            this.montantData.Size = new System.Drawing.Size(28, 26);
            this.montantData.TabIndex = 1;
            this.montantData.Text = "la";
            // 
            // labelNomPrenom
            // 
            this.labelNomPrenom.AutoSize = true;
            this.labelNomPrenom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPrenom.Location = new System.Drawing.Point(13, 101);
            this.labelNomPrenom.Name = "labelNomPrenom";
            this.labelNomPrenom.Size = new System.Drawing.Size(185, 25);
            this.labelNomPrenom.TabIndex = 0;
            this.labelNomPrenom.Text = "Nom et Prenom: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reçu Payement ";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Location = new System.Drawing.Point(936, 160);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(142, 45);
            this.PrintBtn.TabIndex = 4;
            this.PrintBtn.Text = "Imprimer";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Recu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1792, 785);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.detailsStudentPanel);
            this.Controls.Add(this.headPanel);
            this.Name = "Recu";
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
        private System.Windows.Forms.Label labelSomme;
        private System.Windows.Forms.Label montantData;
        private System.Windows.Forms.Label labelNomPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}