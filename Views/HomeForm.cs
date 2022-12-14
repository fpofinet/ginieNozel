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
    public partial class HomeForm : Form
    {
        private EleveController elCtrl = new EleveController();
        private ClasseController clCtrl = new ClasseController();
        private List<Eleve> els = new List<Eleve>();
        private List<Classe> cls = new List<Classe> ();
        public HomeForm()
        {
            InitializeComponent();
            LoadData();  
        }

       

        private void LoadData()
        {
            countEleveLabel.Text= elCtrl.FindAll().Count.ToString();
            countSalleLabel.Text = clCtrl.FindAll().Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("inscription card  click");
            Utils.Utils.Open(new FormEleve(), Main.mainPanel);
        }

        private void ClasseLabel_Click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("payement card  click");
            Utils.Utils.Open(new ScolariteForm(), Main.mainPanel);
        }

        private void eleveLabel_Click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("eleve card  click");
            Utils.Utils.Open(new ListeEleve(), Main.mainPanel);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("classe card  click");
            Utils.Utils.Open(new FormClasse(), Main.mainPanel);
        }

        private void recouvLabel_Click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("recouvrement card  click");
            Utils.Utils.Open(new Recouvrement(), Main.mainPanel);
        }

  

        private void param_click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("recouvrement card  click");
            Utils.Utils.Open(new ParametreForm(), Main.mainPanel);
        }
    }
}
