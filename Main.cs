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
            Eleve el = new Eleve();
            EleveController c = new EleveController();

           // Console.WriteLine(c.GetSolde(2));
           
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
            // Utils.Utils.Open(new FormEleve(), mainPanel);
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
    }
}
