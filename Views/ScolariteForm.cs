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
using Utils;
using Nozel;

namespace Nozel.Views
{
    public partial class ScolariteForm : Form
    {
        private EleveController elCtrl = new EleveController();
        private ClasseController clCtrl = new ClasseController();
        private List<Eleve> els = new List<Eleve>();
        public ScolariteForm()
        {
            InitializeComponent();
        }

        private void ScolariteForm_Load(object sender, EventArgs e)
        {
        }

        private void rechercher_TextChanged(object sender, EventArgs e)
        {
            els = elCtrl.Search(rechercher.Text);
            if(els.Count > 0)
            {
                LoadData();
            } else
            {
                string message = "Aucun resultat trouvé";
                string title = "Recherche";
                MessageBox.Show(message, title);
                rechercherData.Rows.Clear();
            }
            
        }
        private void LoadData()
        {
            rechercherData.Rows.Clear();
            foreach (Eleve elt in els)
            {
                rechercherData.Rows.Add();
                rechercherData.Rows[rechercherData.Rows.Count - 1].Cells["id"].Value = elt.IdEleve;
                rechercherData.Rows[rechercherData.Rows.Count - 1].Cells["nom"].Value = elt.Nom;
                rechercherData.Rows[rechercherData.Rows.Count - 1].Cells["prenom"].Value = elt.Prenom;
                rechercherData.Rows[rechercherData.Rows.Count - 1].Cells["sexe"].Value = elt.Sexe;
                rechercherData.Rows[rechercherData.Rows.Count - 1].Cells["classe"].Value = clCtrl.FindById(elt.IdClasse).Designation;

            }
        }

        private void rechercherData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == rechercherData.Columns["payer"].Index)
            {
                Utils.Utils.Open(new PayementForm((Int32)rechercherData[0, e.RowIndex].Value, clCtrl.FindByDesignation((string)rechercherData[4, e.RowIndex].Value).IdClasse ), Main.mainPanel); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void nom_label_Click(object sender, EventArgs e)
        {
        }
    }
}
