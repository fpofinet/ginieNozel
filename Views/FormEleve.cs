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
            cla = clCtrl.FindAll();
            foreach (Classe c in cla)
            {
                classe.Items.Add(c.Designation);
            }
            classe.SelectedIndex = 0;
            
        }

        private void LoadData()
        {
            List<Eleve> eleves;
            eleves = eleveControl.FindAll();
            eleveDataGrid.Rows.Clear();
            foreach (Eleve elt in eleves)
            {
                eleveDataGrid.Rows.Add();
                //Console.WriteLine(eleveDataGrid.Rows.Count);
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["IdD"].Value = elt.IdEleve;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["matriculeD"].Value = elt.Matricule;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["NomD"].Value = elt.Nom;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["PrenomD"].Value = elt.Prenom;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["SexeD"].Value = elt.Sexe;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["DateNaissD"].Value = elt.DateNaiss;
                eleveDataGrid.Rows[eleveDataGrid.Rows.Count - 1].Cells["ClasseD"].Value = clCtrl.FindById(elt.IdClasse).Designation;

            }
        }
        private void enregistrerBtn_Click(object sender, EventArgs e)
        {
            eleve.Nom = nom.Text;
            eleve.Prenom=prenom.Text;
            eleve.Matricule=matricule.Text;
            eleve.DateNaiss = dateNaiss.Value.ToString().Substring(0,dateNaiss.Value.ToString().IndexOf(" "));
            eleve.Sexe = sexe.Text;
            eleve.IdClasse = clCtrl.FindByDesignation(classe.Text).IdClasse;
            if (eleve.IdEleve == 0)
            {
                Console.WriteLine("ajout");
                eleveControl.InsertEleve(eleve);
            }
            else
            {
                Console.WriteLine("modif");
                eleveControl.UpdateEleve(eleve);
            }
            nom.Clear();
            prenom.Clear();
            matricule.Clear();
            sexe.ClearSelected();
            classe.SelectedIndex = 0;
            eleve = new Eleve();
            LoadData();
        }

        private void eleveDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == eleveDataGrid.Columns["Modifier"].Index)
            {
                eleve.IdEleve = (Int32)eleveDataGrid[0, e.RowIndex].Value;
                enregistrerBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                enregistrerBtn.Text = "MODIFIER";
                matricule.Text = (string)eleveDataGrid[1, e.RowIndex].Value;
                nom.Text = (string)eleveDataGrid[2, e.RowIndex].Value;
                prenom.Text = (string)eleveDataGrid[3, e.RowIndex].Value;
                sexe.SelectedItem=  (string)eleveDataGrid[4, e.RowIndex].Value;
                dateNaiss.Text = (string)eleveDataGrid[5, e.RowIndex].Value;
                classe.SelectedItem=(string)eleveDataGrid[6, e.RowIndex].Value;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == eleveDataGrid.Columns["Supprimer"].Index)
            {

                string message = "Voulez-vous supprimer cette classe";
                string title = "Suppression";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    eleve.IdEleve = (Int32)eleveDataGrid[0, e.RowIndex].Value;

                    //classe.Designation = (string)eleveDataGrid[1, e.RowIndex].Value;
                    //classe.Description = (string)eleveDataGrid[2, e.RowIndex].Value;
                    eleveControl.DeleteEleve(eleve);
                    LoadData();
                    Console.WriteLine("suppression" + eleve.IdEleve);
                    eleve = new Eleve();
                }
                else
                {
                    Console.WriteLine("biib");
                }
            }
            else
            {
                return;
            }
        }

        private void annulerBtn_Click(object sender, EventArgs e)
        {
            nom.Clear();
            prenom.Clear();
            matricule.Clear();
            sexe.ClearSelected();
            enregistrerBtn.Font =new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enregistrerBtn.Text = "ENREGISTRER";
        }
    }
}
