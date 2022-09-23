using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Models
{
    internal class Annee
    {
        private int idAnnee=0;
        private string annee;
        private int status=0;
        public Annee()
        {

        }

        public int IdAnnee { get => idAnnee; set => idAnnee = value; }
        public string Anne { get => annee; set => annee = value; }
        public int Status { get => status; set => status = value; }
    }
}
