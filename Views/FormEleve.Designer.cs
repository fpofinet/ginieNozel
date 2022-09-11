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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.enregistrerBtn = new System.Windows.Forms.Button();
            this.annulerBtn = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.dateNaiss = new System.Windows.Forms.DateTimePicker();
            this.sexe = new System.Windows.Forms.CheckedListBox();
            this.classe = new System.Windows.Forms.ComboBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.matricule = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateNaiss_label = new System.Windows.Forms.Label();
            this.sexe_label = new System.Windows.Forms.Label();
            this.prenom_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.matricule_label = new System.Windows.Forms.Label();
            this.eleveDataGrid = new System.Windows.Forms.DataGridView();
            this.IdD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClasseD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headEleve_panel = new System.Windows.Forms.Panel();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleveDataGrid)).BeginInit();
            this.headEleve_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.enregistrerBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.enregistrerBtn.Location = new System.Drawing.Point(296, 325);
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
            this.annulerBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.annulerBtn.Location = new System.Drawing.Point(48, 325);
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
            this.formPanel.Controls.Add(this.dateNaiss);
            this.formPanel.Controls.Add(this.sexe);
            this.formPanel.Controls.Add(this.classe);
            this.formPanel.Controls.Add(this.annulerBtn);
            this.formPanel.Controls.Add(this.enregistrerBtn);
            this.formPanel.Controls.Add(this.prenom);
            this.formPanel.Controls.Add(this.nom);
            this.formPanel.Controls.Add(this.matricule);
            this.formPanel.Controls.Add(this.label7);
            this.formPanel.Controls.Add(this.dateNaiss_label);
            this.formPanel.Controls.Add(this.sexe_label);
            this.formPanel.Controls.Add(this.prenom_label);
            this.formPanel.Controls.Add(this.nom_label);
            this.formPanel.Controls.Add(this.matricule_label);
            this.formPanel.Location = new System.Drawing.Point(12, 100);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(541, 409);
            this.formPanel.TabIndex = 4;
            // 
            // dateNaiss
            // 
            this.dateNaiss.Location = new System.Drawing.Point(191, 213);
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.Size = new System.Drawing.Size(330, 22);
            this.dateNaiss.TabIndex = 13;
            // 
            // sexe
            // 
            this.sexe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.sexe.FormattingEnabled = true;
            this.sexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.sexe.Location = new System.Drawing.Point(191, 157);
            this.sexe.MultiColumn = true;
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(330, 38);
            this.sexe.TabIndex = 12;
            // 
            // classe
            // 
            this.classe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.classe.FormattingEnabled = true;
            this.classe.Location = new System.Drawing.Point(191, 265);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(330, 24);
            this.classe.TabIndex = 11;
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.prenom.Location = new System.Drawing.Point(191, 116);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(330, 22);
            this.prenom.TabIndex = 8;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.nom.Location = new System.Drawing.Point(191, 74);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(330, 22);
            this.nom.TabIndex = 7;
            // 
            // matricule
            // 
            this.matricule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.matricule.Location = new System.Drawing.Point(191, 35);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(330, 22);
            this.matricule.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "CLASSE";
            // 
            // dateNaiss_label
            // 
            this.dateNaiss_label.AutoSize = true;
            this.dateNaiss_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNaiss_label.Location = new System.Drawing.Point(18, 213);
            this.dateNaiss_label.Name = "dateNaiss_label";
            this.dateNaiss_label.Size = new System.Drawing.Size(133, 22);
            this.dateNaiss_label.TabIndex = 4;
            this.dateNaiss_label.Text = "Date Naissance";
            // 
            // sexe_label
            // 
            this.sexe_label.AutoSize = true;
            this.sexe_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe_label.Location = new System.Drawing.Point(18, 157);
            this.sexe_label.Name = "sexe_label";
            this.sexe_label.Size = new System.Drawing.Size(59, 22);
            this.sexe_label.TabIndex = 3;
            this.sexe_label.Text = "SEXE";
            // 
            // prenom_label
            // 
            this.prenom_label.AutoSize = true;
            this.prenom_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label.Location = new System.Drawing.Point(17, 115);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(91, 22);
            this.prenom_label.TabIndex = 2;
            this.prenom_label.Text = "PRENOM";
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(18, 73);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(55, 22);
            this.nom_label.TabIndex = 1;
            this.nom_label.Text = "NOM";
            // 
            // matricule_label
            // 
            this.matricule_label.AutoSize = true;
            this.matricule_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule_label.Location = new System.Drawing.Point(18, 34);
            this.matricule_label.Name = "matricule_label";
            this.matricule_label.Size = new System.Drawing.Size(119, 22);
            this.matricule_label.TabIndex = 0;
            this.matricule_label.Text = "MATRICULE";
            // 
            // eleveDataGrid
            // 
            this.eleveDataGrid.AllowUserToAddRows = false;
            this.eleveDataGrid.AllowUserToDeleteRows = false;
            this.eleveDataGrid.AllowUserToResizeColumns = false;
            this.eleveDataGrid.AllowUserToResizeRows = false;
            this.eleveDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.eleveDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eleveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eleveDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdD,
            this.matriculeD,
            this.NomD,
            this.PrenomD,
            this.SexeD,
            this.DateNaissD,
            this.ClasseD,
            this.modifier,
            this.supprimer});
            this.eleveDataGrid.Location = new System.Drawing.Point(601, 100);
            this.eleveDataGrid.Name = "eleveDataGrid";
            this.eleveDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eleveDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.eleveDataGrid.RowTemplate.Height = 24;
            this.eleveDataGrid.Size = new System.Drawing.Size(1114, 456);
            this.eleveDataGrid.TabIndex = 5;
            this.eleveDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eleveDataGrid_CellContentClick);
            // 
            // IdD
            // 
            this.IdD.HeaderText = "Id";
            this.IdD.MinimumWidth = 6;
            this.IdD.Name = "IdD";
            this.IdD.Width = 30;
            // 
            // matriculeD
            // 
            this.matriculeD.HeaderText = "Matricule";
            this.matriculeD.MinimumWidth = 6;
            this.matriculeD.Name = "matriculeD";
            this.matriculeD.Width = 55;
            // 
            // NomD
            // 
            this.NomD.HeaderText = "Nom";
            this.NomD.MinimumWidth = 6;
            this.NomD.Name = "NomD";
            this.NomD.Width = 125;
            // 
            // PrenomD
            // 
            this.PrenomD.HeaderText = "Prenom";
            this.PrenomD.MinimumWidth = 6;
            this.PrenomD.Name = "PrenomD";
            this.PrenomD.Width = 125;
            // 
            // SexeD
            // 
            this.SexeD.HeaderText = "Sexe";
            this.SexeD.MinimumWidth = 6;
            this.SexeD.Name = "SexeD";
            this.SexeD.Width = 50;
            // 
            // DateNaissD
            // 
            this.DateNaissD.HeaderText = "Date Naissance";
            this.DateNaissD.MinimumWidth = 6;
            this.DateNaissD.Name = "DateNaissD";
            this.DateNaissD.Width = 80;
            // 
            // ClasseD
            // 
            this.ClasseD.HeaderText = "Classe";
            this.ClasseD.MinimumWidth = 6;
            this.ClasseD.Name = "ClasseD";
            this.ClasseD.Width = 60;
            // 
            // modifier
            // 
            this.modifier.HeaderText = "Modifier";
            this.modifier.MinimumWidth = 6;
            this.modifier.Name = "modifier";
            this.modifier.Text = "modifier";
            this.modifier.UseColumnTextForButtonValue = true;
            this.modifier.Width = 125;
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer";
            this.supprimer.MinimumWidth = 6;
            this.supprimer.Name = "supprimer";
            this.supprimer.Text = "supprimer";
            this.supprimer.UseColumnTextForButtonValue = true;
            this.supprimer.Width = 125;
            // 
            // headEleve_panel
            // 
            this.headEleve_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.headEleve_panel.Controls.Add(this.label1);
            this.headEleve_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headEleve_panel.Location = new System.Drawing.Point(0, 0);
            this.headEleve_panel.Name = "headEleve_panel";
            this.headEleve_panel.Size = new System.Drawing.Size(1747, 75);
            this.headEleve_panel.TabIndex = 6;
            // 
            // FormEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1747, 649);
            this.Controls.Add(this.headEleve_panel);
            this.Controls.Add(this.eleveDataGrid);
            this.Controls.Add(this.formPanel);
            this.Name = "FormEleve";
            this.Text = "FormEleve";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleveDataGrid)).EndInit();
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
        private System.Windows.Forms.Label matricule_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateNaiss_label;
        private System.Windows.Forms.ComboBox classe;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox matricule;
        private System.Windows.Forms.CheckedListBox sexe;
        private System.Windows.Forms.DataGridView eleveDataGrid;
        private System.Windows.Forms.DateTimePicker dateNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdD;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClasseD;
        private System.Windows.Forms.DataGridViewButtonColumn modifier;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
        private System.Windows.Forms.Panel headEleve_panel;
    }
}