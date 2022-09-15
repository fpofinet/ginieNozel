using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Models
{
    internal class Classe
    {
        private int idClasse=0;
        private String designation;
        private String description;
        private int effectif=0;
        private double frais;

        public Classe(string designation, string description,int effectif,double frais)
        {
            this.Designation = designation;
            this.Description = description;
            this.Effectif = effectif;
            this.Frais = frais;
        }

        public Classe()
        {
        }

        public string Designation { get => designation; set => designation = value; }
        public int IdClasse { get => idClasse; set => idClasse = value; }
        public string Description { get => description; set => description = value; }
        public int Effectif { get => effectif; set => effectif = value; }
        public double Frais { get => frais; set => frais = value; }
    }
}
