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
            this.designationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleClasse_label = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.annulerClasseBtn = new System.Windows.Forms.Button();
            this.saveClasseBtn = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.frais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleClasse_panel = new System.Windows.Forms.Panel();
            this.BackClasseBtn = new System.Windows.Forms.Button();
            this.formPanel.SuspendLayout();
            this.titleClasse_panel.SuspendLayout();
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
            this.titleClasse_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleClasse_label.Location = new System.Drawing.Point(589, 9);
            this.titleClasse_label.Name = "titleClasse_label";
            this.titleClasse_label.Size = new System.Drawing.Size(479, 49);
            this.titleClasse_label.TabIndex = 2;
            this.titleClasse_label.Text = "AJOUTER UNE CLASSE";
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.description.Location = new System.Drawing.Point(254, 93);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(248, 82);
            this.description.TabIndex = 3;
            // 
            // designation
            // 
            this.designation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.designation.Location = new System.Drawing.Point(254, 26);
            this.designation.Multiline = true;
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(248, 40);
            this.designation.TabIndex = 4;
            // 
            // annulerClasseBtn
            // 
            this.annulerClasseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.annulerClasseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.annulerClasseBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerClasseBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.annulerClasseBtn.Location = new System.Drawing.Point(51, 313);
            this.annulerClasseBtn.Name = "annulerClasseBtn";
            this.annulerClasseBtn.Size = new System.Drawing.Size(159, 47);
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
            this.saveClasseBtn.Location = new System.Drawing.Point(281, 313);
            this.saveClasseBtn.Name = "saveClasseBtn";
            this.saveClasseBtn.Size = new System.Drawing.Size(221, 47);
            this.saveClasseBtn.TabIndex = 6;
            this.saveClasseBtn.Text = "ENREGISTRER";
            this.saveClasseBtn.UseVisualStyleBackColor = false;
            this.saveClasseBtn.Click += new System.EventHandler(this.saveClasseBtn_Click);
            // 
            // formPanel
            // 
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formPanel.Controls.Add(this.frais);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.designation);
            this.formPanel.Controls.Add(this.annulerClasseBtn);
            this.formPanel.Controls.Add(this.saveClasseBtn);
            this.formPanel.Controls.Add(this.designationLabel);
            this.formPanel.Controls.Add(this.descriptionLabel);
            this.formPanel.Controls.Add(this.description);
            this.formPanel.Location = new System.Drawing.Point(517, 181);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(539, 392);
            this.formPanel.TabIndex = 7;
            // 
            // frais
            // 
            this.frais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.frais.Location = new System.Drawing.Point(254, 197);
            this.frais.Multiline = true;
            this.frais.Name = "frais";
            this.frais.Size = new System.Drawing.Size(248, 41);
            this.frais.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "FRAIS SCOLARITE";
            // 
            // titleClasse_panel
            // 
            this.titleClasse_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.titleClasse_panel.Controls.Add(this.titleClasse_label);
            this.titleClasse_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleClasse_panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titleClasse_panel.Location = new System.Drawing.Point(0, 0);
            this.titleClasse_panel.Name = "titleClasse_panel";
            this.titleClasse_panel.Size = new System.Drawing.Size(1731, 72);
            this.titleClasse_panel.TabIndex = 9;
            // 
            // BackClasseBtn
            // 
            this.BackClasseBtn.Location = new System.Drawing.Point(298, 104);
            this.BackClasseBtn.Name = "BackClasseBtn";
            this.BackClasseBtn.Size = new System.Drawing.Size(97, 34);
            this.BackClasseBtn.TabIndex = 10;
            this.BackClasseBtn.Text = "Back";
            this.BackClasseBtn.UseVisualStyleBackColor = true;
            this.BackClasseBtn.Click += new System.EventHandler(this.backClasseBtn_Click);
            // 
            // AjoutClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1731, 831);
            this.Controls.Add(this.BackClasseBtn);
            this.Controls.Add(this.titleClasse_panel);
            this.Controls.Add(this.formPanel);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "AjoutClasse";
            this.Text = "AjoutClasse";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.titleClasse_panel.ResumeLayout(false);
            this.titleClasse_panel.PerformLayout();
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
        private System.Windows.Forms.TextBox frais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackClasseBtn;
    }
}