using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* 2)	(2 points) La classe nommée "Etudiant" qui représente 
 * la table "Etudiants
 * 
 * -	Tous les champs sont requis ; 
 * -	Les champs (nom, prénom et intitule) ne contiennent que des lettres et commencent par une lettre majuscule. 
 * -	La champ session doit avoir comme valeur l'une des valeurs (Hiver, Automne ou Été). 
 * -	Le champ (numéro de la sécurité sociale) ne contient que des chiffres et des espaces. Il doit être sous la forme CCC CCC CCC.
 * -	Le champ code postal doit être de la forme : 
 * •	LCL CLC ou  LCL-CLC
 * -	Le champ numéro de téléphone doit avoir la forme suivante :
 * •	 (xxx) xxx-xxxx  ou (xxx) xxx xxxx
 * -	Le champ courriel doit être sous la forme xxxx@yyyy.(com|ca|fr).
*/

namespace Labo4.Models
{
    public class Etudiants
    {
        
        public int NAS { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Courriel { get; set; }
        public string Sexe { get; set; }
        public string Langue { get; set; }


    }
}
