namespace Nozel.Views
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AjoutClasseBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classeDataGrid = new System.Windows.Forms.DataGridView();
            this.listeClasseHead = new System.Windows.Forms.Panel();
            this.addClasseTitle = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataGrid)).BeginInit();
            this.listeClasseHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // AjoutClasseBtn
            // 
            this.AjoutClasseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.AjoutClasseBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutClasseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AjoutClasseBtn.Location = new System.Drawing.Point(411, 137);
            this.AjoutClasseBtn.Name = "AjoutClasseBtn";
            this.AjoutClasseBtn.Size = new System.Drawing.Size(180, 52);
            this.AjoutClasseBtn.TabIndex = 1;
            this.AjoutClasseBtn.Text = "Nouveau";
            this.AjoutClasseBtn.UseVisualStyleBackColor = false;
            this.AjoutClasseBtn.Click += new System.EventHandler(this.AjoutClasseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.classeDataGrid);
            this.panel1.Location = new System.Drawing.Point(408, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 568);
            this.panel1.TabIndex = 2;
            // 
            // classeDataGrid
            // 
            this.classeDataGrid.AllowUserToAddRows = false;
            this.classeDataGrid.AllowUserToDeleteRows = false;
            this.classeDataGrid.AllowUserToOrderColumns = true;
            this.classeDataGrid.AllowUserToResizeColumns = false;
            this.classeDataGrid.AllowUserToResizeRows = false;
            this.classeDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classeDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.classeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.classeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.designation,
            this.description,
            this.effectif,
            this.modifier,
            this.supprimer});
            this.classeDataGrid.Location = new System.Drawing.Point(3, 3);
            this.classeDataGrid.Name = "classeDataGrid";
            this.classeDataGrid.ReadOnly = true;
            this.classeDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.classeDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeDataGrid.RowTemplate.Height = 32;
            this.classeDataGrid.Size = new System.Drawing.Size(1055, 562);
            this.classeDataGrid.TabIndex = 0;
            this.classeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classeDataGrid_CellContentClick);
            // 
            // listeClasseHead
            // 
            this.listeClasseHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.listeClasseHead.Controls.Add(this.addClasseTitle);
            this.listeClasseHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.listeClasseHead.ForeColor = System.Drawing.SystemColors.Control;
            this.listeClasseHead.Location = new System.Drawing.Point(0, 0);
            this.listeClasseHead.Name = "listeClasseHead";
            this.listeClasseHead.Size = new System.Drawing.Size(1779, 68);
            this.listeClasseHead.TabIndex = 3;
            // 
            // addClasseTitle
            // 
            this.addClasseTitle.AutoSize = true;
            this.addClasseTitle.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClasseTitle.Location = new System.Drawing.Point(517, 9);
            this.addClasseTitle.Name = "addClasseTitle";
            this.addClasseTitle.Size = new System.Drawing.Size(725, 53);
            this.addClasseTitle.TabIndex = 0;
            this.addClasseTitle.Text = "LISTE DES SALLES DE CLASSE";
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
            // designation
            // 
            this.designation.HeaderText = "Designation";
            this.designation.MinimumWidth = 6;
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 180;
            // 
            // effectif
            // 
            this.effectif.HeaderText = "Effectif";
            this.effectif.MinimumWidth = 6;
            this.effectif.Name = "effectif";
            this.effectif.ReadOnly = true;
            this.effectif.Width = 125;
            // 
            // modifier
            // 
            this.modifier.HeaderText = "Modifier";
            this.modifier.MinimumWidth = 6;
            this.modifier.Name = "modifier";
            this.modifier.ReadOnly = true;
            this.modifier.Text = "Modifier";
            this.modifier.UseColumnTextForButtonValue = true;
            this.modifier.Width = 125;
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer";
            this.supprimer.MinimumWidth = 6;
            this.supprimer.Name = "supprimer";
            this.supprimer.ReadOnly = true;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseColumnTextForButtonValue = true;
            this.supprimer.Width = 125;
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1779, 796);
            this.Controls.Add(this.listeClasseHead);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AjoutClasseBtn);
            this.Name = "FormClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTE DES SALLES DE CLASSE";
            this.Load += new System.EventHandler(this.FormClasse_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classeDataGrid)).EndInit();
            this.listeClasseHead.ResumeLayout(false);
            this.listeClasseHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AjoutClasseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView classeDataGrid;
        private System.Windows.Forms.Panel listeClasseHead;
        private System.Windows.Forms.Label addClasseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectif;
        private System.Windows.Forms.DataGridViewButtonColumn modifier;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
    }
}