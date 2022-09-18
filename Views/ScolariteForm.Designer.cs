namespace Nozel.Views
{
    partial class ScolariteForm
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
            this.rechercher_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nom_label = new System.Windows.Forms.Label();
            this.rechercherData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rechercher = new System.Windows.Forms.TextBox();
            this.head_panel = new System.Windows.Forms.Panel();
            this.headTitle_label = new System.Windows.Forms.Label();
            this.rechercher_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechercherData)).BeginInit();
            this.head_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rechercher_panel
            // 
            this.rechercher_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rechercher_panel.Controls.Add(this.panel1);
            this.rechercher_panel.Controls.Add(this.rechercherData);
            this.rechercher_panel.Controls.Add(this.rechercher);
            this.rechercher_panel.Location = new System.Drawing.Point(395, 198);
            this.rechercher_panel.Name = "rechercher_panel";
            this.rechercher_panel.Size = new System.Drawing.Size(1004, 536);
            this.rechercher_panel.TabIndex = 0;
            this.rechercher_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.nom_label);
            this.panel1.Location = new System.Drawing.Point(110, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 43);
            this.panel1.TabIndex = 4;
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.nom_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nom_label.Location = new System.Drawing.Point(28, 9);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(178, 25);
            this.nom_label.TabIndex = 0;
            this.nom_label.Text = "RECHERCHER";
            this.nom_label.Click += new System.EventHandler(this.nom_label_Click);
            // 
            // rechercherData
            // 
            this.rechercherData.AllowUserToAddRows = false;
            this.rechercherData.AllowUserToDeleteRows = false;
            this.rechercherData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.rechercherData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rechercherData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rechercherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rechercherData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.prenom,
            this.sexe,
            this.classe,
            this.payer});
            this.rechercherData.Location = new System.Drawing.Point(7, 146);
            this.rechercherData.Name = "rechercherData";
            this.rechercherData.RowHeadersWidth = 51;
            this.rechercherData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherData.RowTemplate.Height = 32;
            this.rechercherData.Size = new System.Drawing.Size(990, 383);
            this.rechercherData.TabIndex = 3;
            this.rechercherData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rechercherData_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 175;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Width = 175;
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
            this.classe.Width = 75;
            // 
            // payer
            // 
            this.payer.HeaderText = "Action";
            this.payer.MinimumWidth = 6;
            this.payer.Name = "payer";
            this.payer.Text = "Payer";
            this.payer.UseColumnTextForButtonValue = true;
            this.payer.Width = 125;
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(331, 38);
            this.rechercher.Multiline = true;
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(633, 43);
            this.rechercher.TabIndex = 1;
            this.rechercher.TextChanged += new System.EventHandler(this.rechercher_TextChanged);
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.head_panel.Controls.Add(this.headTitle_label);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(1780, 77);
            this.head_panel.TabIndex = 1;
            // 
            // headTitle_label
            // 
            this.headTitle_label.AutoSize = true;
            this.headTitle_label.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headTitle_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headTitle_label.Location = new System.Drawing.Point(513, 9);
            this.headTitle_label.Name = "headTitle_label";
            this.headTitle_label.Size = new System.Drawing.Size(570, 53);
            this.headTitle_label.TabIndex = 0;
            this.headTitle_label.Text = "PAYEMENT SCOLARITE";
            // 
            // ScolariteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1780, 842);
            this.Controls.Add(this.head_panel);
            this.Controls.Add(this.rechercher_panel);
            this.Name = "ScolariteForm";
            this.Text = "ScolariteForm";
            this.Load += new System.EventHandler(this.ScolariteForm_Load);
            this.rechercher_panel.ResumeLayout(false);
            this.rechercher_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechercherData)).EndInit();
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rechercher_panel;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.TextBox rechercher;
        private System.Windows.Forms.DataGridView rechercherData;
        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label headTitle_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewButtonColumn payer;
    }
}