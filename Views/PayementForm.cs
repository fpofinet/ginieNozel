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
    public partial class PayementForm : Form
    {
        private Eleve eleve = new Eleve();
        private Classe classe = new Classe();
        private Scolarite scolarite = new Scolarite();
        private Tranche tranche = new Tranche();
        private EleveController elCtrl = new EleveController();
        private ClasseController clCtrl = new ClasseController();
        private ScolariteController scCtrl = new ScolariteController();
        private TrancheController trCtrl = new TrancheController();
        public PayementForm()
        {
            InitializeComponent();
        }
        public PayementForm(int el,int cl)
        {
            InitializeComponent();
            eleve = elCtrl.FindById(el);
            classe = clCtrl.FindById(cl);
        }

        private void PayementForm_Load(object sender, EventArgs e)
        {
            nom.Text = eleve.Nom + " " + eleve.Prenom;
            classeBox.Text = classe.Designation;
        }

        private void payerBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("boutton payement click");
            scolarite = scCtrl.FindByEleve(eleve.IdEleve);
            if(scolarite == null)
            {
                scolarite = new Scolarite();
                scolarite.IdEleve = eleve.IdEleve;
                scolarite.IdClasse = classe.IdClasse;
                scolarite.Total = int.Parse(montant.Text);
                scCtrl.InsertScolarite(scolarite);
                tranche.IdScolarite = scCtrl.FindByEleve(eleve.IdEleve).Id;
                tranche.Montant = int.Parse(montant.Text);
                tranche.DateVersement = DateTime.Today.ToShortDateString();
                trCtrl.InsertTranche(tranche);
            }
            else
            {
                tranche.IdScolarite = scolarite.Id;
                tranche.Montant = int.Parse(montant.Text);
                tranche.DateVersement = DateTime.Today.ToShortDateString();
                trCtrl.InsertTranche(tranche);
                scCtrl.AddScolarite(scolarite.Id, int.Parse(montant.Text));
            }

            string message = "payement effectuer avec success";
            string title = "Success payement";
            
            MessageBox.Show(message, title);
            Utils.Utils.Open(new Recu(eleve.IdEleve, int.Parse(montant.Text)), Main.mainPanel) ;

        }
    }
}
    