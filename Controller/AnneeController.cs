using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nozel.Models;

namespace Nozel.Controller
{
    internal class AnneeController
    {

        Connexion con = new Connexion();

        public AnneeController()
        {
        }

        public void InsertAnnee(string c)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "INSERT INTO anneeScolaire (annee,status) VALUES (@annee,@status)";
                cmd.Parameters.AddWithValue(@"annee", c);
                cmd.Parameters.AddWithValue(@"annee", 0);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Utils.Utils.AddLog("[erreur]  " + ex.Message);
            }
            con.getConnexion().Close();
        }

        public List<Annee> FindAll()
        {
            List<Annee> anneesSco = new List<Annee>();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM anneeScolaire";
            SQLiteCommand cmder = new SQLiteCommand(stmt, con.getConnexion());
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                Annee an=new Annee();
                
                an.IdAnnee = rd.GetInt32(0);
                an.Anne=rd.GetString(1);
                an.Status = rd.GetInt32(2);
                anneesSco.Add(an);
            }
            rd.Close();
            con.getConnexion().Close();
            return anneesSco;
        }

        public Annee FindById(int id)
        {
            Annee an = new Annee();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM anneeScolaire WHERE idAnnee=@id";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue("id", id);
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                an.IdAnnee = rd.GetInt32(0);
                an.Anne = rd.GetString(1);
                an.Status = rd.GetInt32(2);
            }
            rd.Close();
            con.getConnexion().Close();
            if (an.IdAnnee != 0)
            {
                return an;
            }
            else
            {
                return null;
            }
        }

        public Annee FindByAnne(string annee)
        {
            Annee an = new Annee();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM anneeScolaire WHERE annee=@annee";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue("annee", annee);
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                an.IdAnnee = rd.GetInt32(0);
                an.Anne = rd.GetString(1);
                an.Status = rd.GetInt32(2);
            }
            rd.Close();
            con.getConnexion().Close();
            if (an.IdAnnee != 0)
            {
                return an;
            }
            else
            {
                return null;
            }
        }

        public static Annee FindCurrent()
        {
            Connexion con2 = new Connexion();
            Annee an = new Annee();
            con2.getConnexion().Open();
            String stmt = "SELECT * FROM anneeScolaire ORDER BY idAnnee DESC LIMIT 1";
            SQLiteCommand cmder = new SQLiteCommand(con2.getConnexion());
            cmder.CommandText = stmt;
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                an.IdAnnee = rd.GetInt32(0);
                an.Anne = rd.GetString(1);
                an.Status = rd.GetInt32(2);
            }
            rd.Close();
            con2.getConnexion().Close();
            if (an.IdAnnee != 0)
            {
                return an;
            }
            else
            {
                return null;
            }
        }

        public void CloturerAnnee()
        {
            EleveController ec = new EleveController();
            ClasseController cc = new ClasseController();
            List<Eleve> eleves = ec.FindAllByAnnee(FindCurrent().Anne);
            Console.WriteLine(eleves.Count);
            foreach(Eleve eleve in eleves)
            {
                ArchiveEleve(eleve.IdEleve, AnneeController.FindCurrent().IdAnnee, cc.FindById(eleve.IdClasse).Designation);
            }
            
        }

        private void ArchiveEleve(int e, int a, string c)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "INSERT INTO anciennete (idEleve,idAnnee,classe) VALUES (@eleve,@annee,@classe)";
                cmd.Parameters.AddWithValue(@"eleve", e);
                cmd.Parameters.AddWithValue(@"annee", a);
                cmd.Parameters.AddWithValue(@"classe", c);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Utils.Utils.AddLog("[erreur]  " + ex.Message);
            }
            con.getConnexion().Close();
        }

        public void closeAnnee(int id)
        {
            try
            {
                Console.WriteLine("ici");
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "UPDATE anneeScolaire SET status=@st WHERE idAnnee=@id";
                cmd.Parameters.AddWithValue(@"id",id);
                cmd.Parameters.AddWithValue(@"st",1);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Utils.Utils.AddLog("Donnne  ");
            }
            catch (Exception ex)
            {
                Utils.Utils.AddLog("[erreur]  " + ex.Message);
            }
            con.getConnexion().Close();
        }
    }
}
