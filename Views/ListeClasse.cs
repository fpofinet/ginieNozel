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
using Nozel;
using Nozel.Views;

namespace Nozel.Views
{
    public partial class FormClasse : Form
    {
        ClasseController cl = new ClasseController();
        public FormClasse()
        {
            InitializeComponent();
            //ClasseController cl = new ClasseController();
            LoadData();
        }

        private void LoadData()
        {
            //ClasseController cl = new ClasseController();
            List<Classe> classes = new List<Classe>();
            classes = cl.FindAll();
            classeDataGrid.Rows.Clear(); 
            foreach (Classe elt in classes)
            {
                classeDataGrid.Rows.Add();
                classeDataGrid.Rows[classeDataGrid.Rows.Count-1].Cells["id"].Value = elt.IdClasse;
                classeDataGrid.Rows[classeDataGrid.Rows.Count-1].Cells["designation"].Value = elt.Designation;
                classeDataGrid.Rows[classeDataGrid.Rows.Count-1].Cells["description"].Value = elt.Description;
                classeDataGrid.Rows[classeDataGrid.Rows.Count-1].Cells["effectif"].Value = elt.Effectif;
            }
        }
        private void FormClasse_Load(object sender, EventArgs e)
        {

        }

        private void AjoutClasseBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.AddLog("boutton new classe click");
            Utils.Utils.Open(new AjoutClasse(), Main.mainPanel);
        }

        private void classeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == classeDataGrid.Columns["Modifier"].Index)
            {
                Utils.Utils.AddLog("boutton modifier classe click");
                Utils.Utils.Open(new AjoutClasse((Int32)classeDataGrid[0, e.RowIndex].Value), Main.mainPanel);
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == classeDataGrid.Columns["Supprimer"].Index)
            {
                Utils.Utils.AddLog("boutton supprimer classe click");
                string message = "Voulez-vous supprimer cette classe ?";
                string title = "Suppression";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Classe classe = new Classe();
                    classe.IdClasse = (Int32)classeDataGrid[0, e.RowIndex].Value;
                    cl.DeleteClasse(classe);
                }
                LoadData();
            }
            else
            {
                return;
            }
        }
    }
}
