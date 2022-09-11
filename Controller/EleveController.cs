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
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "INSERT INTO eleve (matricule,nom,prenom,dateNaiss,sexe,idClasse) VALUES (@matricule,@nom,@prenom,@dateNaiss,@sexe,@idClasse)";
                cmd.Parameters.AddWithValue(@"matricule", e.Matricule);
                cmd.Parameters.AddWithValue(@"nom",e.Nom);
                cmd.Parameters.AddWithValue(@"prenom", e.Prenom);
                cmd.Parameters.AddWithValue(@"dateNaiss", e.DateNaiss);
                cmd.Parameters.AddWithValue(@"sexe", e.Sexe);
                cmd.Parameters.AddWithValue(@"idClasse", e.IdClasse);
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
                cmd.CommandText = "UPDATE eleve SET matricule=@matricule, nom=@nom, prenom=@prenom, dateNaiss=@dateNaiss, sexe=@sexe, idClasse=@idClasse WHERE idEleve=@id";
                cmd.Parameters.AddWithValue(@"matricule", e.Matricule);
                cmd.Parameters.AddWithValue(@"nom", e.Nom);
                cmd.Parameters.AddWithValue(@"prenom", e.Prenom);
                cmd.Parameters.AddWithValue(@"dateNaiss", e.DateNaiss);
                cmd.Parameters.AddWithValue(@"sexe", e.Sexe);
                cmd.Parameters.AddWithValue(@"idClasse", e.IdClasse);
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
                eleves.Add(el);
            }
            rd.Close();
            con.getConnexion().Close();

            return eleves;
            //return null;
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

        public List<Eleve> Search(string param)
        {
            List<Eleve> eleves = new List<Eleve>();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM eleve WHERE nom LIKE '%"+@param+"%'";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
           // cmder.Parameters.AddWithValue("param", param);
            SQLiteDataReader rd = cmder.ExecuteReader();
            //Console.WriteLine("ct"+param);
            while (rd.Read())
            {
               // Console.WriteLine("find");
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
    }
}
