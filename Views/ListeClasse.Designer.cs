namespace Nozel.Forms
{
    partial class FormClasse
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
            this.tableauClasse = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AjoutClasseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableauClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // tableauClasse
            // 
            this.tableauClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableauClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.designation,
            this.effectif,
            this.description});
            this.tableauClasse.Location = new System.Drawing.Point(12, 125);
            this.tableauClasse.Name = "tableauClasse";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauClasse.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableauClasse.RowHeadersVisible = false;
            this.tableauClasse.RowHeadersWidth = 51;
            this.tableauClasse.RowTemplate.Height = 24;
            this.tableauClasse.Size = new System.Drawing.Size(875, 516);
            this.tableauClasse.TabIndex = 0;
            this.tableauClasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauClasse_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "N°";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // designation
            // 
            this.designation.HeaderText = "DESIGNATION";
            this.designation.MinimumWidth = 6;
            this.designation.Name = "designation";
            this.designation.Width = 125;
            // 
            // effectif
            // 
            this.effectif.HeaderText = "EFFECTIF";
            this.effectif.MinimumWidth = 6;
            this.effectif.Name = "effectif";
            this.effectif.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // AjoutClasseBtn
            // 
            this.AjoutClasseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.AjoutClasseBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AjoutClasseBtn.Location = new System.Drawing.Point(12, 47);
            this.AjoutClasseBtn.Name = "AjoutClasseBtn";
            this.AjoutClasseBtn.Size = new System.Drawing.Size(154, 52);
            this.AjoutClasseBtn.TabIndex = 1;
            this.AjoutClasseBtn.Text = "Nouveau";
            this.AjoutClasseBtn.UseVisualStyleBackColor = false;
            this.AjoutClasseBtn.Click += new System.EventHandler(this.AjoutClasseBtn_Click);
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(931, 653);
            this.Controls.Add(this.AjoutClasseBtn);
            this.Controls.Add(this.tableauClasse);
            this.Name = "FormClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTE DES SALLES DE CLASSE";
            this.Load += new System.EventHandler(this.FormClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauClasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableauClasse;
        private System.Windows.Forms.Button AjoutClasseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectif;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}