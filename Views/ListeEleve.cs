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
    public partial class ListeEleve : Form
    {
        private EleveController eleveControl = new EleveController();
        private ClasseController clCtrl = new ClasseController();
        private AnneeController anneeControl = new AnneeController();   
       
        public ListeEleve()
        {
            List<Classe> cla;
            List<Annee> ans;
            InitializeComponent();
            LoadData();
            cla = clCtrl.FindAll();
            ans = anneeControl.FindAll();
            classeBox.Items.Add("Tous");
            anneeCB.Items.Add("Tous");
            foreach (Annee annee in ans)
            {
                anneeCB.Items.Add(annee.Anne);
            }
            
            foreach (Classe c in cla)
            {
                classeBox.Items.Add(c.Designation);
            }  
        }

        private void LoadData()
        {
            List<Eleve> eleves;
            eleves = eleveControl.FindAll();
            eleveDataGrid.Rows.Clear();
            foreach (Eleve elt in eleves)
            {
                eleveDataGrid.Rows.Add();
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["id"].Value = elt.IdEleve;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["matricule"].Value = elt.Matricule;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["nom"].Value = elt.Nom;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["prenom"].Value = elt.Prenom;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["sexe"].Value = elt.Sexe;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["age"].Value = Utils.Utils.CalcAge(elt.DateNaiss);
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["dateNaiss"].Value = elt.DateNaiss;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["classe"].Value = clCtrl.FindById(elt.IdClasse).Designation;
            }
        }

        private void addEleveBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("boutton new eleve click");
            Utils.Utils.Open(new FormEleve(), Main.mainPanel);
        }

        private void eleveDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0 && e.ColumnIndex == eleveDataGrid.Columns["Modifier"].Index)
            {
                Utils.Utils.AddLog("boutton modifier eleve click");
                Utils.Utils.Open(new FormEleve((Int32)eleveDataGrid[0, e.RowIndex].Value), Main.mainPanel);
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == eleveDataGrid.Columns["Supprimer"].Index)
            {
                Utils.Utils.AddLog("boutton supprimer eleve click");
                string message = "Voulez-vous supprimer cet eleve ?";
                string title = "Suppression";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Eleve eleve = new Eleve();
                    eleve.IdEleve = (Int32)eleveDataGrid[0, e.RowIndex].Value;
                    eleveControl.DeleteEleve(eleve);
                }
                LoadData();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == eleveDataGrid.Columns["details"].Index)
            {
                Utils.Utils.AddLog("boutton details eleve click");
                Utils.Utils.Open(new FicheEleve((Int32)eleveDataGrid[0, e.RowIndex].Value), Main.mainPanel);
            }
            else
            {
                return;
            }
        }

        private void rechercherBox_TextChanged(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("recherche eleve");
            List<Eleve> els;
            els=eleveControl.Search(rechercherBox.Text);
            if (els.Count > 0)
            {
                eleveDataGrid.Rows.Clear();
                foreach (Eleve elt in els)
                {
                    eleveDataGrid.Rows.Add();
                    eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["id"].Value = elt.IdEleve;
                    eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["matricule"].Value = elt.Matricule;
                    eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["nom"].Value = elt.Nom;
                    eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["prenom"].Value = elt.Prenom;
                    eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["sexe"].Value = elt.Sexe;
                    eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["age"].Value = Utils.Utils.CalcAge(elt.DateNaiss);
                    eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["dateNaiss"].Value = elt.DateNaiss;
                    eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["classe"].Value = clCtrl.FindById(elt.IdClasse).Designation;
                }
            }
        }

        private void classeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = classeBox.SelectedItem.ToString();
            List<Eleve> result = new List<Eleve>();
            if(item.ToUpper() == "TOUS")
            {
                result = eleveControl.FindAll();
            }
            else
            {
                result = eleveControl.FindAllByClasse(item);
            }
            
            eleveDataGrid.Rows.Clear();
            foreach (Eleve elt in result)
            {
                eleveDataGrid.Rows.Add();
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["id"].Value = elt.IdEleve;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["matricule"].Value = elt.Matricule;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["nom"].Value = elt.Nom;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["prenom"].Value = elt.Prenom;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["sexe"].Value = elt.Sexe;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["age"].Value = Utils.Utils.CalcAge(elt.DateNaiss);
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["dateNaiss"].Value = elt.DateNaiss;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["classe"].Value = clCtrl.FindById(elt.IdClasse).Designation;
            }
        }

        private void anneeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = anneeCB.SelectedItem.ToString();
            List<Eleve> data = new List<Eleve>();
            if (item.ToUpper() == "TOUS")
            {
                data = eleveControl.FindAll();
            }
            else
            {
                data = eleveControl.FindAllByAnnee(item);
            }

            eleveDataGrid.Rows.Clear();
            foreach (Eleve elt in data)
            {
                eleveDataGrid.Rows.Add();
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["id"].Value = elt.IdEleve;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["matricule"].Value = elt.Matricule;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["nom"].Value = elt.Nom;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["prenom"].Value = elt.Prenom;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["sexe"].Value = elt.Sexe;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["age"].Value = Utils.Utils.CalcAge(elt.DateNaiss);
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["dateNaiss"].Value = elt.DateNaiss;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["classe"].Value = clCtrl.FindById(elt.IdClasse).Designation;
            }
        }
    }
}
