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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.noteBtn = new System.Windows.Forms.Button();
            this.eleveBtn = new System.Windows.Forms.Button();
            this.BulletinBtn = new System.Windows.Forms.Button();
            this.classeBtn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            mainPanel = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.controlPanel.Controls.Add(this.noteBtn);
            this.controlPanel.Controls.Add(this.eleveBtn);
            this.controlPanel.Controls.Add(this.BulletinBtn);
            this.controlPanel.Controls.Add(this.classeBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(154, 753);
            this.controlPanel.TabIndex = 0;
            // 
            // noteBtn
            // 
            this.noteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(69)))), ((int)(((byte)(131)))));
            this.noteBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.noteBtn.Location = new System.Drawing.Point(0, 275);
            this.noteBtn.Name = "noteBtn";
            this.noteBtn.Size = new System.Drawing.Size(154, 57);
            this.noteBtn.TabIndex = 3;
            this.noteBtn.Text = "NOTE";
            this.noteBtn.UseVisualStyleBackColor = false;
            this.noteBtn.Click += new System.EventHandler(this.noteBtn_Click);
            // 
            // eleveBtn
            // 
            this.eleveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(69)))), ((int)(((byte)(131)))));
            this.eleveBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleveBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.eleveBtn.Location = new System.Drawing.Point(0, 86);
            this.eleveBtn.Name = "eleveBtn";
            this.eleveBtn.Size = new System.Drawing.Size(154, 57);
            this.eleveBtn.TabIndex = 2;
            this.eleveBtn.Text = "ELEVE";
            this.eleveBtn.UseVisualStyleBackColor = false;
            this.eleveBtn.Click += new System.EventHandler(this.eleveBtn_Click);
            // 
            // BulletinBtn
            // 
            this.BulletinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(69)))), ((int)(((byte)(131)))));
            this.BulletinBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletinBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BulletinBtn.Location = new System.Drawing.Point(0, 212);
            this.BulletinBtn.Name = "BulletinBtn";
            this.BulletinBtn.Size = new System.Drawing.Size(154, 57);
            this.BulletinBtn.TabIndex = 1;
            this.BulletinBtn.Text = "SCOLARITE";
            this.BulletinBtn.UseVisualStyleBackColor = false;
            this.BulletinBtn.Click += new System.EventHandler(this.BulletinBtn_Click);
            // 
            // classeBtn
            // 
            this.classeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(69)))), ((int)(((byte)(131)))));
            this.classeBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.classeBtn.Location = new System.Drawing.Point(0, 149);
            this.classeBtn.Name = "classeBtn";
            this.classeBtn.Size = new System.Drawing.Size(154, 57);
            this.classeBtn.TabIndex = 0;
            this.classeBtn.Text = "CLASSE";
            this.classeBtn.UseVisualStyleBackColor = false;
            this.classeBtn.Click += new System.EventHandler(this.classeBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.headerPanel.Controls.Add(this.nameLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(154, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(978, 90);
            this.headerPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Location = new System.Drawing.Point(332, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(216, 49);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "PRYTIAN";
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.AutoSize = true;
            mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            mainPanel.BackColor = System.Drawing.SystemColors.Control;
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            mainPanel.Location = new System.Drawing.Point(154, 90);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(978, 663);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.controlPanel);
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.controlPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button eleveBtn;
        private System.Windows.Forms.Button BulletinBtn;
        private System.Windows.Forms.Button classeBtn;
        private System.Windows.Forms.Panel headerPanel;
        // je change de private vers static 
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button noteBtn;
        public static System.Windows.Forms.Panel mainPanel;
    }
}

