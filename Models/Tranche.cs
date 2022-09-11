using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Models
{
    internal class Tranche
    {
        private int idTranche;
        private int idScolarite;
        private double montant;
        private string dateVersement;

        public int IdTranche { get => idTranche; set => idTranche = value; }
        public int IdScolarite { get => idScolarite; set => idScolarite = value; }
        public double Montant { get => montant; set => montant = value; }
        public string DateVersement { get => dateVersement; set => dateVersement = value; }

        public Tranche(int idTranche, int idScolarite, double montant, string dateVersement)
        {
            this.idTranche = idTranche;
            this.idScolarite = idScolarite;
            this.montant = montant;
            this.dateVersement = dateVersement;
        }
        public Tranche()
        {
        }
    }
}
