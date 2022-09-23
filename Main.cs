using Nozel.Controller;
using Nozel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nozel.Views;
using Utils;

namespace Nozel
{
    public partial class Main : Form
    {
       public static Form activeForm;
        public Main()
        {
            InitializeComponent();
            Utils.Utils.Open(new HomeForm(), mainPanel); 
            //EleveController c = new EleveController();
            //Console.WriteLine(c.FindAllByAnnee("2021/2022").Count);
        }
        public void openForm(Form active)
        {
            //if(activeForm != null)
            //{
            //    activeForm.Close();
            //}
            //activeForm = active;
            //active.TopLevel = false;
            //active.FormBorderStyle = FormBorderStyle.None;  
            //active.Dock= DockStyle.Fill;
            //this.mainPanel.Controls.Add(active);
            //this.mainPanel.Tag = active;
            //active.BringToFront();
            //active.Show();
            //this.nameLabel.Text = active.Text;


        }
        private void eleveBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ListeEleve(), mainPanel);
        }

        private void classeBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new FormClasse(), mainPanel);
        }

        private void BulletinBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ScolariteForm(), mainPanel);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new HomeForm(), mainPanel);
        }

        private void home_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new HomeForm(), mainPanel);
        }

        private void eleve_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ListeEleve(), mainPanel);
        }

        private void classe_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new FormClasse(), mainPanel);
        }

        private void scolarite_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ScolariteForm(), mainPanel);
        }
        private void MEnter(Panel obj)
        {
            obj.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));

        }

        private void MOut(Panel obj)
        {
            obj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            
        }

        private void MEnterLabel(Label obj)
        {
            obj.Parent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
        }

        private void MOutLabel(Label obj)
        {
            obj.Parent.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
        }

        private void home_MouseLeave(object sender, EventArgs e)
        {
            MOut((Panel)sender);
        }

        private void home_MouseEnter(object sender, EventArgs e)
        {
            MEnter((Panel)sender);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MEnterLabel((Label)sender);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            MOutLabel((Label)sender);
        }
    }
}
