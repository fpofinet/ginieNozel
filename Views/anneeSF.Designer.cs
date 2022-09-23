namespace Nozel.Views
{
    partial class anneeSF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.annuler);
            this.panel1.Controls.Add(this.ajouter);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(600, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 144);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 34);
            this.textBox1.TabIndex = 0;
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(46)))));
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.SystemColors.Control;
            this.ajouter.Location = new System.Drawing.Point(194, 70);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(120, 38);
            this.ajouter.TabIndex = 1;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.ForeColor = System.Drawing.SystemColors.Control;
            this.annuler.Location = new System.Drawing.Point(32, 70);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(111, 38);
            this.annuler.TabIndex = 2;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "AJOUTER UNE ANNEE SCOLAIRE";
            // 
            // anneeSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1112, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "anneeSF";
            this.Text = "anneeSF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox textBox1;
    }
}