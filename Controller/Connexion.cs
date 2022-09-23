using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Controller
{
    internal class Connexion
    {

        string path;
        private  string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string mydir;
        private SQLiteConnection connexion;
        public Connexion()
        {
            Create_db();
        }
       
        private void Create_db()
        {
            //creation du repertoire de la base de données dans le repertoire appdata/roaming
            mydir = appdata + "\\nozel";
            if (!Directory.Exists(mydir))
            {
                Directory.CreateDirectory(mydir);
            }

            //creation du fichier de la base de donnees
            path = mydir + "\\dataApp.db";
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                connexion = new SQLiteConnection(@"Data Source=" + path);
                Utils.Utils.AddLog("[DBCREATE] "+ path);
                
                try 
                {
                    connexion.Open();
                    string sql0 = "CREATE TABLE classe (idClasse INTEGER,designation text,description text,effectif INTEGER,frais REAL,PRIMARY KEY('idClasse' AUTOINCREMENT))";
                    string sql1 = "CREATE TABLE eleve (idEleve INTEGER,matricule text,nom text,prenom text,dateNaiss text,sexe text,idClasse INTEGER," +
                                 "nomTuteur	TEXT,contactTuteur TEXT,adresse text,idAnnee INTEGER,PRIMARY KEY('idEleve' AUTOINCREMENT),FOREIGN KEY (idClasse) REFERENCES classe (idClasse),FOREIGN KEY (idAnnee) REFERENCES anneeScolaire (idAnnee))";
                    string sql2 = "CREATE TABLE matiere(idMatiere INTEGER,designation text,description text,PRIMARY KEY('idMatiere' AUTOINCREMENT))";
                    string sql3 = "CREATE TABLE note(idNote INTEGER,idMatiere INTEGER,idEleve INTEGER,note REAL,PRIMARY KEY('idNote' AUTOINCREMENT),FOREIGN KEY (idMatiere) REFERENCES matiere (idMatiere),FOREIGN KEY (idEleve) REFERENCES eleve (idEleve))";
                    string sql4 = "CREATE TABLE scolarite(idScolarite INTEGER,idEleve INTEGER,idClasse INTEGER,total REAL,PRIMARY KEY('idScolarite' AUTOINCREMENT),FOREIGN KEY (idEleve) REFERENCES eleve (idEleve),FOREIGN KEY (idClasse) REFERENCES classe (idClasse))";
                    string sql5 = "CREATE TABLE tranche(idTranche INTEGER,idScolarite INTEGER, montant REAL,createdAt TEXT, PRIMARY KEY('idTranche' AUTOINCREMENT))";
                    string sql6 = "CREATE TABLE anneeScolaire(idAnnee INTEGER,annee text,PRIMARY KEY('idAnnee' AUTOINCREMENT))";
                    string sql7 = "CREATE TABLE anciennete (idAnc INTEGER,idEleve INTEGER,idAnnee INTEGER,classe TEXT,PRIMARY KEY(idAnc AUTOINCREMENT),FOREIGN KEY(idAnnee) REFERENCES anneeScolaire(idAnnee),FOREIGN KEY(idEleve) REFERENCES eleve(idEleve))";
                    SQLiteCommand commande0 = new SQLiteCommand(sql0, connexion);
                    SQLiteCommand commande1 = new SQLiteCommand(sql1, connexion);
                    SQLiteCommand commande2 = new SQLiteCommand(sql2, connexion);
                    SQLiteCommand commande3 = new SQLiteCommand(sql3, connexion);
                    SQLiteCommand commande4 = new SQLiteCommand(sql4, connexion);
                    SQLiteCommand commande5 = new SQLiteCommand(sql5, connexion);
                    SQLiteCommand commande6 = new SQLiteCommand(sql6, connexion);
                    SQLiteCommand commande7 = new SQLiteCommand(sql7, connexion);

                    commande0.ExecuteNonQuery();
                    commande6.ExecuteNonQuery();
                    commande1.ExecuteNonQuery();
                    commande2.ExecuteNonQuery();
                    commande3.ExecuteNonQuery();
                    commande4.ExecuteNonQuery();
                    commande5.ExecuteNonQuery();
                    commande7.ExecuteNonQuery();
                } catch (Exception ex)
                {
                    Utils.Utils.AddLog("[erreur] "+ ex.Message); 
                }
                connexion.Close();
                Utils.Utils.AddLog("base de donnees creer avec succes");
                
            }
        }
        public SQLiteConnection getConnexion()
        {
            if (connexion == null)
            {
                connexion = new SQLiteConnection(@"Data Source=" +path);
            }
            return this.connexion;
        }
    }
}
