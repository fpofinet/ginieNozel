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
            cls= clCtrl.FindAll();
            foreach (Classe c in cls)
            {
                classeFiltreBox.Items.Add(c.Designation);
            }
            classeFiltreBox.SelectedIndex = 0;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            els = elCtrl.Search(search.Text);
            if (els.Count > 0)
            {
               LoadData();
            }
            else
            {
                string message = "Aucun resultat trouvé";
                string title = "Recherche";
                MessageBox.Show(message, title);
                homeDataGrid.Rows.Clear();
            }
        }

        private void LoadData()
        {
            els = elCtrl.FindAll();
            homeDataGrid.Rows.Clear();
            foreach (Eleve elt in els)
            {
                homeDataGrid.Rows.Add();
                homeDataGrid.Rows[homeDataGrid.Rows.Count - 1].Cells["id"].Value = elt.IdEleve;
                homeDataGrid.Rows[homeDataGrid.Rows.Count - 1].Cells["mat"].Value = elt.Matricule;
                homeDataGrid.Rows[homeDataGrid.Rows.Count - 1].Cells["nom"].Value = elt.Nom;
                homeDataGrid.Rows[homeDataGrid.Rows.Count - 1].Cells["prenom"].Value = elt.Prenom;
                homeDataGrid.Rows[homeDataGrid.Rows.Count - 1].Cells["sexe"].Value = elt.Sexe;
                homeDataGrid.Rows[homeDataGrid.Rows.Count - 1].Cells["classe"].Value = clCtrl.FindById(elt.IdClasse).Designation;
                homeDataGrid.Rows[homeDataGrid.Rows.Count - 1].Cells["statut"].Value = "solde";

            }
        }

        private void LoadStat()
        {
            cls = clCtrl.FindAll();
            statDataGrid.Rows.Clear();
            foreach (Classe clt in cls)
            {
                statDataGrid.Rows.Add();
                statDataGrid.Rows[statDataGrid.Rows.Count - 1].Cells["salle"].Value = clt.Designation;
                statDataGrid.Rows[statDataGrid.Rows.Count - 1].Cells["effectif"].Value = clt.Effectif;
                statDataGrid.Rows[statDataGrid.Rows.Count - 1].Cells["efajour"].Value = "29";
                statDataGrid.Rows[statDataGrid.Rows.Count - 1].Cells["efrestant"].Value = "71";
                statDataGrid.Rows[statDataGrid.Rows.Count - 1].Cells["rec"].Value = clCtrl.GetTotalScolarite(clt.IdClasse);
            }
        }

        private void CalcStat()
        {     
            double somme=0;
            double col = 0;
            int total=0;
            foreach (Classe clt in cls)
            {
                
                col += clCtrl.GetTotalScolarite(clt.IdClasse);
                somme += clt.Frais * clt.Effectif;
                total += clt.Effectif;
            }
            nRecData.Text = col + " sur " + somme;
            eleveStatutData.Text = total.ToString();
        }
    }
}
