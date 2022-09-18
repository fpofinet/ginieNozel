using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nozel.Models;
using Nozel.Controller;

namespace Nozel.Views
{
    public partial class Recu : Form
    {
        Eleve el ;
        EleveController elc = new EleveController();
        ClasseController ccl = new ClasseController();
        Bitmap bmp;
        public Recu()
        {
            InitializeComponent();
        }

        public Recu(int ideEl,int montant)
        {
            InitializeComponent();
            el = elc.FindById(ideEl);
            matriculeData.Text = el.Matricule;
            nomData.Text = el.Nom +"  "+ el.Prenom;
            montantData.Text = montant.ToString()+" FCFA ";   
            sexeData.Text = el.Sexe;    
            dateNaissData.Text = DateTime.Today.ToShortDateString();
            classeData.Text = ccl.FindById(el.IdClasse).Designation;
            mtPayerData.Text = elc.GetSolde(el.IdEleve).ToString()+" FCFA sur "+ ccl.FindById(el.IdClasse).Frais.ToString()+" FCFA";
            restePayerData.Text =(ccl.FindById(el.IdClasse).Frais - elc.GetSolde(el.IdEleve)).ToString()+" FCFA";
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            // this.detailsStudentPanel
            Utils.Utils.AddLog("boutton print recu click");
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.detailsStudentPanel.Size.Width+60, this.detailsStudentPanel.Size.Height+75, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X+ this.detailsStudentPanel.Location.X+300, this.Location.Y + this.detailsStudentPanel.Location.Y+70, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
