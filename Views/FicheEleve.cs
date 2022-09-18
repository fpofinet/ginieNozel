using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nozel.Controller;
using Nozel.Models;

namespace Nozel.Views
{
    public partial class FicheEleve : Form
    {
        private Eleve eleve;
        private EleveController elclt = new EleveController();
        private ClasseController clt = new ClasseController();
        public FicheEleve()
        {
            InitializeComponent();
        }

        public FicheEleve(int id)
        {
            InitializeComponent();
            eleve =elclt.FindById(id);
            matriculeData.Text = eleve.Matricule;
            nomData.Text= eleve.Nom;
            prenomData.Text= eleve.Prenom;
            sexeData.Text = eleve.Sexe;
            ageData.Text = Utils.Utils.CalcAge(eleve.DateNaiss).ToString();
            nomTuteurData.Text = eleve.NomTuteur;
            contactTuteurData.Text = eleve.ContactTuteur;
            adresseData.Text = eleve.Adresse;
            classeData.Text = clt.FindById(eleve.IdClasse).Designation;
            moneyData.Text = elclt.GetSolde(eleve.IdEleve).ToString()+" FCFA  sur "+ clt.FindById(eleve.IdClasse).Frais+" FCFA ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ListeEleve(), Main.mainPanel);
        }
    }
}
