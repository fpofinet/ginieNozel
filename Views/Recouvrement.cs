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
    public partial class Recouvrement : Form
    {
        private TrancheController trc = new TrancheController();
        private ClasseController cl = new ClasseController();
        public Recouvrement()
        {
            InitializeComponent();
            loadData();

        }

        private void loadData()
        {
            List<Tranche> tranches = new List<Tranche>();
            tranches = trc.FindAll();
            dataGrid.Rows.Clear();
            foreach (Tranche elt in tranches)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[dataGrid.Rows.Count - 1].Cells["id"].Value = elt.IdTranche;
                dataGrid.Rows[dataGrid.Rows.Count - 1].Cells["nom"].Value = trc.getEleve(elt.IdTranche).Nom;
                dataGrid.Rows[dataGrid.Rows.Count - 1].Cells["prenom"].Value = trc.getEleve(elt.IdTranche).Prenom;
                dataGrid.Rows[dataGrid.Rows.Count - 1].Cells["classe"].Value = cl.FindById(trc.getEleve(elt.IdTranche).IdClasse).Designation;
                dataGrid.Rows[dataGrid.Rows.Count - 1].Cells["montant"].Value = elt.Montant +" FCFA ";
                dataGrid.Rows[dataGrid.Rows.Count - 1].Cells["date"].Value = elt.DateVersement.ToString();
            }
        }
    }
}
