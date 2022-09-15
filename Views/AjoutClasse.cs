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
        }

        public AjoutClasse(int idC)
        {
            InitializeComponent();
            classe = control.FindById(idC);
            Console.WriteLine(classe.IdClasse);
            description.Text = classe.Description;
            designation.Text = classe.Designation;
            frais.Text = classe.Frais.ToString() ;
        }

        private void saveClasseBtn_Click(object sender, EventArgs e)
        {
            classe.Description = description.Text;
            classe.Designation = designation.Text;
            classe.Frais = double.Parse(frais.Text);
            if(classe.IdClasse == 0)
            {
                control.InsertClasse(classe);
            } else
            {
                control.UpdateClasse(classe);
            }
            description.Clear();
            designation.Clear();
            frais.Clear();
            classe = new Classe();
            Utils.Utils.Open(new Views.FormClasse(), Main.mainPanel);
        }

        private void annulerClasseBtn_Click(object sender, EventArgs e)
        {
            description.Clear();
            designation.Clear();
            saveClasseBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
            saveClasseBtn.Text = "ENREGISTRER";
        }

        private void backClasseBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new Views.FormClasse(), Main.mainPanel);
        }
    }
}
