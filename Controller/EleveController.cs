using Nozel.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Controller
{
    internal class EleveController
    {
        Connexion con = new Connexion();
        public EleveController()
        {

        }

        public void InsertEleve(Eleve e)
        {
            string matri = NewMatricule();
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "INSERT INTO eleve (matricule,nom,prenom,dateNaiss,sexe,idClasse,nomTuteur,contactTuteur,adresse) " +
                                  "VALUES (@matricule,@nom,@prenom,@dateNaiss,@sexe,@idClasse,@nomTuteur,@contactTuteur,@adresse)";
                Console.WriteLine(matri);
                cmd.Parameters.AddWithValue(@"matricule", matri);
                cmd.Parameters.AddWithValue(@"nom",e.Nom);
                cmd.Parameters.AddWithValue(@"prenom", e.Prenom);
                cmd.Parameters.AddWithValue(@"dateNaiss", e.DateNaiss);
                cmd.Parameters.AddWithValue(@"sexe", e.Sexe);
                cmd.Parameters.AddWithValue(@"idClasse", e.IdClasse);
                cmd.Parameters.AddWithValue(@"nomTuteur", e.NomTuteur);
                cmd.Parameters.AddWithValue(@"contactTuteur", e.ContactTuteur);
                cmd.Parameters.AddWithValue(@"adresse", e.Adresse);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }

        public void UpdateEleve(Eleve e)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "UPDATE eleve SET nom=@nom, prenom=@prenom, dateNaiss=@dateNaiss, sexe=@sexe, idClasse=@idClasse,nomTuteur=@nomTuteur,contactTuteur=@contactTuteur,adresse=@adresse WHERE idEleve=@id";
                cmd.Parameters.AddWithValue(@"nom", e.Nom);
                cmd.Parameters.AddWithValue(@"prenom", e.Prenom);
                cmd.Parameters.AddWithValue(@"dateNaiss", e.DateNaiss);
                cmd.Parameters.AddWithValue(@"sexe", e.Sexe);
                cmd.Parameters.AddWithValue(@"idClasse", e.IdClasse);
                cmd.Parameters.AddWithValue(@"nomTuteur", e.NomTuteur);
                cmd.Parameters.AddWithValue(@"contactTuteur", e.ContactTuteur);
                cmd.Parameters.AddWithValue(@"adresse", e.Adresse);
                cmd.Parameters.AddWithValue(@"id", e.IdEleve);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }

        public void DeleteEleve(Eleve e)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "DELETE FROM eleve WHERE idEleve=@id";
                cmd.Parameters.AddWithValue(@"id", e.IdEleve);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }

        public List<Eleve> FindAll()
        {
            List<Eleve> eleves = new List<Eleve>();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM eleve";
            SQLiteCommand cmder = new SQLiteCommand(stmt, con.getConnexion());
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                Eleve el = new Eleve();
                el.IdEleve = rd.GetInt32(0);
                el.Matricule = rd.GetString(1);
                el.Nom = rd.GetString(2);
                el.Prenom = rd.GetString(3);
                el.DateNaiss = rd.GetString(4);
                el.Sexe = rd.GetString(5);
                el.IdClasse = rd.GetInt32(6);
                el.NomTuteur = rd.GetString(7);
                el.ContactTuteur = rd.GetString(8);
                el.Adresse = rd.GetString(9);
                eleves.Add(el);
            }
            rd.Close();
            con.getConnexion().Close();

            return eleves;
        }

        public Eleve FindById(int id) 
        {
            Eleve el = new Eleve();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM eleve WHERE idEleve=@id";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue("id", id);
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                el.IdEleve = rd.GetInt32(0);
                el.Matricule = rd.GetString(1);
                el.Nom = rd.GetString(2);
                el.Prenom = rd.GetString(3);
                el.DateNaiss = rd.GetString(4);
                el.Sexe = rd.GetString(5);
                el.IdClasse = rd.GetInt32(6);
                el.NomTuteur = rd.GetString(7);
                el.ContactTuteur = rd.GetString(8);
                el.Adresse = rd.GetString(9);
            }
            rd.Close();
            con.getConnexion().Close();
            if (el.IdClasse != 0)
            {
                return el;
            }
            else
            {
                return null;
            }
        }

        public List<Eleve> FindAllByClasse(string classe)
        {
            List<Eleve> eleves = new List<Eleve>();
            Classe cl = new Classe();
            ClasseController clc= new ClasseController();
            cl = clc.FindByDesignation(classe);

            
            con.getConnexion().Open();
            String stmt = "SELECT * FROM eleve WHERE idClasse=@id";
            SQLiteCommand cmder = new SQLiteCommand(stmt, con.getConnexion());
            cmder.Parameters.AddWithValue(@"id", cl.IdClasse);
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                Eleve el = new Eleve();
                el.IdEleve = rd.GetInt32(0);
                el.Matricule = rd.GetString(1);
                el.Nom = rd.GetString(2);
                el.Prenom = rd.GetString(3);
                el.DateNaiss = rd.GetString(4);
                el.Sexe = rd.GetString(5);
                el.IdClasse = rd.GetInt32(6);
                eleves.Add(el);
            }
            rd.Close();
            con.getConnexion().Close();

            return eleves;
        }

        public List<Eleve> Search(string param)
        {
            List<Eleve> eleves = new List<Eleve>();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM eleve WHERE nom LIKE '%"+@param+"%'";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                Eleve el = new Eleve();
                el.IdEleve = rd.GetInt32(0);
                el.Matricule = rd.GetString(1);
                el.Nom = rd.GetString(2);
                el.Prenom = rd.GetString(3);
                el.DateNaiss = rd.GetString(4);
                el.Sexe = rd.GetString(5);
                el.IdClasse = rd.GetInt32(6);
                el.NomTuteur = rd.GetString(7);
                el.ContactTuteur = rd.GetString(8);
                el.Adresse = rd.GetString(9);
                eleves.Add(el);
            }
            rd.Close();
            con.getConnexion().Close();
            return eleves;
        }

        public double GetSolde(int idE)
        {
            Eleve eleve = new Eleve();
            eleve=FindById(idE);
            if (eleve != null)
            {
                Scolarite sc = new Scolarite();
                ScolariteController scc = new ScolariteController();
                sc = scc.FindByEleve(eleve.IdEleve);
                return sc.Total;
            } else
            {
                return 0;
            } 
        }

        private string NewMatricule()
        {
            //SELECT * FROM Table ORDER BY ID DESC LIMIT 1
            Eleve el = new Eleve();
            string mat;
            con.getConnexion().Open();
            String stmt = "SELECT * FROM eleve ORDER BY idEleve DESC LIMIT 1";
            SQLiteCommand cmder = new SQLiteCommand(stmt, con.getConnexion());
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                el.IdEleve = rd.GetInt32(0);
                Console.WriteLine(el.IdEleve);
            }
            rd.Close();
            con.getConnexion().Close();
            if(el.IdEleve != 0)
            {
                mat = "mat0" + (el.IdEleve+1);
            }
            else
            {
                mat = "mat01";
            }
            Console.WriteLine(mat);
            return mat;
        }


    }
}
