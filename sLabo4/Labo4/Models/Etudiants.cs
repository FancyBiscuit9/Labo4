using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/* 2)	(2 points) La classe nommée "Etudiant" qui représente 
 * la table "Etudiants
 * 
 * NAS - \d{3} \d{3} \d{3}
 * session - [AHE]\d{4}
 * code postal - \d\w\d[ -]\w\d\w
 * Nom - [A-Z]\w{1,}
 * 
 * -	Tous les champs sont requis ; 
 * -	Les champs (nom, prénom et intitule) ne contiennent que des lettres et commencent par une lettre majuscule. 
 * -	La champ session doit avoir comme valeur l'une des valeurs (Hiver, Automne ou Été). 
 * -	Le champ code postal doit être de la forme : 
 * •	LCL CLC ou  LCL-CLC
 * 
 * 
 * 
 * 
 * -	Le champ numéro de téléphone doit avoir la forme suivante :
 * •	 (xxx) xxx-xxxx  ou (xxx) xxx xxxx
 * -	Le champ courriel doit être sous la forme xxxx@yyyy.(com|ca|fr).
*/

namespace Labo4.Models
{
    public class Etudiants
    {
        [Display(Name = "Numero assurance social :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"\d{3} \d{3} \d{3}", ErrorMessage = "Veuillez entrer le NAS dans le format 999 999 999")]
        public int NAS { get; set; }

        [Display(Name = "Nom :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"[A-Z]\w{1,}", ErrorMessage = "Veuillez entrer votre nom avec une majuscule en premier(et sans numero)")]
        public string Nom { get; set; }

        [Display(Name = "Prenom :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"[A-Z]\w{1,}", ErrorMessage = "Veuillez entrer votre prenom avec une majuscule en premier(et sans numero)")]
        public string Prenom { get; set; }

        [Display(Name = "Telephone :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Phone]
        public string Telephone { get; set; }

        [Display(Name = "Adresse :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public string Adresse { get; set; }

        [Display(Name = "Code Postal :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"\d\w\d[ -]\w\d\w", ErrorMessage = "Veuillez entrer votre code postal dans le format : A1A 1A1 ou A1A-1A1")]
        public string CodePostal { get; set; }

        [Display(Name = "Courriel :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [EmailAddress]
        public string Courriel { get; set; }

        [Display(Name = "Sexe :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public string Sexe { get; set; }

        [Display(Name = "Langue :")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public string Langue { get; set; }
    }
}
