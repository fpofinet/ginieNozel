using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Models
{
    internal class Eleve
    {
        private int idEleve;
        private string matricule;
        private string nom;
        private string prenom;
        private string dateNaiss;
        private string sexe;
        private int idClasse;

        public Eleve(int idEleve, string matricule, string nom, string prenom, string dateNaiss, string sexe, int idClasse)
        {
            this.idEleve = idEleve;
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.sexe = sexe;
            this.idClasse = idClasse;
        }

        public Eleve()
        {
        }

        public int IdEleve { get => idEleve; set => idEleve = value; }
        public string Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public int IdClasse { get => idClasse; set => idClasse = value; }
    }
}
