namespace Nozel.Views
{
    partial class PayementForm
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
            this.title_label = new System.Windows.Forms.Label();
            this.classe_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.montant_label = new System.Windows.Forms.Label();
            this.mainPayement_panel = new System.Windows.Forms.Panel();
            this.annulerBtn = new System.Windows.Forms.Button();
            this.payerBtn = new System.Windows.Forms.Button();
            this.montant = new System.Windows.Forms.TextBox();
            this.classeBox = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.head_panel = new System.Windows.Forms.Panel();
            this.mainPayement_panel.SuspendLayout();
            this.head_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title_label.Location = new System.Drawing.Point(693, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(570, 53);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "PAYEMENT SCOLARITE";
            // 
            // classe_label
            // 
            this.classe_label.AutoSize = true;
            this.classe_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classe_label.Location = new System.Drawing.Point(50, 95);
            this.classe_label.Name = "classe_label";
            this.classe_label.Size = new System.Drawing.Size(71, 26);
            this.classe_label.TabIndex = 1;
            this.classe_label.Text = "Classe";
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(50, 35);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(58, 26);
            this.nom_label.TabIndex = 2;
            this.nom_label.Text = "Nom";
            // 
            // montant_label
            // 
            this.montant_label.AutoSize = true;
            this.montant_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant_label.Location = new System.Drawing.Point(50, 164);
            this.montant_label.Name = "montant_label";
            this.montant_label.Size = new System.Drawing.Size(89, 26);
            this.montant_label.TabIndex = 3;
            this.montant_label.Text = "Montant";
            // 
            // mainPayement_panel
            // 
            this.mainPayement_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPayement_panel.Controls.Add(this.annulerBtn);
            this.mainPayement_panel.Controls.Add(this.payerBtn);
            this.mainPayement_panel.Controls.Add(this.montant);
            this.mainPayement_panel.Controls.Add(this.classeBox);
            this.mainPayement_panel.Controls.Add(this.nom);
            this.mainPayement_panel.Controls.Add(this.nom_label);
            this.mainPayement_panel.Controls.Add(this.montant_label);
            this.mainPayement_panel.Controls.Add(this.classe_label);
            this.mainPayement_panel.Location = new System.Drawing.Point(527, 200);
            this.mainPayement_panel.Name = "mainPayement_panel";
            this.mainPayement_panel.Size = new System.Drawing.Size(641, 348);
            this.mainPayement_panel.TabIndex = 4;
            // 
            // annulerBtn
            // 
            this.annulerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.annulerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.annulerBtn.Location = new System.Drawing.Point(123, 247);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(154, 54);
            this.annulerBtn.TabIndex = 8;
            this.annulerBtn.Text = "ANNULER";
            this.annulerBtn.UseVisualStyleBackColor = false;
            // 
            // payerBtn
            // 
            this.payerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(46)))));
            this.payerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payerBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.payerBtn.Location = new System.Drawing.Point(380, 247);
            this.payerBtn.Name = "payerBtn";
            this.payerBtn.Size = new System.Drawing.Size(178, 54);
            this.payerBtn.TabIndex = 7;
            this.payerBtn.Text = "PAYER";
            this.payerBtn.UseVisualStyleBackColor = false;
            this.payerBtn.Click += new System.EventHandler(this.payerBtn_Click);
            // 
            // montant
            // 
            this.montant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.montant.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant.Location = new System.Drawing.Point(209, 165);
            this.montant.Multiline = true;
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(349, 39);
            this.montant.TabIndex = 6;
            // 
            // classeBox
            // 
            this.classeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.classeBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeBox.Location = new System.Drawing.Point(209, 95);
            this.classeBox.Multiline = true;
            this.classeBox.Name = "classeBox";
            this.classeBox.Size = new System.Drawing.Size(349, 39);
            this.classeBox.TabIndex = 5;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.nom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(209, 35);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(349, 39);
            this.nom.TabIndex = 4;
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.head_panel.Controls.Add(this.title_label);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(1789, 73);
            this.head_panel.TabIndex = 5;
            // 
            // PayementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1789, 754);
            this.Controls.Add(this.head_panel);
            this.Controls.Add(this.mainPayement_panel);
            this.Name = "PayementForm";
            this.Text = "PayementForm";
            this.Load += new System.EventHandler(this.PayementForm_Load);
            this.mainPayement_panel.ResumeLayout(false);
            this.mainPayement_panel.PerformLayout();
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label classe_label;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.Label montant_label;
        private System.Windows.Forms.Panel mainPayement_panel;
        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.TextBox classeBox;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button annulerBtn;
        private System.Windows.Forms.Button payerBtn;
        private System.Windows.Forms.Panel head_panel;
    }
}