using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nozel.Models;


namespace Nozel.Controller
{

    internal class ScolariteController
    {
        Connexion con = new Connexion();

        public ScolariteController()
        {

        }

        public void InsertScolarite(Scolarite sc)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "INSERT INTO scolarite (IdEleve,idClasse,total) VALUES (@idEleve,@idClasse,@total)";
                cmd.Parameters.AddWithValue(@"idEleve", sc.IdEleve);
                cmd.Parameters.AddWithValue(@"idClasse", sc.IdClasse);
                cmd.Parameters.AddWithValue(@"total", sc.Total);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }

        public void UpdateScolarite(Scolarite sc)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "UPDATE scolarite SET IdEleve=@idEleve,idClasse=@idClasse,total=@total WHERE idScolarite=@id";
                cmd.Parameters.AddWithValue(@"idEleve", sc.IdEleve);
                cmd.Parameters.AddWithValue(@"idClasse", sc.IdClasse);
                cmd.Parameters.AddWithValue(@"total", sc.Total);
                cmd.Parameters.AddWithValue(@"id", sc.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }

        public void DeleteScolarite(Scolarite sc)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "DELETE FROM scolarite WHERE idScolarite=@id";
                cmd.Parameters.AddWithValue(@"id", sc.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }
        public List<Scolarite> FindAll()
        {
            List<Scolarite> scolarites = new List<Scolarite>();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM scolarite";
            SQLiteCommand cmder = new SQLiteCommand(stmt, con.getConnexion());
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                Scolarite sc = new Scolarite();
                sc.Id = rd.GetInt32(0);
                sc.IdEleve = rd.GetInt32(1);
                sc.Total = rd.GetInt32(2);
                sc.IdClasse = rd.GetInt32(3);
                sc.Total = rd.GetDouble(4);

                scolarites.Add(sc);
            }
            rd.Close();
            con.getConnexion().Close();

            return scolarites;
        }
        public Scolarite FindById(int id)
        {
            Scolarite sc = new Scolarite();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM scolarite WHERE idScolarite=@id";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue(@"id", id);
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                sc.Id = rd.GetInt32(0);
                sc.IdEleve = rd.GetInt32(1);
                
                sc.IdClasse = rd.GetInt32(2);
                sc.Total = rd.GetDouble(3);
            }
            rd.Close();
            con.getConnexion().Close();
            if (sc.Id != 0)
            {
                return sc;
            }
            else
            {
                return null;
            }
        }

        public Scolarite FindByEleve(int id)
        {
            Scolarite sc = new Scolarite();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM scolarite WHERE idEleve=@id";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue(@"id", id);
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                sc.Id = rd.GetInt32(0);
                sc.IdEleve = rd.GetInt32(1);
                sc.IdClasse = rd.GetInt32(2);
                sc.Total = rd.GetDouble(3);
            }
            rd.Close();
            con.getConnexion().Close();
            if (sc.Id != 0)
            {
                return sc;
            }
            else
            {
                return null;
            }
        }

        public List<Scolarite> FindByClasse(int id)
        {
            List<Scolarite> scolarites = new List<Scolarite>();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM scolarite WHERE idClasse=@id";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue(@"id", id);
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                Scolarite sc = new Scolarite();
                sc.Id = rd.GetInt32(0);
                sc.IdEleve = rd.GetInt32(1);
                sc.IdClasse = rd.GetInt32(2);
                sc.Total = rd.GetDouble(3);
               

                scolarites.Add(sc);
            }
            rd.Close();
            con.getConnexion().Close();

            return scolarites;
        }

        public void AddScolarite(int idSco,int montant)
        {
            Scolarite sc = new Scolarite();
            sc=FindById(idSco);
            sc.Total+=montant;

            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "UPDATE scolarite SET total=@total WHERE idScolarite=@id";
                cmd.Parameters.AddWithValue(@"total", sc.Total);
                cmd.Parameters.AddWithValue(@"id", sc.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }
    }
}
