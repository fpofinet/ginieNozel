using Nozel.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Controller
{
    internal class TrancheController
    {
        Connexion con = new Connexion();
        public TrancheController()
        {

        }

        public void InsertTranche(Tranche tr)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "INSERT INTO tranche (idScolarite,montant,createdAt) VALUES (@idScolarite,@montant,@date)";
                cmd.Parameters.AddWithValue(@"idScolarite", tr.IdScolarite);
                cmd.Parameters.AddWithValue(@"montant", tr.Montant);
                cmd.Parameters.AddWithValue(@"date", tr.DateVersement);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Utils.Utils.AddLog("[erreur]" + ex.Message);
                //Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }
        public void UpdateTranche(Tranche tr)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "UPDATE tranche SET montant=@montant WHERE idTranche=@id";
                cmd.Parameters.AddWithValue(@"id", tr.IdTranche);
                cmd.Parameters.AddWithValue(@"montant", tr.Montant);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Utils.Utils.AddLog("[erreur]" + ex.Message);
                //Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }

        public void DeleteTranche(Tranche tr)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "DELETE FROM tranche  WHERE idTranche=@id";
                cmd.Parameters.AddWithValue(@"id", tr.IdTranche);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Utils.Utils.AddLog("[erreur]" + ex.Message);
                //Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }
        public List<Tranche> FindAll()
        {
            List<Tranche> Tranches = new List<Tranche>();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM Tranche";
            SQLiteCommand cmder = new SQLiteCommand(stmt, con.getConnexion());
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                Tranche tr = new Tranche();
                tr.IdTranche = rd.GetInt32(0);
                tr.IdScolarite = rd.GetInt32(1);
                tr.Montant = rd.GetDouble(2);
                tr.DateVersement = rd.GetString(3);
        
                Tranches.Add(tr);
            }
            rd.Close();
            con.getConnexion().Close();

            return Tranches;
        }

        public Tranche FindById(int id)
        {
            Tranche tr = new Tranche();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM tranche WHERE idTranche=@id";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue("id", id);
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                tr.IdTranche = rd.GetInt32(0);
                tr.IdScolarite = rd.GetInt32(1);
                tr.Montant = rd.GetDouble(2);
                tr.DateVersement = rd.GetString(3);
            }
            rd.Close();
            con.getConnexion().Close();
            if (tr.IdTranche != 0)
            {
                return tr;
            }
            else
            {
                return null;
            }
        }

        public Eleve getEleve(int id)
        {
            ScolariteController scC = new ScolariteController();
            EleveController eleveController = new EleveController();

            Tranche te= FindById(id);
            Scolarite sc = scC.FindById(te.IdScolarite);
            Eleve eleve = eleveController.FindById(sc.IdEleve);
            
            return eleve;
        }
    }
}
