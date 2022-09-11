using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Models
{
    internal class Scolarite
    {
        private int id;
        private int idEleve;
        private int idClasse;
        private double total;

        public Scolarite(int id, int idEleve, double total,int idClasse)
        {
            this.id = id;
            this.idEleve = idEleve;
            this.total = total;
            this.idClasse = idClasse;
        }

        public Scolarite()
        {
        }
        public int Id { get => id; set => id = value; }
        public int IdEleve { get => idEleve; set => idEleve = value; }
        public int IdClasse { get => idClasse; set => idClasse = value; }
        public double Total { get => total; set => total = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
