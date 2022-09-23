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
    public partial class ParametreForm : Form
    {
        public ParametreForm()
        {
            InitializeComponent();
            AnneeController ac= new AnneeController();
            List<Annee> list=ac.FindAll();
            anneBox.Items.Clear();
            foreach(Annee anne in list)
            {
                anneBox.Items.Add(anne.Anne);
            }
            if (AnneeController.FindCurrent().Status == 0)
            {
                addAnneeBtn.Enabled = false;
            }
            anneBox.SelectedIndex=anneBox.Items.Count-1;
            label3.Text= AnneeController.FindCurrent().Anne;
        }
        public void openForm()
        {
            anneeSF anneeSF = new anneeSF();
            anneeSF.TopLevel = false;
            anneeSF.FormBorderStyle = FormBorderStyle.None;
            anneeSF.Dock = DockStyle.Fill;
            this.Controls.Add(anneeSF);
            this.Tag = anneeSF;
            anneeSF.BringToFront();
            anneeSF.Show();
        }
        private void addAnneeBtn_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void btnCloture_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous cloturer cette année scolaire?";
            string title = "MESSAGE";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                AnneeController ac = new AnneeController();
                ac.CloturerAnnee();
                ac.closeAnnee(AnneeController.FindCurrent().IdAnnee);
            }
            addAnneeBtn.Enabled = true;
            addAnneeBtn.Focus();
        }
    }
}
