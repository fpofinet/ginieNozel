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

namespace Nozel.Forms
{
    public partial class FormClasse : Form
    {
        public FormClasse()
        {
            InitializeComponent();
            //ClasseController cl = new ClasseController();
            LoadData();
        }

        private void LoadData()
        {
            ClasseController cl = new ClasseController();
            List<Classe> classes = new List<Classe>();
            classes = cl.FindAll();
            tableauClasse.Rows.Clear(); 
            foreach (Classe elt in classes)
            {
                //tableauClasse
                tableauClasse.Rows.Add();
               // Console.WriteLine(tableauClasse.Rows.Count);
                tableauClasse.Rows[tableauClasse.Rows.Count-2].Cells["id"].Value = elt.IdClasse;
                tableauClasse.Rows[tableauClasse.Rows.Count-2].Cells["designation"].Value = elt.Designation;
                tableauClasse.Rows[tableauClasse.Rows.Count-2].Cells["description"].Value = elt.Description;
                tableauClasse.Rows[tableauClasse.Rows.Count-2].Cells["effectif"].Value = 25;
            }
        }
        private void FormClasse_Load(object sender, EventArgs e)
        {

        }

        private void tableauClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AjoutClasseBtn_Click(object sender, EventArgs e)
        {
            //new Main().openForm(new AjoutClasse(),sender);
            //this.Hide();
            //AjoutClasse ajoutClasse = new AjoutClasse();
            
            ////ajoutClasse.TopLevel = false;
            ////ajoutClasse.FormBorderStyle = FormBorderStyle.None;
            /////ajoutClasse.Dock = DockStyle.Fill;
            //ajoutClasse.Show();
        }
    }
}
