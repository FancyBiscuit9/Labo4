using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Labo4.Models
{
    public class CoursDataContext
    {
        private readonly string ConnectionString;

        /// <summary>
        /// Constructeur : Recoit une chaine de connexion en parametre
        /// </summary>
        public CoursDataContext(string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }

        /// <summary>
        /// insere une donnée de type cours dans la table cours
        /// </summary>
        /// <param name="cours"></param>
        public void Insert(Cours cours)
        {
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                // deifnir la requete
                int numeroCours = cours.NumeroCours;
                string intitule = cours.Intitule;
                int nombreCredit = cours.NombreCredit;
                string session = cours.Session;
                string sqlStr = "insert into Cours (NumeroCours, Intitule, NombreCredit, Session) values (@numeroCours, @intitule, @nombreCredit, @session);";
                //execution de la requete sql
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        /// <summary>
        /// Permet d'aller chercher toute les données de la table Cours
        /// </summary>
        /// <returns></returns>
        public List<Cours> Select()
        {
            // Liste de cours
            List<Cours> ListeCours = new List<Cours>();

            // Source : Code du word Chapitre06.docs
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                //definir la requete sql
                string sqlStr = "select * from Cours";
                // execution de la requete
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //récuperer les données
                while (rdr.Read())
                {
                    Cours coursBoucle = new Cours();
                    coursBoucle.NumeroCours = rdr.GetInt32(0);
                    coursBoucle.Intitule = rdr.GetString(1);
                    coursBoucle.NombreCredit = rdr.GetInt32(2);
                    coursBoucle.Session = rdr.GetString(3);
                }
                // fermer la connexion
                cn.Close();
            }
            return ListeCours;
        }

        /// <summary>
        /// Permet d'aller chercher une valeur de la table Cours avec le numero du Cours
        /// </summary>
        /// <param name="numeroCours"></param>
        /// <returns></returns>
        public Cours Select(int numeroCours)
        {
            Cours cours = new Cours();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                // définir la requete
                string sqlStr = "select * from Cours where NumeroCours=@numeroCours";
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.Parameters.AddWithValue("NumeroCours", numeroCours);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    cours.NumeroCours = rdr.GetInt32(0);
                    cours.Intitule = rdr.GetString(1);
                    cours.NombreCredit = rdr.GetInt32(2);
                    cours.Session = rdr.GetString(3);
                }
                cn.Close();
            }
            return cours;
        }
    }
}
