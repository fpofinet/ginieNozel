namespace Nozel.Views
{
    partial class AjoutClasse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.designationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleClasse_label = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.annulerClasseBtn = new System.Windows.Forms.Button();
            this.saveClasseBtn = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.titleClasse_panel = new System.Windows.Forms.Panel();
            this.ClasseDataGrid = new System.Windows.Forms.DataGridView();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.effectif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formPanel.SuspendLayout();
            this.titleClasse_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClasseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // designationLabel
            // 
            this.designationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designationLabel.AutoSize = true;
            this.designationLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationLabel.Location = new System.Drawing.Point(3, 22);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(162, 26);
            this.designationLabel.TabIndex = 0;
            this.designationLabel.Text = "DESIGNATION";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 89);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(160, 26);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "DESCRIPTION";
            // 
            // titleClasse_label
            // 
            this.titleClasse_label.AutoSize = true;
            this.titleClasse_label.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleClasse_label.Location = new System.Drawing.Point(446, 18);
            this.titleClasse_label.Name = "titleClasse_label";
            this.titleClasse_label.Size = new System.Drawing.Size(702, 49);
            this.titleClasse_label.TabIndex = 2;
            this.titleClasse_label.Text = "GESTION DES SALLES DE CLASSE";
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.description.Location = new System.Drawing.Point(227, 89);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(248, 65);
            this.description.TabIndex = 3;
            // 
            // designation
            // 
            this.designation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.designation.Location = new System.Drawing.Point(227, 26);
            this.designation.Multiline = true;
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(248, 22);
            this.designation.TabIndex = 4;
            this.designation.TextChanged += new System.EventHandler(this.designation_TextChanged);
            // 
            // annulerClasseBtn
            // 
            this.annulerClasseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.annulerClasseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.annulerClasseBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerClasseBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.annulerClasseBtn.Location = new System.Drawing.Point(62, 194);
            this.annulerClasseBtn.Name = "annulerClasseBtn";
            this.annulerClasseBtn.Size = new System.Drawing.Size(159, 44);
            this.annulerClasseBtn.TabIndex = 5;
            this.annulerClasseBtn.Text = "ANNULER";
            this.annulerClasseBtn.UseVisualStyleBackColor = false;
            this.annulerClasseBtn.Click += new System.EventHandler(this.annulerClasseBtn_Click);
            // 
            // saveClasseBtn
            // 
            this.saveClasseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveClasseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(46)))));
            this.saveClasseBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveClasseBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.saveClasseBtn.Location = new System.Drawing.Point(254, 194);
            this.saveClasseBtn.Name = "saveClasseBtn";
            this.saveClasseBtn.Size = new System.Drawing.Size(221, 44);
            this.saveClasseBtn.TabIndex = 6;
            this.saveClasseBtn.Text = "ENREGISTRER";
            this.saveClasseBtn.UseVisualStyleBackColor = false;
            this.saveClasseBtn.Click += new System.EventHandler(this.saveClasseBtn_Click);
            // 
            // formPanel
            // 
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formPanel.Controls.Add(this.designation);
            this.formPanel.Controls.Add(this.annulerClasseBtn);
            this.formPanel.Controls.Add(this.saveClasseBtn);
            this.formPanel.Controls.Add(this.designationLabel);
            this.formPanel.Controls.Add(this.descriptionLabel);
            this.formPanel.Controls.Add(this.description);
            this.formPanel.Location = new System.Drawing.Point(12, 106);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(539, 315);
            this.formPanel.TabIndex = 7;
            // 
            // titleClasse_panel
            // 
            this.titleClasse_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.titleClasse_panel.Controls.Add(this.titleClasse_label);
            this.titleClasse_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleClasse_panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titleClasse_panel.Location = new System.Drawing.Point(0, 0);
            this.titleClasse_panel.Name = "titleClasse_panel";
            this.titleClasse_panel.Size = new System.Drawing.Size(1731, 82);
            this.titleClasse_panel.TabIndex = 9;
            // 
            // ClasseDataGrid
            // 
            this.ClasseDataGrid.AllowUserToAddRows = false;
            this.ClasseDataGrid.AllowUserToDeleteRows = false;
            this.ClasseDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "  ";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            this.ClasseDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClasseDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClasseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClasseDataGrid.ColumnHeadersHeight = 30;
            this.ClasseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.designa,
            this.desc,
            this.effectif,
            this.Modifier,
            this.Supprimer});
            this.ClasseDataGrid.Location = new System.Drawing.Point(607, 106);
            this.ClasseDataGrid.Name = "ClasseDataGrid";
            this.ClasseDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ClasseDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ClasseDataGrid.RowTemplate.Height = 24;
            this.ClasseDataGrid.Size = new System.Drawing.Size(855, 485);
            this.ClasseDataGrid.TabIndex = 0;
            this.ClasseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClasseDataGrid_CellContentClick);
            // 
            // Supprimer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.DefaultCellStyle = dataGridViewCellStyle3;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 6;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Text = "supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 125;
            // 
            // Modifier
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.Modifier.HeaderText = "Modifer";
            this.Modifier.MinimumWidth = 6;
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            this.Modifier.Width = 125;
            // 
            // effectif
            // 
            this.effectif.HeaderText = "Effectif";
            this.effectif.MinimumWidth = 6;
            this.effectif.Name = "effectif";
            this.effectif.Width = 75;
            // 
            // desc
            // 
            this.desc.HeaderText = "Description";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.Width = 150;
            // 
            // designa
            // 
            this.designa.HeaderText = "Designation";
            this.designa.MinimumWidth = 6;
            this.designa.Name = "designa";
            this.designa.Width = 110;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 25;
            // 
            // AjoutClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1731, 720);
            this.Controls.Add(this.ClasseDataGrid);
            this.Controls.Add(this.titleClasse_panel);
            this.Controls.Add(this.formPanel);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "AjoutClasse";
            this.Text = "AjoutClasse";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.titleClasse_panel.ResumeLayout(false);
            this.titleClasse_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClasseDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleClasse_label;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.Button annulerClasseBtn;
        private System.Windows.Forms.Button saveClasseBtn;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Panel titleClasse_panel;
        private System.Windows.Forms.DataGridView ClasseDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn designa;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectif;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}