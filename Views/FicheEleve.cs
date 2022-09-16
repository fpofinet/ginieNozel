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
    public partial class FicheEleve : Form
    {
        Eleve el ;
        EleveController elc = new EleveController();
        ClasseController ccl = new ClasseController();
        public FicheEleve()
        {
            InitializeComponent();
        }

        public FicheEleve(int ideEl)
        {
            InitializeComponent();
            el = elc.FindById(ideEl);
            matriculeData.Text = el.Matricule;
            nomData.Text = el.Nom;
            prenomData.Text = el.Prenom;   
            sexeData.Text = el.Sexe;    
            dateNaissData.Text = el.DateNaiss +" ("+Utils.Utils.CalcAge(el.DateNaiss) +" ans )";
            classeData.Text = ccl.FindById(el.IdClasse).Designation;
            mtPayerData.Text = elc.GetSolde(el.IdEleve).ToString()+" FCFA sur "+ ccl.FindById(el.IdClasse).Frais.ToString()+" FCFA";
            restePayerData.Text =(ccl.FindById(el.IdClasse).Frais - elc.GetSolde(el.IdEleve)).ToString()+" FCFA";
        }
    }
}
