﻿using System;
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
        private string myFile="debug.txt";
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

            // creation du fichier log
            myFile = mydir + "\\debug.txt";
            if (!File.Exists(myFile))
            {
                File.Create(myFile);
            }

            //creation du fichier de la base de donnees
            path = mydir + "\\dataApp.db";
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                connexion = new SQLiteConnection(@"Data Source=" + path);
                Console.WriteLine(path);
                try 
                {
                    connexion.Open();
                    string sql0 = "CREATE TABLE classe (idClasse INTEGER,designation text,description text,effectif INTEGER,PRIMARY KEY('idClasse' AUTOINCREMENT))";
                    string sql1 = "CREATE TABLE eleve (idEleve INTEGER,matricule text,nom text,prenom text,dateNaiss text,sexe text,idClasse INTEGER,PRIMARY KEY('idEleve' AUTOINCREMENT),FOREIGN KEY (idClasse) REFERENCES classe (idClasse))";
                    string sql2 = "CREATE TABLE matiere(idMatiere INTEGER,designation text,description text,PRIMARY KEY('idMatiere' AUTOINCREMENT))";
                    string sql3 = "CREATE TABLE note(idNote INTEGER,idMatiere INTEGER,idEleve INTEGER,note REAL,PRIMARY KEY('idNote' AUTOINCREMENT),FOREIGN KEY (idMatiere) REFERENCES matiere (idMatiere),FOREIGN KEY (idEleve) REFERENCES eleve (idEleve))";
                    string sql4 = "CREATE TABLE scolarite(idScolarite INTEGER,idEleve INTEGER,idClasse INTEGER,total REAL,PRIMARY KEY('idScolarite' AUTOINCREMENT),FOREIGN KEY (idEleve) REFERENCES eleve (idEleve),FOREIGN KEY (idClasse) REFERENCES classe (idClasse))";
                    string sql5 = "CREATE TABLE tranche(idTranche INTEGER,idScolarite INTEGER, montant REAL,PRIMARY KEY('idTranche' AUTOINCREMENT))";
                    SQLiteCommand commande0 = new SQLiteCommand(sql0, connexion);
                    SQLiteCommand commande1 = new SQLiteCommand(sql1, connexion);
                    SQLiteCommand commande2 = new SQLiteCommand(sql2, connexion);
                    SQLiteCommand commande3 = new SQLiteCommand(sql3, connexion);
                    SQLiteCommand commande4 = new SQLiteCommand(sql4, connexion);
                    SQLiteCommand commande5 = new SQLiteCommand(sql5, connexion);
                    commande0.ExecuteNonQuery();
                    commande1.ExecuteNonQuery();
                    commande2.ExecuteNonQuery();
                    commande3.ExecuteNonQuery();
                    commande4.ExecuteNonQuery();
                    commande5.ExecuteNonQuery();
                } catch (Exception ex)
                {
                    File.AppendAllText(myFile, "erreur lors de la creation de la base de données" + DateTime.Now + Environment.NewLine);
                    File.AppendAllText(myFile, ex.Message + DateTime.Now + Environment.NewLine);
                }
                connexion.Close();
                File.AppendAllText(myFile, "base de donne creer avec succes " + DateTime.Now + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(myFile, "la base de donnees existe deja " + DateTime.Now + Environment.NewLine);
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
