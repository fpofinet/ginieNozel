namespace Nozel.Views
{
    partial class ParametreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.anneBox = new System.Windows.Forms.ComboBox();
            this.addAnneeBtn = new System.Windows.Forms.Button();
            this.btnCloture = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1774, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARAMETRES";
            // 
            // anneBox
            // 
            this.anneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneBox.FormattingEnabled = true;
            this.anneBox.Location = new System.Drawing.Point(40, 227);
            this.anneBox.Name = "anneBox";
            this.anneBox.Size = new System.Drawing.Size(255, 39);
            this.anneBox.TabIndex = 0;
            // 
            // addAnneeBtn
            // 
            this.addAnneeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.addAnneeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnneeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addAnneeBtn.Location = new System.Drawing.Point(40, 96);
            this.addAnneeBtn.Name = "addAnneeBtn";
            this.addAnneeBtn.Size = new System.Drawing.Size(255, 51);
            this.addAnneeBtn.TabIndex = 1;
            this.addAnneeBtn.Text = "Nouvelle Année";
            this.addAnneeBtn.UseVisualStyleBackColor = false;
            this.addAnneeBtn.Click += new System.EventHandler(this.addAnneeBtn_Click);
            // 
            // btnCloture
            // 
            this.btnCloture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(22)))));
            this.btnCloture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloture.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloture.Location = new System.Drawing.Point(40, 20);
            this.btnCloture.Name = "btnCloture";
            this.btnCloture.Size = new System.Drawing.Size(255, 51);
            this.btnCloture.TabIndex = 2;
            this.btnCloture.Text = "Cloturer Année";
            this.btnCloture.UseVisualStyleBackColor = false;
            this.btnCloture.Click += new System.EventHandler(this.btnCloture_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.anneBox);
            this.panel2.Controls.Add(this.btnCloture);
            this.panel2.Controls.Add(this.addAnneeBtn);
            this.panel2.Location = new System.Drawing.Point(52, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 303);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Annee Actuelle : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // ParametreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1774, 898);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ParametreForm";
            this.Text = "ParametreForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anneBox;
        private System.Windows.Forms.Button addAnneeBtn;
        private System.Windows.Forms.Button btnCloture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}