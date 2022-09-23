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

namespace Nozel.Views
{
    public partial class anneeSF : Form
    {
        public anneeSF()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            AnneeController anneeController = new AnneeController();
            anneeController.InsertAnnee(textBox1.Text);
            Utils.Utils.Open(new ParametreForm(), Main.mainPanel);
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Utils.Utils.Open(new ParametreForm(), Main.mainPanel);
        }
    }
}
