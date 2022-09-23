namespace Nozel.Views
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.head_panel = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.countEleveLabel = new System.Windows.Forms.Label();
            this.eleveLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.recouvLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ClasseLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.countSalleLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.head_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.head_panel.Controls.Add(this.title_label);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(1875, 81);
            this.head_panel.TabIndex = 0;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title_label.Location = new System.Drawing.Point(439, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(505, 53);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "TABLEAU DE BOARD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.countEleveLabel);
            this.panel1.Controls.Add(this.eleveLabel);
            this.panel1.Location = new System.Drawing.Point(106, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 160);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.eleveLabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(264, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.eleveLabel_Click);
            // 
            // countEleveLabel
            // 
            this.countEleveLabel.AutoSize = true;
            this.countEleveLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countEleveLabel.Location = new System.Drawing.Point(7, 8);
            this.countEleveLabel.Name = "countEleveLabel";
            this.countEleveLabel.Size = new System.Drawing.Size(89, 68);
            this.countEleveLabel.TabIndex = 2;
            this.countEleveLabel.Text = "89";
            this.countEleveLabel.Click += new System.EventHandler(this.eleveLabel_Click);
            // 
            // eleveLabel
            // 
            this.eleveLabel.AutoSize = true;
            this.eleveLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleveLabel.Location = new System.Drawing.Point(13, 101);
            this.eleveLabel.Name = "eleveLabel";
            this.eleveLabel.Size = new System.Drawing.Size(118, 33);
            this.eleveLabel.TabIndex = 0;
            this.eleveLabel.Text = "ELEVES";
            this.eleveLabel.Click += new System.EventHandler(this.eleveLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.recouvLabel);
            this.panel2.Location = new System.Drawing.Point(1142, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 160);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.recouvLabel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(264, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(187, 154);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.recouvLabel_Click);
            // 
            // recouvLabel
            // 
            this.recouvLabel.AutoSize = true;
            this.recouvLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recouvLabel.Location = new System.Drawing.Point(3, 37);
            this.recouvLabel.Name = "recouvLabel";
            this.recouvLabel.Size = new System.Drawing.Size(223, 37);
            this.recouvLabel.TabIndex = 1;
            this.recouvLabel.Text = "Recouvrement";
            this.recouvLabel.Click += new System.EventHandler(this.recouvLabel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.ClasseLabel);
            this.panel3.Location = new System.Drawing.Point(626, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 160);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.ClasseLabel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(264, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(187, 154);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ClasseLabel_Click);
            // 
            // ClasseLabel
            // 
            this.ClasseLabel.AutoSize = true;
            this.ClasseLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClasseLabel.Location = new System.Drawing.Point(3, 40);
            this.ClasseLabel.Name = "ClasseLabel";
            this.ClasseLabel.Size = new System.Drawing.Size(209, 37);
            this.ClasseLabel.TabIndex = 1;
            this.ClasseLabel.Text = "Encaissement";
            this.ClasseLabel.Click += new System.EventHandler(this.ClasseLabel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(106, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 160);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.panel5.Controls.Add(this.countSalleLabel);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(626, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 160);
            this.panel5.TabIndex = 5;
            this.panel5.Click += new System.EventHandler(this.label2_Click);
            // 
            // countSalleLabel
            // 
            this.countSalleLabel.AutoSize = true;
            this.countSalleLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countSalleLabel.Location = new System.Drawing.Point(22, 8);
            this.countSalleLabel.Name = "countSalleLabel";
            this.countSalleLabel.Size = new System.Drawing.Size(59, 68);
            this.countSalleLabel.TabIndex = 2;
            this.countSalleLabel.Text = "9";
            this.countSalleLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(264, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(190, 154);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "SALLES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(1142, 381);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(454, 160);
            this.panel6.TabIndex = 6;
            this.panel6.Click += new System.EventHandler(this.param_click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(264, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(190, 157);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.param_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "AUTRES";
            this.label3.Click += new System.EventHandler(this.param_click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1875, 772);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.head_panel);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label eleveLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label recouvLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ClasseLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label countEleveLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label countSalleLabel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}