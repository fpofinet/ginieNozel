namespace Nozel.Views
{
    partial class ListeEleve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eleveHeadPanel = new System.Windows.Forms.Panel();
            this.ListeEleveTitle = new System.Windows.Forms.Label();
            this.eleveDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addEleveBtn = new System.Windows.Forms.Button();
            this.rechercherBox = new System.Windows.Forms.TextBox();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classeBox = new System.Windows.Forms.ComboBox();
            this.anneeCB = new System.Windows.Forms.ComboBox();
            this.eleveHeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleveDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eleveHeadPanel
            // 
            this.eleveHeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.eleveHeadPanel.Controls.Add(this.ListeEleveTitle);
            this.eleveHeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.eleveHeadPanel.Location = new System.Drawing.Point(0, 0);
            this.eleveHeadPanel.Name = "eleveHeadPanel";
            this.eleveHeadPanel.Size = new System.Drawing.Size(1796, 75);
            this.eleveHeadPanel.TabIndex = 0;
            // 
            // ListeEleveTitle
            // 
            this.ListeEleveTitle.AutoSize = true;
            this.ListeEleveTitle.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeEleveTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ListeEleveTitle.Location = new System.Drawing.Point(567, 9);
            this.ListeEleveTitle.Name = "ListeEleveTitle";
            this.ListeEleveTitle.Size = new System.Drawing.Size(459, 53);
            this.ListeEleveTitle.TabIndex = 0;
            this.ListeEleveTitle.Text = "LISTE DES ELEVES";
            // 
            // eleveDataGrid
            // 
            this.eleveDataGrid.AllowUserToAddRows = false;
            this.eleveDataGrid.AllowUserToDeleteRows = false;
            this.eleveDataGrid.AllowUserToOrderColumns = true;
            this.eleveDataGrid.AllowUserToResizeColumns = false;
            this.eleveDataGrid.AllowUserToResizeRows = false;
            this.eleveDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.eleveDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eleveDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.eleveDataGrid.ColumnHeadersHeight = 48;
            this.eleveDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.matricule,
            this.nom,
            this.prenom,
            this.age,
            this.dateNaiss,
            this.sexe,
            this.classe,
            this.details,
            this.modifier,
            this.supprimer});
            this.eleveDataGrid.EnableHeadersVisualStyles = false;
            this.eleveDataGrid.Location = new System.Drawing.Point(66, 230);
            this.eleveDataGrid.Name = "eleveDataGrid";
            this.eleveDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleveDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.eleveDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleveDataGrid.RowTemplate.Height = 32;
            this.eleveDataGrid.RowTemplate.ReadOnly = true;
            this.eleveDataGrid.Size = new System.Drawing.Size(1701, 744);
            this.eleveDataGrid.TabIndex = 1;
            this.eleveDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eleveDataGrid_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // matricule
            // 
            this.matricule.HeaderText = "Matricule";
            this.matricule.MinimumWidth = 6;
            this.matricule.Name = "matricule";
            this.matricule.ReadOnly = true;
            this.matricule.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 200;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Width = 215;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 75;
            // 
            // dateNaiss
            // 
            this.dateNaiss.HeaderText = "DateNaiss";
            this.dateNaiss.MinimumWidth = 6;
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.ReadOnly = true;
            this.dateNaiss.Visible = false;
            this.dateNaiss.Width = 125;
            // 
            // sexe
            // 
            this.sexe.HeaderText = "Sexe";
            this.sexe.MinimumWidth = 6;
            this.sexe.Name = "sexe";
            this.sexe.ReadOnly = true;
            this.sexe.Width = 80;
            // 
            // classe
            // 
            this.classe.HeaderText = "Classe";
            this.classe.MinimumWidth = 6;
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            this.classe.Width = 85;
            // 
            // details
            // 
            this.details.HeaderText = "Details";
            this.details.MinimumWidth = 6;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.details.Text = "...";
            this.details.UseColumnTextForButtonValue = true;
            this.details.Width = 125;
            // 
            // modifier
            // 
            this.modifier.HeaderText = "Modifier";
            this.modifier.MinimumWidth = 6;
            this.modifier.Name = "modifier";
            this.modifier.ReadOnly = true;
            this.modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modifier.Text = "Modifier";
            this.modifier.UseColumnTextForButtonValue = true;
            this.modifier.Width = 150;
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer";
            this.supprimer.MinimumWidth = 6;
            this.supprimer.Name = "supprimer";
            this.supprimer.ReadOnly = true;
            this.supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseColumnTextForButtonValue = true;
            this.supprimer.Width = 150;
            // 
            // addEleveBtn
            // 
            this.addEleveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.addEleveBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEleveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addEleveBtn.Location = new System.Drawing.Point(66, 151);
            this.addEleveBtn.Name = "addEleveBtn";
            this.addEleveBtn.Size = new System.Drawing.Size(178, 53);
            this.addEleveBtn.TabIndex = 2;
            this.addEleveBtn.Text = "Ajouter";
            this.addEleveBtn.UseVisualStyleBackColor = false;
            this.addEleveBtn.Click += new System.EventHandler(this.addEleveBtn_Click);
            // 
            // rechercherBox
            // 
            this.rechercherBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherBox.Location = new System.Drawing.Point(726, 151);
            this.rechercherBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rechercherBox.Multiline = true;
            this.rechercherBox.Name = "rechercherBox";
            this.rechercherBox.Size = new System.Drawing.Size(639, 53);
            this.rechercherBox.TabIndex = 3;
            this.rechercherBox.TextChanged += new System.EventHandler(this.rechercherBox_TextChanged);
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRechercher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRechercher.Location = new System.Drawing.Point(25, 11);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(149, 32);
            this.labelRechercher.TabIndex = 5;
            this.labelRechercher.Text = "Rechercher";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.labelRechercher);
            this.panel1.Location = new System.Drawing.Point(539, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 53);
            this.panel1.TabIndex = 6;
            // 
            // classeBox
            // 
            this.classeBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.classeBox.FormattingEnabled = true;
            this.classeBox.ItemHeight = 32;
            this.classeBox.Location = new System.Drawing.Point(1404, 164);
            this.classeBox.Name = "classeBox";
            this.classeBox.Size = new System.Drawing.Size(121, 40);
            this.classeBox.TabIndex = 7;
            this.classeBox.SelectedIndexChanged += new System.EventHandler(this.classeBox_SelectedIndexChanged);
            // 
            // anneeCB
            // 
            this.anneeCB.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneeCB.FormattingEnabled = true;
            this.anneeCB.Location = new System.Drawing.Point(1572, 165);
            this.anneeCB.Name = "anneeCB";
            this.anneeCB.Size = new System.Drawing.Size(162, 40);
            this.anneeCB.TabIndex = 8;
            this.anneeCB.SelectedIndexChanged += new System.EventHandler(this.anneeCB_SelectedIndexChanged);
            // 
            // ListeEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1796, 1015);
            this.Controls.Add(this.anneeCB);
            this.Controls.Add(this.classeBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rechercherBox);
            this.Controls.Add(this.addEleveBtn);
            this.Controls.Add(this.eleveDataGrid);
            this.Controls.Add(this.eleveHeadPanel);
            this.Name = "ListeEleve";
            this.Text = "ListeEleve";
            this.eleveHeadPanel.ResumeLayout(false);
            this.eleveHeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleveDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel eleveHeadPanel;
        private System.Windows.Forms.Label ListeEleveTitle;
        private System.Windows.Forms.DataGridView eleveDataGrid;
        private System.Windows.Forms.Button addEleveBtn;
        private System.Windows.Forms.TextBox rechercherBox;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox classeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewButtonColumn details;
        private System.Windows.Forms.DataGridViewButtonColumn modifier;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
        private System.Windows.Forms.ComboBox anneeCB;
    }
}