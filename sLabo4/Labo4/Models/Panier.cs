using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * (2 points) La classe nommée "Panier" qui nous permet 
 * de gérer les cours choisis par un étudiant. 
 * 
 */


namespace Labo4.Models
{
    public class Panier
    {
        private int nas;

        // methode d'acces
        public static List<Cours> ListeCours { get; set; }
        public int Nas { get => nas; set => nas = value; }

        /// <summary>
        /// constructeur
        /// </summary>
        public Panier() { }
        
        /// <summary>
        /// Constructeur avec parametre
        /// </summary>
        /// <param name="ListeCours"></param>
        /// <param name="NAS"></param>
        public Panier(int NAS) => this.Nas = NAS;

        /// <summary>
        /// Ajoute un cours
        /// </summary>
        /// <param name="cours"></param>
        public void Ajouter(Cours cours) => ListeCours.Add(cours);

        /// <summary>
        /// supprime le cours donnée en parametre
        /// </summary>
        /// <param name="numCours">Le numero du cours</param>
        /// <returns></returns>
        public bool Supprimer(int numCours)
        {
            bool Verification = false;
            foreach (Cours cours in ListeCours)
            {
                if(cours.NumeroCours == numCours)
                {
                    ListeCours.Remove(cours);
                    Verification = true;
                }
            }
            return Verification;
        }

        /// <summary>
        /// Vide la liste au complet
        /// </summary>
        public void Vider() => ListeCours.Clear();
    }
}
