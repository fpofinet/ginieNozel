namespace Nozel.Views
{
    partial class HomeForm
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
            this.head_panel = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.dataStudentPanel = new System.Windows.Forms.Panel();
            this.filtresPanel = new System.Windows.Forms.Panel();
            this.classeFiltreBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.filtreLabel = new System.Windows.Forms.Label();
            this.homeDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPANEL = new System.Windows.Forms.Panel();
            this.statDataGrid = new System.Windows.Forms.DataGridView();
            this.salle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efajour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efrestant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statPanel = new System.Windows.Forms.Panel();
            this.statLabel = new System.Windows.Forms.Label();
            this.soldeData = new System.Windows.Forms.Label();
            this.soldeLabel = new System.Windows.Forms.Label();
            this.eleveStatutData = new System.Windows.Forms.Label();
            this.eleveStatutLabel = new System.Windows.Forms.Label();
            this.nRecData = new System.Windows.Forms.Label();
            this.nRecLabel = new System.Windows.Forms.Label();
            this.head_panel.SuspendLayout();
            this.dataStudentPanel.SuspendLayout();
            this.filtresPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).BeginInit();
            this.dataPANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statDataGrid)).BeginInit();
            this.statPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.head_panel.Controls.Add(this.title_label);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(1875, 81);
            this.head_panel.TabIndex = 0;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(439, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(505, 53);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "TABLEAU DE BOARD";
            // 
            // dataStudentPanel
            // 
            this.dataStudentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataStudentPanel.Controls.Add(this.filtresPanel);
            this.dataStudentPanel.Controls.Add(this.homeDataGrid);
            this.dataStudentPanel.Location = new System.Drawing.Point(814, 87);
            this.dataStudentPanel.Name = "dataStudentPanel";
            this.dataStudentPanel.Size = new System.Drawing.Size(1020, 673);
            this.dataStudentPanel.TabIndex = 1;
            // 
            // filtresPanel
            // 
            this.filtresPanel.Controls.Add(this.classeFiltreBox);
            this.filtresPanel.Controls.Add(this.searchLabel);
            this.filtresPanel.Controls.Add(this.search);
            this.filtresPanel.Controls.Add(this.filtreLabel);
            this.filtresPanel.Location = new System.Drawing.Point(3, 3);
            this.filtresPanel.Name = "filtresPanel";
            this.filtresPanel.Size = new System.Drawing.Size(1055, 164);
            this.filtresPanel.TabIndex = 1;
            // 
            // classeFiltreBox
            // 
            this.classeFiltreBox.FormattingEnabled = true;
            this.classeFiltreBox.Location = new System.Drawing.Point(264, 99);
            this.classeFiltreBox.Name = "classeFiltreBox";
            this.classeFiltreBox.Size = new System.Drawing.Size(121, 24);
            this.classeFiltreBox.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(15, 39);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(215, 32);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "RECHERCHER";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(264, 36);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(428, 35);
            this.search.TabIndex = 1;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // filtreLabel
            // 
            this.filtreLabel.AutoSize = true;
            this.filtreLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtreLabel.Location = new System.Drawing.Point(88, 89);
            this.filtreLabel.Name = "filtreLabel";
            this.filtreLabel.Size = new System.Drawing.Size(142, 35);
            this.filtreLabel.TabIndex = 0;
            this.filtreLabel.Text = "FILTRES";
            // 
            // homeDataGrid
            // 
            this.homeDataGrid.AllowUserToAddRows = false;
            this.homeDataGrid.AllowUserToDeleteRows = false;
            this.homeDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.homeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.homeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mat,
            this.nom,
            this.prenom,
            this.sexe,
            this.classe,
            this.statut});
            this.homeDataGrid.Location = new System.Drawing.Point(3, 186);
            this.homeDataGrid.Name = "homeDataGrid";
            this.homeDataGrid.RowHeadersWidth = 51;
            this.homeDataGrid.RowTemplate.Height = 24;
            this.homeDataGrid.Size = new System.Drawing.Size(1055, 486);
            this.homeDataGrid.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // mat
            // 
            this.mat.HeaderText = "MATRICULE";
            this.mat.MinimumWidth = 6;
            this.mat.Name = "mat";
            this.mat.ReadOnly = true;
            this.mat.Width = 90;
            // 
            // nom
            // 
            this.nom.HeaderText = "NOM";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 160;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "PRENOM";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Width = 160;
            // 
            // sexe
            // 
            this.sexe.HeaderText = "SEXE";
            this.sexe.MinimumWidth = 6;
            this.sexe.Name = "sexe";
            this.sexe.ReadOnly = true;
            this.sexe.Width = 70;
            // 
            // classe
            // 
            this.classe.HeaderText = "CLASSE";
            this.classe.MinimumWidth = 6;
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            this.classe.Width = 70;
            // 
            // statut
            // 
            this.statut.HeaderText = "STATUT";
            this.statut.MinimumWidth = 6;
            this.statut.Name = "statut";
            this.statut.ReadOnly = true;
            this.statut.Width = 125;
            // 
            // dataPANEL
            // 
            this.dataPANEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataPANEL.Controls.Add(this.statDataGrid);
            this.dataPANEL.Location = new System.Drawing.Point(5, 362);
            this.dataPANEL.Name = "dataPANEL";
            this.dataPANEL.Size = new System.Drawing.Size(768, 398);
            this.dataPANEL.TabIndex = 2;
            // 
            // statDataGrid
            // 
            this.statDataGrid.AllowUserToAddRows = false;
            this.statDataGrid.AllowUserToDeleteRows = false;
            this.statDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.statDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salle,
            this.effectif,
            this.efajour,
            this.efrestant,
            this.rec});
            this.statDataGrid.Location = new System.Drawing.Point(8, 14);
            this.statDataGrid.Name = "statDataGrid";
            this.statDataGrid.RowHeadersWidth = 51;
            this.statDataGrid.RowTemplate.Height = 24;
            this.statDataGrid.Size = new System.Drawing.Size(753, 377);
            this.statDataGrid.TabIndex = 0;
            // 
            // salle
            // 
            this.salle.HeaderText = "CLASSE";
            this.salle.MinimumWidth = 6;
            this.salle.Name = "salle";
            this.salle.ReadOnly = true;
            this.salle.Width = 75;
            // 
            // effectif
            // 
            this.effectif.HeaderText = "EFFECTIF";
            this.effectif.MinimumWidth = 6;
            this.effectif.Name = "effectif";
            this.effectif.ReadOnly = true;
            this.effectif.Width = 75;
            // 
            // efajour
            // 
            this.efajour.HeaderText = "EFF. A JOUR";
            this.efajour.MinimumWidth = 6;
            this.efajour.Name = "efajour";
            this.efajour.ReadOnly = true;
            this.efajour.Width = 110;
            // 
            // efrestant
            // 
            this.efrestant.HeaderText = "EFF. RESTANT";
            this.efrestant.MinimumWidth = 6;
            this.efrestant.Name = "efrestant";
            this.efrestant.ReadOnly = true;
            this.efrestant.Width = 110;
            // 
            // rec
            // 
            this.rec.HeaderText = "TOTAL COLLECTE";
            this.rec.MinimumWidth = 6;
            this.rec.Name = "rec";
            this.rec.ReadOnly = true;
            this.rec.Width = 125;
            // 
            // statPanel
            // 
            this.statPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statPanel.Controls.Add(this.statLabel);
            this.statPanel.Controls.Add(this.soldeData);
            this.statPanel.Controls.Add(this.soldeLabel);
            this.statPanel.Controls.Add(this.eleveStatutData);
            this.statPanel.Controls.Add(this.eleveStatutLabel);
            this.statPanel.Controls.Add(this.nRecData);
            this.statPanel.Controls.Add(this.nRecLabel);
            this.statPanel.Location = new System.Drawing.Point(5, 87);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(768, 269);
            this.statPanel.TabIndex = 3;
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.Location = new System.Drawing.Point(193, 0);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(253, 37);
            this.statLabel.TabIndex = 6;
            this.statLabel.Text = "STATISTIQUES";
            // 
            // soldeData
            // 
            this.soldeData.AutoSize = true;
            this.soldeData.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldeData.Location = new System.Drawing.Point(111, 180);
            this.soldeData.Name = "soldeData";
            this.soldeData.Size = new System.Drawing.Size(116, 25);
            this.soldeData.TabIndex = 5;
            this.soldeData.Text = "25 sur 100";
            // 
            // soldeLabel
            // 
            this.soldeLabel.AutoSize = true;
            this.soldeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldeLabel.Location = new System.Drawing.Point(3, 180);
            this.soldeLabel.Name = "soldeLabel";
            this.soldeLabel.Size = new System.Drawing.Size(102, 26);
            this.soldeLabel.TabIndex = 4;
            this.soldeLabel.Text = "SOLDE : ";
            // 
            // eleveStatutData
            // 
            this.eleveStatutData.AutoSize = true;
            this.eleveStatutData.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleveStatutData.Location = new System.Drawing.Point(271, 126);
            this.eleveStatutData.Name = "eleveStatutData";
            this.eleveStatutData.Size = new System.Drawing.Size(122, 25);
            this.eleveStatutData.TabIndex = 3;
            this.eleveStatutData.Text = "50  sur 100";
            // 
            // eleveStatutLabel
            // 
            this.eleveStatutLabel.AutoSize = true;
            this.eleveStatutLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleveStatutLabel.Location = new System.Drawing.Point(3, 125);
            this.eleveStatutLabel.Name = "eleveStatutLabel";
            this.eleveStatutLabel.Size = new System.Drawing.Size(242, 26);
            this.eleveStatutLabel.TabIndex = 2;
            this.eleveStatutLabel.Text = "TOTAL DES ELEVES  : ";
            // 
            // nRecData
            // 
            this.nRecData.AutoSize = true;
            this.nRecData.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRecData.Location = new System.Drawing.Point(365, 67);
            this.nRecData.Name = "nRecData";
            this.nRecData.Size = new System.Drawing.Size(206, 25);
            this.nRecData.TabIndex = 1;
            this.nRecData.Text = "50.000 sur 100.000 ";
            // 
            // nRecLabel
            // 
            this.nRecLabel.AutoSize = true;
            this.nRecLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRecLabel.Location = new System.Drawing.Point(3, 67);
            this.nRecLabel.Name = "nRecLabel";
            this.nRecLabel.Size = new System.Drawing.Size(336, 26);
            this.nRecLabel.TabIndex = 0;
            this.nRecLabel.Text = "NIVEAU DE RECOUVREMENT : ";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1875, 772);
            this.Controls.Add(this.statPanel);
            this.Controls.Add(this.dataPANEL);
            this.Controls.Add(this.dataStudentPanel);
            this.Controls.Add(this.head_panel);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.dataStudentPanel.ResumeLayout(false);
            this.filtresPanel.ResumeLayout(false);
            this.filtresPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).EndInit();
            this.dataPANEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statDataGrid)).EndInit();
            this.statPanel.ResumeLayout(false);
            this.statPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel dataStudentPanel;
        private System.Windows.Forms.Panel statPanel;
        private System.Windows.Forms.Panel dataPANEL;
        private System.Windows.Forms.Panel filtresPanel;
        private System.Windows.Forms.ComboBox classeFiltreBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label filtreLabel;
        private System.Windows.Forms.DataGridView homeDataGrid;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Label soldeData;
        private System.Windows.Forms.Label soldeLabel;
        private System.Windows.Forms.Label eleveStatutData;
        private System.Windows.Forms.Label eleveStatutLabel;
        private System.Windows.Forms.Label nRecData;
        private System.Windows.Forms.Label nRecLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridView statDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn salle;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectif;
        private System.Windows.Forms.DataGridViewTextBoxColumn efajour;
        private System.Windows.Forms.DataGridViewTextBoxColumn efrestant;
        private System.Windows.Forms.DataGridViewTextBoxColumn rec;
    }
}