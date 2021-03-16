using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Labo4.Models
{
    public class EtudiantsDataContext
    {
        private readonly string ConnectionString;

        /// <summary>
        /// Constructeur : Recoit une chaine de connexion en parametre
        /// </summary>
        public EtudiantsDataContext(string connectionstring) => this.ConnectionString = connectionstring;
        
        
        /// <summary>
        /// insere une donnée de type cours dans la table cours
        /// </summary>
        /// <param name="cours"></param>
        public void Insert(Etudiants etudiant)
        {
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                // deifnir la requete
                int nas = etudiant.NAS;
                string nom = etudiant.Nom;
                string prenom = etudiant.Prenom;
                string telephone = etudiant.Telephone;
                string addresse = etudiant.Adresse;
                string codePostal = etudiant.CodePostal;
                string courriel = etudiant.Courriel;
                string sexe = etudiant.Sexe;
                string langue = etudiant.Langue;
                string sqlStr = "insert into Etudiant (NAS, Nom, Prenom, Telephone, Adresse, CodePostal, Courriel, sexe, Langue) values (@nas, @nom, @prenom, @telephone, @adresse, @codePostal, @courriel, @sexe, @langue);";
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
        public List<Etudiants> Select()
        {
            // Liste de cours
            List<Etudiants> ListeEtudiants = new List<Etudiants>();

            // Source : Code du word Chapitre06.docs
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                //definir la requete sql
                string sqlStr = "select * from Etudiant";
                // execution de la requete
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //récuperer les données
                while (rdr.Read())
                {
                    Etudiants etudiantBoucle = new Etudiants();
                    etudiantBoucle.NAS = rdr.GetInt32(0);
                    etudiantBoucle.Nom = rdr.GetString(1);
                    etudiantBoucle.Prenom = rdr.GetString(2);
                    etudiantBoucle.Telephone = rdr.GetString(3);
                    etudiantBoucle.Adresse = rdr.GetString(4);
                    etudiantBoucle.CodePostal = rdr.GetString(5);
                    etudiantBoucle.Courriel = rdr.GetString(6);
                    etudiantBoucle.Sexe = rdr.GetString(7);
                    etudiantBoucle.Langue = rdr.GetString(8);

                }
                // fermer la connexion
                cn.Close();
            }
            return ListeEtudiants;
        }

        /// <summary>
        /// Permet d'aller chercher une valeur de la table Cours avec le numero du Cours
        /// </summary>
        /// <param name="numeroCours"></param>
        /// <returns></returns>
        public Etudiants Select(int nas)
        {
            Etudiants etudiant = new Etudiants();

            // Source : Code du word Chapitre06.docs
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                // définir la requete
                string sqlStr = "select * from Cours where NAS=@nas";
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.Parameters.AddWithValue("NAS", nas);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    etudiant.NAS = rdr.GetInt32(0);
                    etudiant.Nom = rdr.GetString(1);
                    etudiant.Prenom = rdr.GetString(2);
                    etudiant.Telephone = rdr.GetString(3);
                    etudiant.Adresse = rdr.GetString(4);
                    etudiant.CodePostal = rdr.GetString(5);
                    etudiant.Courriel = rdr.GetString(6);
                    etudiant.Sexe = rdr.GetString(7);
                    etudiant.Langue = rdr.GetString(8);
                }
                cn.Close();
            }
            return etudiant;
        }
    }
}
