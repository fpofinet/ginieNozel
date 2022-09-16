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

namespace Nozel.Views
{
    public partial class FormEleve : Form
    {
        private Eleve eleve = new Eleve();
        private EleveController eleveControl = new EleveController();
        private List<Classe> cla = new List<Classe>();
        private ClasseController clCtrl= new ClasseController();
      
        public FormEleve()
        {
            InitializeComponent();
            LoadData();
        }
        public FormEleve(int idEleve)
        {
            InitializeComponent();
            LoadData();
            cla = clCtrl.FindAll();
            eleve = eleveControl.FindById(idEleve);
            nom.Text= eleve.Nom;
            prenom.Text= eleve.Prenom ;
            dateNaiss.Text = eleve.DateNaiss;
            sexe.Text = eleve.Sexe;
            classe.SelectedItem = clCtrl.FindById(eleve.IdClasse).Designation;
            nomTuteur.Text=eleve.NomTuteur;
            contactTuteur.Text = eleve.ContactTuteur;
            adresse.Text = eleve.Adresse;
        }

        private void LoadData()
        {
            cla = clCtrl.FindAll();
            foreach (Classe c in cla)
            {
                classe.Items.Add(c.Designation);
            }
            if (cla.Count > 0)
            {
                classe.SelectedIndex = 0;
            }
        }
        private void enregistrerBtn_Click(object sender, EventArgs e)
        {
            eleve.Nom = nom.Text;
            eleve.Prenom=prenom.Text;
            eleve.DateNaiss = dateNaiss.Value.ToString().Substring(0,dateNaiss.Value.ToString().IndexOf(" "));
            eleve.Sexe = sexe.Text;
            eleve.IdClasse = clCtrl.FindByDesignation(classe.Text).IdClasse;
            eleve.NomTuteur = nomTuteur.Text;
            eleve.ContactTuteur= contactTuteur.Text;
            eleve.Adresse= adresse.Text;
            if (eleve.IdEleve == 0)
            {
                eleveControl.InsertEleve(eleve);
                clCtrl.addOneEleve(classe.Text);
            }
            else
            {
                eleveControl.UpdateEleve(eleve);
            }
            nom.Clear();
            prenom.Clear();
            sexe.ClearSelected();
            classe.SelectedIndex = 0;
            contactTuteur.Clear();
            nomTuteur.Clear();
            adresse.Clear();
            eleve = new Eleve();
            Utils.Utils.Open(new ListeEleve(), Main.mainPanel);
        }

        private void annulerBtn_Click(object sender, EventArgs e)
        {
            nom.Clear();
            prenom.Clear();
            sexe.ClearSelected();
            contactTuteur.Clear();
            nomTuteur.Clear();
            adresse.Clear();
            enregistrerBtn.Font =new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enregistrerBtn.Text = "ENREGISTRER";
        }

        private void backEleveBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ListeEleve(), Main.mainPanel);
        }
    }
}
