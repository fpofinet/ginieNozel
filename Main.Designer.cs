namespace Nozel
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.eleveBtn = new System.Windows.Forms.Button();
            this.BulletinBtn = new System.Windows.Forms.Button();
            this.classeBtn = new System.Windows.Forms.Button();
            mainPanel = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.controlPanel.Controls.Add(this.homeBtn);
            this.controlPanel.Controls.Add(this.eleveBtn);
            this.controlPanel.Controls.Add(this.BulletinBtn);
            this.controlPanel.Controls.Add(this.classeBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(231, 753);
            this.controlPanel.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(-3, 175);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(237, 57);
            this.homeBtn.TabIndex = 3;
            this.homeBtn.Text = "ACCUEIL";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // eleveBtn
            // 
            this.eleveBtn.BackColor = System.Drawing.Color.Transparent;
            this.eleveBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eleveBtn.Image = ((System.Drawing.Image)(resources.GetObject("eleveBtn.Image")));
            this.eleveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eleveBtn.Location = new System.Drawing.Point(-3, 229);
            this.eleveBtn.Name = "eleveBtn";
            this.eleveBtn.Size = new System.Drawing.Size(237, 57);
            this.eleveBtn.TabIndex = 2;
            this.eleveBtn.Text = "ELEVE";
            this.eleveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eleveBtn.UseVisualStyleBackColor = false;
            this.eleveBtn.Click += new System.EventHandler(this.eleveBtn_Click);
            // 
            // BulletinBtn
            // 
            this.BulletinBtn.BackColor = System.Drawing.Color.Transparent;
            this.BulletinBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletinBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BulletinBtn.Image = ((System.Drawing.Image)(resources.GetObject("BulletinBtn.Image")));
            this.BulletinBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BulletinBtn.Location = new System.Drawing.Point(-3, 328);
            this.BulletinBtn.Name = "BulletinBtn";
            this.BulletinBtn.Size = new System.Drawing.Size(237, 57);
            this.BulletinBtn.TabIndex = 1;
            this.BulletinBtn.Text = "SCOLARITE";
            this.BulletinBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BulletinBtn.UseVisualStyleBackColor = false;
            this.BulletinBtn.Click += new System.EventHandler(this.BulletinBtn_Click);
            // 
            // classeBtn
            // 
            this.classeBtn.BackColor = System.Drawing.Color.Transparent;
            this.classeBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.classeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classeBtn.Location = new System.Drawing.Point(-3, 279);
            this.classeBtn.Name = "classeBtn";
            this.classeBtn.Size = new System.Drawing.Size(237, 55);
            this.classeBtn.TabIndex = 0;
            this.classeBtn.Text = "CLASSE";
            this.classeBtn.UseVisualStyleBackColor = false;
            this.classeBtn.Click += new System.EventHandler(this.classeBtn_Click);
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.AutoSize = true;
            mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            mainPanel.Location = new System.Drawing.Point(231, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(1474, 753);
            mainPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1705, 753);
            this.Controls.Add(mainPanel);
            this.Controls.Add(this.controlPanel);
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "Main";
            this.Text = "Prytian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button eleveBtn;
        private System.Windows.Forms.Button BulletinBtn;
        private System.Windows.Forms.Button classeBtn;
        private System.Windows.Forms.Button homeBtn;
        public static System.Windows.Forms.Panel mainPanel;
    }
}

