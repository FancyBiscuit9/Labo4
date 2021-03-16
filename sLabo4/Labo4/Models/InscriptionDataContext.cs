using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Labo4.Models
{
    public class InscriptionDataContext
    {
        private readonly string ConnectionString;

        /// <summary>
        /// Constructeur : Recoit une chaine de connexion en parametre
        /// </summary>
        public InscriptionDataContext(string connectionstring) => this.ConnectionString = connectionstring;

        /// <summary>
        /// insere une donnée de type cours dans la table Inscription
        /// </summary>
        /// <param name="cours"></param>
        public void Insert(Inscription inscription)
        {
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                // deifnir la requete
                int nas = inscription.NAS;
                string numCours = inscription.NumeroCours;
                DateTime date = inscription.DateInscription;
               
                string sqlStr = "insert into Inscription (NAS, NumeroCours, DateInscription) values (@nas, @numCours, @date);";
                //execution de la requete sql
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
