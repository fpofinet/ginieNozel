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
            LoadStat();
            CalcStat();
            
        }

       

        private void LoadData()
        {
           
        }

        private void LoadStat()
        {
            
        }

        private void CalcStat()
        {   
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new FormEleve(), Main.mainPanel);
        }

        private void ClasseLabel_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ScolariteForm(), Main.mainPanel);
        }

        private void eleveLabel_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ListeEleve(), Main.mainPanel);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new FormClasse(), Main.mainPanel);
        }
    }
}
