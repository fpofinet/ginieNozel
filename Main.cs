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
            //Connexion cx = new Connexion();
           // EleveController ec = new EleveController();
            //Eleve e = new Eleve(1, "001", "sophiebb", "altamira", "12/10/2003", 1,2) ;
            //var data =ec.FindById(1);
            //ClasseController cs = new ClasseController();
            //Classe c = new Classe("cp2","classe de cp2");
            //c.IdClasse = 2;
            //Classe c2 = new Classe("cp1", "classe de cp1");
            //c.IdClasse = 1;
            //cs.InsertClasse(c);
            //cs.InsertClasse(c2);
            //Console.WriteLine(data.Nom);
        }
        public Main(int a)
        {

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
            Utils.Utils.Open(new Views.FormEleve(), mainPanel);
            //openForm(new Views.FormEleve());
        }

        private void classeBtn_Click(object sender, EventArgs e)
        {
            //openForm(new Views.AjoutClasse());
            Utils.Utils.Open(new Views.AjoutClasse(), mainPanel);
        }

        private void BulletinBtn_Click(object sender, EventArgs e)
        {

            Utils.Utils.Open(new Views.ScolariteForm(), mainPanel);
           // openForm(new Views.ScolariteForm());
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void noteBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("pupo");
        }
    }
}
