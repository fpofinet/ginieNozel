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
        }

        private void payerBtn_Click(object sender, EventArgs e)
        {
            scolarite = scCtrl.FindByEleve(eleve.IdEleve);
            if(scolarite == null)
            {
                scolarite = new Scolarite();
                scolarite.IdEleve = eleve.IdEleve;
                scolarite.IdClasse = classe.IdClasse;
                scolarite.Total = 10;
                scCtrl.InsertScolarite(scolarite);
                tranche.IdScolarite = scCtrl.FindByEleve(eleve.IdEleve).Id;
                tranche.Montant = int.Parse(montant.Text);
                trCtrl.InsertTranche(tranche);
            }
            else
            {
                tranche.IdScolarite = scolarite.Id;
                tranche.Montant = int.Parse(montant.Text);
                trCtrl.InsertTranche(tranche);
            }
        }

        private void montant_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
    