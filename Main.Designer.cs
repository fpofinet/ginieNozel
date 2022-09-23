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
            this.home = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eleve = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.classe = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.scolarite = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            mainPanel = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.home.SuspendLayout();
            this.eleve.SuspendLayout();
            this.classe.SuspendLayout();
            this.scolarite.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.controlPanel.Controls.Add(this.home);
            this.controlPanel.Controls.Add(this.eleve);
            this.controlPanel.Controls.Add(this.classe);
            this.controlPanel.Controls.Add(this.scolarite);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(231, 753);
            this.controlPanel.TabIndex = 0;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.home.Controls.Add(this.label1);
            this.home.Location = new System.Drawing.Point(0, 101);
            this.home.Margin = new System.Windows.Forms.Padding(0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(234, 60);
            this.home.TabIndex = 7;
            this.home.Click += new System.EventHandler(this.home_Click);
            this.home.MouseEnter += new System.EventHandler(this.home_MouseEnter);
            this.home.MouseLeave += new System.EventHandler(this.home_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCUEIL";
            this.label1.Click += new System.EventHandler(this.home_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // eleve
            // 
            this.eleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.eleve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eleve.Controls.Add(this.label2);
            this.eleve.Location = new System.Drawing.Point(0, 161);
            this.eleve.Margin = new System.Windows.Forms.Padding(0);
            this.eleve.Name = "eleve";
            this.eleve.Size = new System.Drawing.Size(234, 60);
            this.eleve.TabIndex = 6;
            this.eleve.Click += new System.EventHandler(this.eleve_Click);
            this.eleve.MouseEnter += new System.EventHandler(this.home_MouseEnter);
            this.eleve.MouseLeave += new System.EventHandler(this.home_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ELEVE";
            this.label2.Click += new System.EventHandler(this.eleve_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // classe
            // 
            this.classe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.classe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classe.Controls.Add(this.label3);
            this.classe.Location = new System.Drawing.Point(0, 221);
            this.classe.Margin = new System.Windows.Forms.Padding(0);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(234, 60);
            this.classe.TabIndex = 5;
            this.classe.Click += new System.EventHandler(this.classe_Click);
            this.classe.MouseEnter += new System.EventHandler(this.home_MouseEnter);
            this.classe.MouseLeave += new System.EventHandler(this.home_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "classe";
            this.label3.Click += new System.EventHandler(this.classe_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // scolarite
            // 
            this.scolarite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.scolarite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scolarite.Controls.Add(this.label4);
            this.scolarite.Location = new System.Drawing.Point(0, 281);
            this.scolarite.Margin = new System.Windows.Forms.Padding(0);
            this.scolarite.Name = "scolarite";
            this.scolarite.Size = new System.Drawing.Size(234, 60);
            this.scolarite.TabIndex = 4;
            this.scolarite.Click += new System.EventHandler(this.scolarite_Click);
            this.scolarite.MouseEnter += new System.EventHandler(this.home_MouseEnter);
            this.scolarite.MouseLeave += new System.EventHandler(this.home_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
           // this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "SCOLARITE";
            this.label4.Click += new System.EventHandler(this.scolarite_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
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
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.eleve.ResumeLayout(false);
            this.eleve.PerformLayout();
            this.classe.ResumeLayout(false);
            this.classe.PerformLayout();
            this.scolarite.ResumeLayout(false);
            this.scolarite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel eleve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel classe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel scolarite;
        private System.Windows.Forms.Label label4;
        public static System.Windows.Forms.Panel mainPanel;
    }
}

