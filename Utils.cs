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
        }

        public static int CalcAge(string date)
        {
            //int day = int.Parse(date.Substring(0, 2));
            //int month = int.Parse(date.Substring(date.IndexOf("/") + 1, 2));
            //int year = int.Parse(date.Substring(date.IndexOf("/") + 4, 4));
            //DateTime dt = new DateTime(year, month, day);
            DateTime dt = StringToDate(date);
            DateTime now = DateTime.Today;
            TimeSpan interval = now - dt;
            return interval.Days/365 ;
        }

        public static DateTime StringToDate(string date) 
        {
            int day = int.Parse(date.Substring(0, 2));
            int month = int.Parse(date.Substring(date.IndexOf("/") + 1, 2));
            int year = int.Parse(date.Substring(date.IndexOf("/") + 4, 4));
            DateTime dat = new DateTime(year, month, day);
            return dat;
        }
    }
}
