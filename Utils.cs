using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    internal class Utils
    {
        public static Form activeForm;
        public static void Open(Form child,Panel parent)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            parent.Controls.Add(child);
            parent.Tag = child;
            child.BringToFront();
            child.Show();
            //this.nameLabel.Text = active.Text;
        }
    }
}
