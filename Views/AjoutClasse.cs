using Nozel.Controller;
using Nozel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nozel.Views
{
    public partial class AjoutClasse : Form
    {
        private Classe classe = new Classe();
        private ClasseController control = new ClasseController();
        public AjoutClasse()
        {
            InitializeComponent();
            LoadData();
        }

        private void designation_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void LoadData()
        {
            List<Classe> classes;
            classes = control.FindAll();
            ClasseDataGrid.Rows.Clear();
            foreach (Classe elt in classes)
            {
                ClasseDataGrid.Rows.Add();
                ClasseDataGrid.Rows[ClasseDataGrid.Rows.Count - 1].Cells["id"].Value = elt.IdClasse;
                ClasseDataGrid.Rows[ClasseDataGrid.Rows.Count - 1].Cells["Designa"].Value = elt.Designation;
                ClasseDataGrid.Rows[ClasseDataGrid.Rows.Count - 1].Cells["Desc"].Value = elt.Description;
                ClasseDataGrid.Rows[ClasseDataGrid.Rows.Count - 1].Cells["Effectif"].Value = 25;
                
            }
        }
       

        private void saveClasseBtn_Click(object sender, EventArgs e)
        {
            classe.Description = description.Text;
            classe.Designation = designation.Text;
            if(classe.IdClasse == 0)
            {
                //Console.WriteLine("ajout");
                control.InsertClasse(classe);
            } else
            {
                //Console.WriteLine("modif");
                control.UpdateClasse(classe);
            }
            description.Clear();
            designation.Clear();
            classe = new Classe();
            LoadData();
        }

        private void ClasseDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ClasseDataGrid.Columns["Modifier"].Index)
            {
                classe.IdClasse= (Int32)ClasseDataGrid[0, e.RowIndex].Value;
                saveClasseBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                saveClasseBtn.Text = "MODIFIER";
                designation.Text = (string)ClasseDataGrid[1, e.RowIndex].Value;
                description.Text= (string)ClasseDataGrid[2, e.RowIndex].Value;
            } else if (e.RowIndex >= 0 && e.ColumnIndex == ClasseDataGrid.Columns["Supprimer"].Index)
            {
                string message = "Voulez-vous supprimer cette classe";
                string title = "Suppression";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    classe.IdClasse = (Int32)ClasseDataGrid[0, e.RowIndex].Value;
                    classe.Designation = (string)ClasseDataGrid[1, e.RowIndex].Value;
                    classe.Description = (string)ClasseDataGrid[2, e.RowIndex].Value;
                    control.DeleteClasse(classe);
                    LoadData();
                    Console.WriteLine("suppression"+classe.IdClasse);
                    classe = new Classe();
                } else
                {
                    Console.WriteLine("biib");
                }    
            }
            else
            {
                return;
            }
        }

        private void annulerClasseBtn_Click(object sender, EventArgs e)
        {
            description.Clear();
            designation.Clear();
            saveClasseBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
            saveClasseBtn.Text = "ENREGISTRER";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
