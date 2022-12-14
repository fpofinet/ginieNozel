using Nozel.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nozel.Controller
{
    internal class ClasseController
    {
        Connexion con = new Connexion();
        
        public ClasseController()
        {
        }

        public void InsertClasse(Classe c)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "INSERT INTO classe (designation,description,effectif,frais) VALUES (@designation,@description,@effectif,@frais)";
                cmd.Parameters.AddWithValue(@"designation", c.Designation);
                cmd.Parameters.AddWithValue(@"description", c.Description);
                cmd.Parameters.AddWithValue(@"effectif",0);
                cmd.Parameters.AddWithValue(@"frais", c.Frais);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            } catch (Exception ex)
            {
                Utils.Utils.AddLog("[erreur]" + ex.Message);
                //Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }

        public List<Classe> FindAll()
        {
            List <Classe> classes= new List<Classe>();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM classe";
            SQLiteCommand cmder = new SQLiteCommand(stmt, con.getConnexion());
            SQLiteDataReader rd = cmder.ExecuteReader();
            while (rd.Read())
            {
                Classe cl = new Classe();
                cl.IdClasse = rd.GetInt32(0);
                cl.Designation = rd.GetString(1);
                cl.Description = rd.GetString(2);
                cl.Effectif = rd.GetInt32(3);
                cl.Frais = rd.GetDouble(4);
                classes.Add(cl);
            }
            rd.Close();
            con.getConnexion().Close();

            return classes;
        }

        public void UpdateClasse(Classe c)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "UPDATE classe SET designation=@designation,description=@description,frais=@frais WHERE idClasse=@id";
                cmd.Parameters.AddWithValue(@"id", c.IdClasse);
                cmd.Parameters.AddWithValue(@"designation", c.Designation);
                cmd.Parameters.AddWithValue(@"description", c.Description);
                cmd.Parameters.AddWithValue(@"frais", c.Frais);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Utils.Utils.AddLog("[erreur]" + ex.Message);
                // Console.WriteLine(ex.Message);
            }
            con.getConnexion().Close();
        }

        public Classe FindById(int id)
        {
            Classe cl = new Classe();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM classe WHERE idClasse=@id";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue("id", id);
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                cl.IdClasse = rd.GetInt32(0);
                cl.Designation = rd.GetString(1);
                cl.Description = rd.GetString(2);
                cl.Effectif = rd.GetInt32(3);
                cl.Frais = rd.GetDouble(4);
            }
            rd.Close();
            con.getConnexion().Close();
            if(cl.IdClasse != 0)
            {
                return cl;
            } else { 
                return null; 
            }
        }
        public Classe FindByDesignation(string desc)
        {
            Classe cl = new Classe();
            con.getConnexion().Open();
            String stmt = "SELECT * FROM classe WHERE designation=@desc";
            SQLiteCommand cmder = new SQLiteCommand(con.getConnexion());
            cmder.CommandText = stmt;
            cmder.Parameters.AddWithValue("desc", desc);
            SQLiteDataReader rd = cmder.ExecuteReader();
            if (rd.Read())
            {
                cl.IdClasse = rd.GetInt32(0);
                cl.Designation = rd.GetString(1);
                cl.Description = rd.GetString(2);
                cl.Effectif = rd.GetInt32(3);
                cl.Frais = rd.GetDouble(4);
            }
            rd.Close();
            con.getConnexion().Close();
            if (cl.IdClasse != 0)
            {
                return cl;
            }
            else
            {
                return null;
            }
        }

        public void DeleteClasse(Classe c)
        {
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "DELETE FROM classe WHERE idClasse=@id";
                cmd.Parameters.AddWithValue(@"id", c.IdClasse);
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
        
        public void addOneEleve(string des)
        {
            Classe cl = new Classe();
            cl = FindByDesignation(des);
            cl.Effectif += 1;
            
            try
            {
                con.getConnexion().Open();
                SQLiteCommand cmd = new SQLiteCommand(con.getConnexion());
                cmd.CommandText = "UPDATE classe SET effectif=@effectif WHERE idClasse=@id";
                cmd.Parameters.AddWithValue(@"id", cl.IdClasse);
                cmd.Parameters.AddWithValue(@"effectif", cl.Effectif);
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
        
        public double GetTotalScolarite(int idC)
        {
            double somme = 0;
            List<Scolarite> scs = new List<Scolarite>();
            ScolariteController scc = new ScolariteController();
            scs=scc.FindByClasse(idC);
            foreach (Scolarite s in scs)
            {
                somme += s.Total;
            }
            return somme;
        }
    }
}
